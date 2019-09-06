using System;
using System.Collections.Generic;
using System.Linq;
using Sy.Core.Entities;
using Sy.Core.Enums;
using Sy.Core.ViewModels;

namespace Sy.Business.Repository
{
    public class OrderRepo : Repository<Order, long>
    {
        public long MakeOrder(List<SepetViewModel> sepetList, DateTime requiredDate)
        {
            long orderId;
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
                        //stokta o an varmi?

                        var actionList = Context.ProductStockActions
                            .Where(x => x.ProductId == item.ProductId).ToList();

                        var gelenAdet = actionList.Where(x => x.StockActionType == StockActionType.Incoming).Sum(x => x.Quantity);
                        var gidenAdet = actionList.Where(x => x.StockActionType == StockActionType.Outgoing).Sum(x => x.Quantity);

                        var toplam = gelenAdet - gidenAdet;
                        if (toplam < item.Quantity)
                            throw new Exception($"{item.ProductName} üründen stokta sipariş miktarı kadar bulunmamaktadır. Kalan stok: {toplam}");

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
                    Console.WriteLine(ex);
                    tran.Rollback();
                    throw;
                }
            }

            return orderId;
        }
    }
}
