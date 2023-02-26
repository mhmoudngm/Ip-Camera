using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using DashBoardT.BLL.helper;

namespace DashBoardT.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult sendmail(String title,String message)
        {
           var msg= mailhelper.sendmail(title, message);
            TempData["sendmail"] = msg;
            return RedirectToAction("index");
        }

        public IActionResult mailsbox()
        {
            return View();
        }
    }
}
