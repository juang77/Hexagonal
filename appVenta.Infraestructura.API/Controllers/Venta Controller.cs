using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appVenta.Infraestructura.API.Controllers
{
    public class Venta_Controller : Controller
    {
        // GET: Venta_Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Venta_Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Venta_Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Venta_Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Venta_Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Venta_Controller/Edit/5
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

        // GET: Venta_Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Venta_Controller/Delete/5
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
