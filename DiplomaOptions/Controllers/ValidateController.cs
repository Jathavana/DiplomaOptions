using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiplomaOptions.Controllers
{
    public class ValidateController : Controller
    {
        public JsonResult IsUserExists(string userId)
            {
                return IsExist(userId) ? Json(true, JsonRequestBehavior.AllowGet) : Json(false, JsonRequestBehavior.AllowGet);
            }

            public bool IsExist(string userId)
            {
                // Write code to validate UserId weather is Userid already exists or not and base on return true and false.  
                if (string.IsNullOrEmpty(userId)) return false;
                else if (userId == "LilJayJay") return false;
                else return true;
            }
    }
}