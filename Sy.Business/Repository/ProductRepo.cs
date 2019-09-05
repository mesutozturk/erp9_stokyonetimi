using System;
using System.Collections.Generic;
using System.Linq;
using Sy.Core.Entities;
using Sy.Core.Enums;
using Sy.Core.ViewModels;

namespace Sy.Business.Repository
{
    public class ProductRepo : Repository<Product, Guid>
    {
        public List<ProductViewModel> GetProductList(string search = "")
        {
            var data = this.Context.Products.Where(x => x.ProductName.Contains(search))
                .Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    UnitPrice = x.UnitPrice,
                    CriticStock = x.CriticStock,
                    ProductName = x.ProductName,
                }).ToList();
            foreach (var item in data)
            {
                var actionList = this.Context.ProductStockActions.Where(x => x.ProductId == item.Id).ToList();
                if (!actionList.Any()) continue;

                var girenAdet = actionList.Where(x => x.StockActionType == StockActionType.Incoming)
                    .Sum(x => x.Quantity);
                var cikanAdet = actionList.Where(x => x.StockActionType == StockActionType.Outgoing)
                    .Sum(x => x.Quantity);
                item.UnitsInStock = girenAdet - cikanAdet;
            }

            return data;
        }
    }
}
