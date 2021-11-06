using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CDIO3_BanDuocPham.Models;

namespace CDIO3_BanDuocPham.Controllers
{
    public class ProductController : Controller
    {
        DB_WEBBANDUOCPHAMEntitiess db = new DB_WEBBANDUOCPHAMEntitiess();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult detailproduct(int? MaSP)
        {
            SANPHAM sp = db.SANPHAMs.SingleOrDefault(n => n.IDSP == MaSP);
            return View(sp);
        }
        public ActionResult Product(int? MaLoaiSP)
        {
            var listSP = db.SANPHAMs.Where(n => n.IDLOAISP == MaLoaiSP);
            return View(listSP);
        }
    }
}