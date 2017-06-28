using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainManagementMVC.Models;
namespace DomainManagementMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult NewClient()
        {
            return View();
        }

        public ActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClient(Tbl_Clients Client)
        {

            if (String.IsNullOrEmpty(Client.ContactPersonName))
            {

                ModelState.AddModelError("ContactPersonName", "Enter Contact Person Name");

            }

            

            if (ModelState.IsValid)
            {
                Tbl_Clients ObjClient = new Models.Tbl_Clients();
                ObjClient.ClientName = Client.ClientName;
                ObjClient.ContactPersonName = Client.ContactPersonName;
                ObjClient.MobileNumbar = Client.MobileNumbar;
                ObjClient.EmailId = Client.EmailId;
                ObjClient.Address = Client.Address;
                ObjClient.IsActive = Client.IsActive;
                ObjClient.CreatedBy = "Admin";
                ObjClient.CreatedDate = DateTime.Now;
                DomainDBEntities DB = new DomainDBEntities();
                DB.Tbl_Clients.Add(ObjClient);
                DB.SaveChanges();
                return RedirectToAction("Dashboard", "Admin");
            }
            return View(Client);
        }
        public ActionResult ListOfClients()
        {
            List<Tbl_Clients> Clients = new List<Tbl_Clients>();
            DomainDBEntities DB = new DomainDBEntities();
            Clients = DB.Tbl_Clients.ToList();
            return View(Clients);
        }

        public ActionResult Clients()
        {
            List<Tbl_Clients> Clients = new List<Tbl_Clients>();
            DomainDBEntities DB = new DomainDBEntities();
            Clients = DB.Tbl_Clients.ToList();
            return View(Clients);
        }
    }
}