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
        /// <summary>
        /// 数据对象
        /// </summary>
        private readonly XinContext _context;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="context"></param>
        public HomeController(XinContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
    }
}
