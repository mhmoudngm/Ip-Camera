using DashBoardT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult registration(Registrationvm model)
        {
            if(ModelState.IsValid)
            {

            }

            return View(model);
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult forgetpassword()
        {
            return View();
        }
        public IActionResult confirmforgetpassword()
        {
            return View();
        }
        public IActionResult resetpassword()
        {
            return View();
        }
        public IActionResult confirmresetpassword()
        {
            return View();
        }
    }
}
