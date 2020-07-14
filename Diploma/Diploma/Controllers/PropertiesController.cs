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
    public class PropertiesController : Controller
    {
        ShopContext db;


        public PropertiesController(ShopContext context)
        {
            db = context;
        }

        // GET: PropertiesController
        public ActionResult Index()
        {
            return View(db.Properties.ToList());

        }

        // GET: PropertiesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropertiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Property property)
        {
            try
            {
                db.Properties.Add(property);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertiesController/Edit/5
        public async Task<ActionResult> Edit(int ?id)
        {
            if (id != null)
            {
                Property property = await db.Properties.FirstOrDefaultAsync(p=>p.Id==id);
                if (property != null)
                {
                    return View(property);
                }
            }
            return NotFound();
        }

        // POST: PropertiesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Edit(int id, Property property)
        {
            try
            {
                db.Properties.Update(property);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertiesController/Delete/5
        public async  Task<ActionResult> Delete(int ?id)
        {
            if (id != null)
            {
                Property property = await db.Properties.FirstOrDefaultAsync(p => p.Id == id);
                if (property != null)
                {
                    return View(property);
                }
            }
            return NotFound();
        }

        // POST: PropertiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Delete(int id, Property property)
        {
            try
            {
                db.Properties.Remove(property);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
