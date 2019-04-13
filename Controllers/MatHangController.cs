using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop_ban_ca.Models;

namespace Shop_ban_ca.Controllers
{
    public class MatHangController : Controller
    {

        public ActionResult Index()
        {
            var dao = new MatHangDAO();
            var model = dao.ShowAllFish();

            //   return View();
            return View(model);
        }

        public ActionResult Index1()
        {
            var dao = new MatHangDAO();
            var model = dao.ShowAllFood();

            //   return View();
            return View(model);
        }

        public ActionResult Index2()
        {
            var dao = new MatHangDAO();
            var model = dao.ShowAllGear();

            //   return View();
            return View(model);
        }

        //~ dẫn tới root(thư mục gốc)
        //public ActionResult About()
        //{
        //    return View();
        //}

        public ActionResult Create()
        {
            return View();
            // return RedirectToAction("Index");
        }

        /*   public ActionResult Create()
           {
               List<Account>  lst=(List<Account>)Session["lst"];
               lst.Add

               //gọi model để thêm mới acc
               return RedirectToAction("Index");
           } */

        public ActionResult Edit(string id)
        {
            MAT_HANG lst = new MAT_HANG();
            lst.MAMATHANG = id;
            lst.TENMATHANG = "sanpham";
            lst.SOLUONG = 100;
            lst.DONGIA = 1000;
            lst.MANCC = "NCC";
            lst.MALOAI = "LOAI";
            return View(lst);
        }

        [HttpPost]
        public ActionResult Edit(MAT_HANG mh)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Delete(MAT_HANG mh)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}