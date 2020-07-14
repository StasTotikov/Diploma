using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diploma.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Diploma.Controllers
{
    public class CategoriesController : Controller
    {

        ShopContext db;
        public CategoriesController(ShopContext context)
        {
            db = context;
        }

        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            var list = new[] { new Category { Id = 0, Title = "Нет",  } }.Union(db.Categories).ToList();
            ViewBag.Parents = new SelectList(list, "Id", "Title");
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    if (category.ParentId == 0)
                        category.ParentId = null;

                    Category parentCategory = db.Categories.FirstOrDefault(p => p.Id == category.ParentId);
                 
                        db.Categories.Add(category);

                        db.SaveChanges();
                        return RedirectToAction(nameof(Index));
                  
                }
                else return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int ?id)
        {
            if (id != null)
            {
                var list = new[] { new Category { Id = 0, Title = "Нет", } }.Union(db.Categories).ToList();
                
                Category category = db.Categories.FirstOrDefault(p => p.Id == id);
                ViewBag.Parents = new SelectList(list, "Id", "Title", category.ParentId);
                if (category!=null)
                {
                    return View(category);

                }
            }
            return NotFound();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                db.Categories.Update(category);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int ?id)
        {
            if (id != null)
            {
                Category category = db.Categories.FirstOrDefault(p => p.Id == id);
                if (category != null)
                {
                    return View(category);

                }
            }
            return NotFound();
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                db.Categories.Remove(category);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
