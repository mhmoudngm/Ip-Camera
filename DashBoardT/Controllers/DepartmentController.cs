using DashBoardT.BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.Controllers
{
    public class DepartmentController : Controller
    {
        private Unitofwork uow;
        public DepartmentController(Unitofwork uow)
        {
            this.uow = uow;
        }
        public IActionResult Index()
        {
            var data=uow.Departmentmanager.getall();
            ViewBag.data = data;
            return View();
        }
    }
}
