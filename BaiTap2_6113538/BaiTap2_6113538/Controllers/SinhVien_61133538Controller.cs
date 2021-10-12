using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2_6113538.Models;

namespace BaiTap2_6113538.Controllers
{
    public class SinhVien_61133538Controller : Controller
    {
        // GET: SinhVien_61133538
        public ActionResult Detail()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Detail1(Infomation st)
        {
            ViewBag.Id = st.Id;
            ViewBag.Name = st.Name;
            ViewData[ "Marks" ] = st.Marks ;
            return View();
        }
    }
}