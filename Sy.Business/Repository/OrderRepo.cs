using System;
using System.Collections.Generic;
using Sy.Core.Entities;
using Sy.Core.Enums;
using Sy.Core.ViewModels;

namespace Sy.Business.Repository
{
    public class OrderRepo : Repository<Order, long>
    {
        public long MakeOrder(List<SepetViewModel> sepetList, DateTime requiredDate)
        {
            var orderId = 0L;
            using (var tran = this.Context.Database.BeginTransaction())
            {
                try
                {
                    //1. islem order
                    var newOrder = new Order()
                    {
                        RequiredDate = requiredDate
                    };
                    Context.Orders.Add(newOrder);
                    Context.SaveChanges();
                    orderId = newOrder.Id;

                    //2. islem orderdetail
                    foreach (var item in sepetList)
                    {
                        Context.OrderDetails.Add(new OrderDetail()
                        {
                            Id = newOrder.Id,
                            Id2 = item.ProductId,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice
                        });
                    }

                    Context.SaveChanges();

                    //3. islem productaction
                    foreach (var item in sepetList)
                    {
                        Context.ProductStockActions.Add(new ProductStockAction()
                        {
                            ProductId = item.ProductId,
                            Quantity = item.Quantity,
                            UnitPrice = item.UnitPrice,
                            StockActionType = StockActionType.Outgoing
                        });
                    }

                    Context.SaveChanges();

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                }
            }

            return orderId;
        }
    }
}
