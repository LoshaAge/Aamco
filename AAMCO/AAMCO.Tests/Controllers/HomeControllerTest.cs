using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AAMCO;
using AAMCO.Controllers;
using System.Web.Script.Serialization;
using AAMCO.Models;

namespace AAMCO.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {


        [TestMethod]
        public void GetJson()
        {
            HomeController controller = new HomeController();
            JsonResult result = controller.GetJson();
            string str = Convert.ToString(result.Data);
            Assert.AreEqual("{ variable = value }", str);
        }


        [TestMethod]
        public void GetAll()
        {
            HomeController controller = new HomeController();
            JsonResult result = controller.GetAll();
            string json = new JavaScriptSerializer().Serialize(result.Data);
            Assert.AreEqual("[{\"UserId\":1,\"UserName\":\"Rami\",\"Company\":\"Global Solutions\"},{\"UserId\":1,\"UserName\":\"Levi\",\"Company\":\"Global Solutions\"},{\"UserId\":1,\"UserName\":\"Abc\",\"Company\":\"Abc Solutions\"}]", json);
        }



        [TestMethod]
        public void AddOne()
        {
            var str = "{\"UserId\":1,\"UserName\":\"Rami\",\"Company\":\"Global Solutions\"}";
            HomeController controller = new HomeController();
            JsonResult result = controller.AddOne(str);
            string json = new JavaScriptSerializer().Serialize(result.Data);
            Assert.AreEqual("{\"success\":\"ok\"}", json);
        }



        [TestMethod]
        public void AddData()
        {
            var str = "[{\"UserId\":3,\"UserName\":\"User- 3\",\"Company\":\"Company- 3\"},{\"UserId\":3,\"UserName\":\"User- 3\",\"Company\":\"Company- 3\"},{\"UserId\":3,\"UserName\":\"User- 3\",\"Company\":\"Company- 3\"}]";
            HomeController controller = new HomeController();
            JsonResult result = controller.AddData(str);
            string json = new JavaScriptSerializer().Serialize(result.Data);
            Assert.AreEqual("{\"success\":\"ok\",\"count\":3}", json);
        }




        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
