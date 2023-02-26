using DashBoardT.BLL;
using DashBoardT.DAL.database;
using DashBoardT.DAL.entity;
using DashBoardT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;

namespace DashBoardT.Controllers
{
    public class HomeController : Controller
    {
        private Unitofwork uow;
        public HomeController(Unitofwork uow)
        {
            this.uow = uow;
        }
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(department dpt)
        {
            try {
                if(ModelState.IsValid)
                {
                    uow.Departmentmanager.add(dpt);
                    return RedirectToAction("Index", "Department");
                }
                else
                {
                    return View(dpt);
                }
               
            }
            catch(Exception e)
            {
                //EventLog log = new EventLog();
                //log.Source = "Dashboard";
                //log.WriteEntry(e.Message, EventLogEntryType.Error);
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return View(dpt);
               
            }
           
          
        }
        public IActionResult update(int id)
        {
           var dpt= uow.Departmentmanager.getbyid(id);
            return View(dpt);
        }
        [HttpPost]
        public IActionResult update(department dpt)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    uow.Departmentmanager.update(dpt);
                    return RedirectToAction("Index", "Department");
                }
                else
                {
                    return View(dpt);
                }

            }
            catch (Exception e)
            {
                //EventLog log = new EventLog();
                //log.Source = "Dashboard";
                //log.WriteEntry(e.Message, EventLogEntryType.Error);
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return View(dpt);

            }


        }
        public IActionResult delete(int did)
        {
            var dpt = uow.Departmentmanager.getbyid(did);
            uow.Departmentmanager.delete(dpt);
            return RedirectToAction("Index", "Department");
        }
        [HttpPost]
       public JsonResult display(String name)
        {
            var data = "Welcome " + name;
            return Json(data);
        }
    }
   
}
