using IdentityMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityMVC.Controllers
{
    [AuthorizeRedirect(Roles = "Admin")]
    public class SupplierController : Controller
    {
        IdentityMVCEntities conn = new IdentityMVCEntities();
        // GET: Supplier
        public ActionResult Index()
        {
            return View(conn.TB_M_Supplier.ToList());
        }

        // GET: Supplier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            return RedirectToAction("Register","Account");
            //return View();
        }

        /*
        // POST: Supplier/Create
        [HttpPost]
        public ActionResult Create(TB_M_Supplier supp)
        {
            try
            {
                conn.TB_M_Supplier.Add(supp);
                conn.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/

        // GET: Supplier/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Supplier/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
