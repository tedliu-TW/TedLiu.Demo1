using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TedLiu.Demo1.Models;
using TedLiu.Demo1.Models.Service;

namespace TedLiu.Demo1.Controllers
{
    public class AddressController : Controller
    {
        AddressService service = new AddressService();
        // GET: Address
        public ActionResult Index()
        {
            var data = service.Getall();
            return View(data);
        }

        // GET: Address/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        public ActionResult Create(AddressBook model)
        {
            try
            {
                // TODO: Add insert logic here
                service.Create(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            var data = service.Getid(id);
            return View(data);
        }

        // POST: Address/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection,AddressBook model)
        {
            try
            {
                // TODO: Add update logic here
                service.Update(id,model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            var data = service.Getid(id);
            return View(data);
        }

        // POST: Address/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                service.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
