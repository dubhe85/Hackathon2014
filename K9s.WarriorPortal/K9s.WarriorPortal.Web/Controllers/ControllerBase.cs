using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace K9s.WarriorPortal.Web.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected JsonResult JsonAllowGet(object data)
        {
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        protected JsonResult JsonAllowGet(object data, string contentType)
        {
            return Json(data, contentType, JsonRequestBehavior.AllowGet);
        }

        protected JsonResult JsonAllowGet(object data, string contentType, Encoding contentEncoding)
        {
            return Json(data, contentType, contentEncoding, JsonRequestBehavior.AllowGet);
        }
    }
}