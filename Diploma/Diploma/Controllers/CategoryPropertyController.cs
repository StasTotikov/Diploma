using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diploma.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Diploma.Controllers
{
    public class CategoryPropertyController : Controller
    {
        ShopContext db;

        public CategoryPropertyController(ShopContext context)
        {
            db = context;
        }


        // GET: CategoryPropertyController
        public ActionResult Index()
        {
            var list = db.CategoryProperties.Include(t=>t.Category).Include(t=>t.Property).ToList();
            return View(list);
        }

        // GET: CategoryPropertyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryPropertyController/Create
        public ActionResult Create()
        {
            ViewBag.Categories = new SelectList(db.Categories, "Id", "Title");
            ViewBag.Properties = new SelectList(db.Properties, "Id", "Name");

            return View();
        }

        // POST: CategoryPropertyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryProperty categoryProperty)
        {
            try
            {
                CategoryProperty item = db.CategoryProperties.FirstOrDefault(t => t.CategoryId == categoryProperty.CategoryId && t.PropertyId == categoryProperty.PropertyId);
                if (item==null)
                {
                    db.CategoryProperties.Add(categoryProperty);
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: CategoryPropertyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryPropertyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryPropertyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryPropertyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
