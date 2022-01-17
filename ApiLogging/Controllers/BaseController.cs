using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiLogging.Controllers
{
    public class BaseController : Controller
    {
        public LogDBEntities db = new LogDBEntities();
        // GET: Base
        public readonly UnitOfWork unitOfWork = new UnitOfWork();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}