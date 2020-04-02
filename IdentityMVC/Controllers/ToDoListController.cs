using IdentityMVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityMVC.Controllers
{
    public class ToDoListController : Controller
    {
        // GET: ToDoList
        ApplicationDbContext conn = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<ToDoList> listFilter = new List<ToDoList>();
            foreach (ToDoList item in conn.ToDoList.ToList())
            {
                if (item.UserId == System.Web.HttpContext.Current.User.Identity.GetUserId())
                {
                    listFilter.Add(item);
                }
            }
            return View(listFilter.ToList());
        }

        // GET: ToDoList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToDoList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoList/Create
        [HttpPost]
        public ActionResult Create(ToDoList item)
        {
            try
            {
                item.UserId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                conn.ToDoList.Add(item);
                conn.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDoList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ToDoList/Edit/5
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

        // GET: ToDoList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ToDoList/Delete/5
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
