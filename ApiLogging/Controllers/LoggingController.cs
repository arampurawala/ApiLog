using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiLogging.Controllers
{
    public class LoggingController : BaseController
    {
       
        // GET: Logging
        public ActionResult Index()
        {
            return View();
        }
        //GET: Logging
        public ActionResult Log()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Log(string Url, string IpAddress, DateTime Date)
        {
            var logItem = new dtLog();
            logItem.Date = Date;
            logItem.IpAddress = IpAddress;
            logItem.Url = Url;

            unitOfWork.LogRepository.Insert(logItem);
            unitOfWork.Save();
            ViewBag.Message = "Logged Successfully";

            return View();
        }

    }
}