using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_ban_ca.Models
{
    public class MatHangDAO
    {
        ShopDBConnect db = null;
        
        public MatHangDAO()
        {
            db = new ShopDBConnect();
        }

        public List<MAT_HANG> ShowAllFish()
        {
            var result = (from c in db.MAT_HANG where c.MALOAI == "MA01" select c).ToList();
            return result;
        }

        public List<MAT_HANG> ShowAllFood()
        {
            var result = (from c in db.MAT_HANG where c.MALOAI == "MA02" select c).ToList();
            return result;
        }

        public List<MAT_HANG> ShowAllGear()
        {
            var result = (from c in db.MAT_HANG where c.MALOAI == "MA03" select c).ToList();
            return result;
        }
    }
}