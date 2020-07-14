using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diploma.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Diploma.Controllers
{
    public class ManufacturersController : Controller
    {
        ShopContext db;
        public ManufacturersController(ShopContext context)
        {
            db = context;
        }

        // GET: ManufacturersController
        public ActionResult Index()
        {
            return View(db.Manufacturers.ToList());
        }

        // GET: ManufacturersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManufacturersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManufacturersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Manufacturer manufacturer)
        {
            try
            {
                db.Manufacturers.Add(manufacturer);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManufacturersController/Edit/5
        public ActionResult Edit(int ?id)
        {
            if (id != null)
            {
                Manufacturer manufacturer =  db.Manufacturers.FirstOrDefault(p => p.Id == id);
                if (manufacturer != null)
                {
                    return View(manufacturer);
                }
            }
            return NotFound();
        }

        // POST: ManufacturersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Manufacturer manufacturer)
        {
            try
            {
                db.Manufacturers.Update(manufacturer);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManufacturersController/Delete/5
        public async  Task<ActionResult> Delete(int ?id)
        {
            if (id != null)
            {
                Manufacturer manufacturer = await db.Manufacturers.FirstOrDefaultAsync(p => p.Id == id);
                if (manufacturer != null)
                {
                    return View(manufacturer);
                }
            }
            return NotFound();
        }

        // POST: ManufacturersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Delete(int id, Manufacturer manufacturer)
        {
            try
            {
                db.Manufacturers.Remove(manufacturer);
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
