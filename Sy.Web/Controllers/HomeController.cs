using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Product, Guid> _productRepo;
        public HomeController()
        {
            this._productRepo = new ProductRepo();
        }
        public ActionResult Index()
        {
            List<ProductViewModel> model = ((ProductRepo)_productRepo).GetProductList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}