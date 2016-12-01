using AAMCO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AAMCO.Controllers
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






        public JsonResult GetJson()
        {
            return Json(new { variable = "value" }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll()
        {
            return Json(GetStubData(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddOne(string jsonString)
        {
            var js = new JavaScriptSerializer();
            StubDataModel data = js.Deserialize<StubDataModel>(jsonString);
            var successReturnValue = new { success = "ok" };
            return Json(successReturnValue, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddData(string jsonString) {
            
            var js = new JavaScriptSerializer();
            StubDataModel[] data = js.Deserialize<StubDataModel[]>(jsonString);
            var successReturnValue = new { success = "ok" , count = data.ToList<StubDataModel>().Count };

            return Json(successReturnValue, JsonRequestBehavior.AllowGet);  
        }









        private List<StubDataModel> GetStubData()
        {
            var usersList = new List<StubDataModel>
            {
                new StubDataModel
                {
                    UserId = 1,
                    UserName = "Rami",
                    Company = "Global Solutions"
                },
                new StubDataModel
                {
                    UserId = 1,
                    UserName = "Levi",
                    Company = "Global Solutions"
                },
                new StubDataModel
                {
                    UserId = 1,
                    UserName = "Abc",
                    Company = "Abc Solutions"
                }
            };

            return usersList;
        }

    }
}