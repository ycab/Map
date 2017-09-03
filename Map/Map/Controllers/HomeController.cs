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
        private IPersonDao productDao;

        [SetUp]
        public void Init()
        {
            productDao = new PersonDao();
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
            var product = new Domain.Person
            {
                ID = "second",
               
                Username = "yupeng",
                Pwd = "ABC123",
                Email = "电脑",
                Gender = 0,
                Authority = 3,
            };

           // var obj = new ProductDao().Save(product);
            var obj = this.productDao.Save(product);
            Assert.NotNull(obj);
        }
    }
}