using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop_ban_ca.Areas.Admin.Models;
namespace Shop_ban_ca.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            List<Admin> List = new List<Admin>();
            for (int i = 0; i < 5; i++)
            {
                Admin lst = new Admin();
                lst.mancc = "mancc" + i;
                lst.tenncc = "ncc" + i;
                lst.sdt = "unknown";
                lst.diachi = "unknown";
                List.Add(lst);

            }

            //   return View();
            return View(List);
        }

        //~ dẫn tới root(thư mục gốc)
        public ActionResult About()
        {

            return View();
        }

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
            Admin lst = new Admin();
            lst.mancc = id;
            lst.tenncc = "ncc";
            lst.sdt = "unknown";
            lst.diachi = "unknown";
            return View(lst);
        }
        [HttpPost]
        public ActionResult Edit(Admin ad)
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