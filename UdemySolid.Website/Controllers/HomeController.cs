using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemySolid.Business;
using UdemySolid.Entity;

namespace UdemySolid.Website.Controllers
{
    public class HomeController : Controller
    {
        private CategoryBusiness _categoryBusiness;
        private ProductBusiness _productBusiness;

        public HomeController()
        {
            _categoryBusiness = new CategoryBusiness();
            _productBusiness = new ProductBusiness();   
        }
        public ActionResult Index()
        {
            ViewBag.Categories=_categoryBusiness.GetAll();
            ViewBag.Products=_productBusiness.GetAll();
            return View();
        }

        public void AddCustomer()
        {
            Customer bireysel = new IndividualCustomer()// üst sınıfı temel sııf uygular
            {
                Id = 1,
                FirstName = "Numan",
                LastName="tunçel",
                TcKimlik=545444545


            };
            Customer frima = new CompanyCustomer()
            {
                Id = 1,
                textNumber = "554545",
                Unvan = "Patron"


            };
            ProductBusiness productBusiness = new ProductBusiness();
        }
    }
}