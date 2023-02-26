using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.Areas.Basicinfo.Controllers
{
    [Area("Basicinfo")]
    public class InventorydefinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
