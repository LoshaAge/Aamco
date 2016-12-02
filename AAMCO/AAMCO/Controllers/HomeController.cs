using AAMCO.DAL;
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

      

        private AAMCOContext db = new AAMCOContext();

        [HttpPost]
        public JsonResult AddEvent(string jsonString)
        {
            var js = new JavaScriptSerializer();
            Event data = js.Deserialize<Event>(jsonString);

            var newData = db.Events.Add(data);
            db.SaveChanges();

            var successReturnValue = new { success = "ok" };
            return Json(successReturnValue, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetJson()
        {
            return Json(new { variable = "value" }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAll()
        {
            return Json(db.StubData.ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddOne(string jsonString)
        {
            var js = new JavaScriptSerializer();
            StubDataModel data = js.Deserialize<StubDataModel>(jsonString);

            var newData = db.StubData.Add(data);
            db.SaveChanges();

            var successReturnValue = new { success = "ok" };
            return Json(successReturnValue, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddData(string jsonString) {
            
            var js = new JavaScriptSerializer();
            StubDataModel[] data = js.Deserialize<StubDataModel[]>(jsonString);
            var dataList = data.ToList<StubDataModel>();
            foreach (var d in dataList)
            {
                db.StubData.Add(d);
            }
            db.SaveChanges();
            var successReturnValue = new { success = "ok" , count = dataList.Count };
            return Json(successReturnValue, JsonRequestBehavior.AllowGet);  
        }









      

    }
}