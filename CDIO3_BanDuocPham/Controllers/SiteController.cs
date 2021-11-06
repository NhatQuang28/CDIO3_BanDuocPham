using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CDIO3_BanDuocPham.Models;

namespace CDIO3_BanDuocPham.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        DB_WEBBANDUOCPHAMEntitiess db = new DB_WEBBANDUOCPHAMEntitiess();
        public ActionResult Index()
        {
            var listSanPham1 = db.SANPHAMs.Where(n => n.IDLOAISP==1);
            ViewBag.listSP1 = listSanPham1;
            var listSanPham2 = db.SANPHAMs.Where(n => n.IDLOAISP == 1);
            ViewBag.listSP2 = listSanPham2;
            return View();
        }
        public ActionResult PartialProduct()
        {
            return PartialView();
        }
        public ActionResult PartialMenu()
        {
            var listLSP = db.LOAISANPHAMs;
            return PartialView(listLSP);
        }
        public ActionResult CreateAccount()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}