using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp.NetCoreTest.Models;
using Asp.NetCoreTest.Contexts;

namespace Asp.NetCoreTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using(var context = new XinContext())
            {
                return View(context.Users.ToList());
            }
        }
    }
}
