using AutoMapper;
using DashBoardT.BLL;
using DashBoardT.DAL.entity;
using DashBoardT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using DashBoardT.BLL.helper;

namespace DashBoardT.Controllers
{
    public class EmployeeController : Controller
    {
       
        private Unitofwork uow;
        private readonly IMapper mapper;

        public EmployeeController(Unitofwork uow,IMapper _mapper)
        {
            this.uow = uow;
            mapper = _mapper;
        }
        public IActionResult Index()
        {
            var data = uow.Employeemanager.getall().Select(a=>new Employeevm{ id = a.id, name = a.name, address = a.address, hiredate = a.hiredate, salary = a.salary, notes = a.notes, departmentid = a.department.departmentname,photoname=a.photoname,cvname=a.cvname });
            ViewBag.Employeedata = data;
            return View();
        }

        public IActionResult create()
        {
            var data = uow.Departmentmanager.getall();
            ViewBag.departmentlist = new SelectList(data,"id", "departmentname");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employeevm emp)
        {
            var data = mapper.Map<employee>(emp);
            try
            {
                if (ModelState.IsValid)
                {
                  String photoname=  uploadfilehelper.savefile(emp.photourl, "photos");
                  String cvname = uploadfilehelper.savefile(emp.cvurl, "docs");
                    data.cvname = cvname;
                    data.photoname = photoname;
                    uow.Employeemanager.add(data);
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    return View(data);
                }

            }
            catch (Exception e)
            {
                //EventLog log = new EventLog();
                //log.Source = "Dashboard";
                //log.WriteEntry(e.Message, EventLogEntryType.Error);
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return View(data);

            }


        }
        public IActionResult update(int id)
        {
            var dpt = uow.Employeemanager.getbyid(id);
            return View(dpt);
        }
        [HttpPost]
        public IActionResult update(Employeevm emp)
        {

            var data = mapper.Map<employee>(emp);
            try
            {
                if (ModelState.IsValid)
                {
                    uow.Employeemanager.update(data);
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    return View(data);
                }

            }
            catch (Exception e)
            {
                //EventLog log = new EventLog();
                //log.Source = "Dashboard";
                //log.WriteEntry(e.Message, EventLogEntryType.Error);
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return View(data);

            }


        }
        public IActionResult delete(int did)
        {
            var emp = uow.Employeemanager.getbyid(did);
            uow.Employeemanager.delete(emp);
            uploadfilehelper.remove("photos/",emp.photoname);
            uploadfilehelper.remove("docs/", emp.cvname);
            return RedirectToAction("Index", "Employee");
        }

        public IActionResult details(int did)
        {
            var data = uow.Employeemanager.getbyid(did);
            var mappeddata = mapper.Map<Employeevm>(data);
            return View(mappeddata);
        }
    }

}
