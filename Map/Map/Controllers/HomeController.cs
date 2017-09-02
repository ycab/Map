using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Bytecode;
using NUnit;
using NUnit.Framework;
using log4net;
using Domain;
using DAO;

namespace Map.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
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
        private IProductDao productDao;

        [SetUp]
        public void Init()
        {
            productDao = new ProductDao();
        }
        public class NHiberTest
        {
            [Test]
            public void InitTest()
            {
                var cfg = new NHibernate.Cfg.Configuration().Configure(System.AppDomain.CurrentDomain.BaseDirectory + "hibernate.cfg.xml");
                using (ISessionFactory sessionFactory = cfg.BuildSessionFactory()) { }
            }
        }
        
        [Test]
        public void SaveTest()
        {
            var product = new Domain.Product
            {
                ID = Guid.NewGuid(),
                BuyPrice = 10M,
                Code = "ABC123",
                Name = "电脑",
                QuantityPerUnit = "20x1",
                SellPrice = 11M,
                Unit = "台"
            };

           // var obj = new ProductDao().Save(product);
            var obj = this.productDao.Save(product);
            Assert.NotNull(obj);
        }
    }
}