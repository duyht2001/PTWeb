﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap1_61133538.Controllers
{
    public class PhepToan_61133538Controller : Controller
    {
        // GET: PhepToan_61133538
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UseRequest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseRequest(string pt)
        {
            double a = double.Parse(Request["a"]);//Chuyển đổi chuỗi sang số thực
            double b = double.Parse(Request["b"]);
            pt = Request["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }
    }
}