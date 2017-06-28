using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DomainManagementMVC.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewDomain()
        {
            return View();
        }

        public ActionResult Domains()
        {
            return View();
        }

        public ActionResult NewHosting()
        {
            return View();
        }

        public ActionResult Hostings()
        {
            return View();
        }

        public ActionResult NewEmail()
        {
            return View();
        }

        public ActionResult Emails()
        {
            return View();
        }

        public ActionResult NewFtp()
        {
            return View();
        }
        public ActionResult Ftps()
        {
            return View();
        }
        public ActionResult NewCpanel()
        {
            return View();
        }

        public ActionResult Cpanels()
        {
            return View();
        }
    }
}