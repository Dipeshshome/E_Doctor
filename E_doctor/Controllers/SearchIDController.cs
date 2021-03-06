using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationUserMVC.Models;

namespace RegistrationUserMVC.Controllers
{
    public class SearchIDController : Controller
    {
        // GET: SearchID
        DBModels db = new DBModels();
        
        public ActionResult Index(string searching)
        {
            return View(db.Calenders.Where(x => x.PatientName.Contains(searching)));
        }
    }
}