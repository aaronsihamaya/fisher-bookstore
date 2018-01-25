using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
        
        public class AboutController : Controller
        {

            public IActionResult Index()
            {
                return Content("hello world, this is the about page");
            }
            public IActionResult History()
            {
                return Content("hello world, this is the about history page");  
            }
            public IActionResult Location()
            {
                return Content("hello world, this is the about location page");  
            }


        }
}