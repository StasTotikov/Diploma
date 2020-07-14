using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Diploma.Models;
using Microsoft.EntityFrameworkCore;

namespace Diploma.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin


        ShopContext db;
        public AdminController(ShopContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {

            return View();

        }
        public async Task<IActionResult> CategoryProperties()
        {
            return View(await db.CategoryProperties.ToListAsync());
        }

        public async Task<IActionResult> Categories()
        {
            List<Category> categories = await db.Categories.ToListAsync();
            return View(categories);
        }

        public IActionResult Properties()
        {

            return View(db.Properties.ToList());

        }

        //public IActionResult ()
        //{

        //    return View(db.Properties.ToList());

        //}




    }
}