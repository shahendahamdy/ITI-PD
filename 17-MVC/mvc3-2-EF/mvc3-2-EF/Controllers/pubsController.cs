using mvc3_2_EF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc3_2_EF.Controllers
{
    public class pubsController : Controller
    {
        pubsEntities1 ctx=new pubsEntities1(); //context
        
        // GET: pubs
        public ActionResult Index(string pub_id = null )
        {
            ViewBag.publisherNames = ctx.publishers.ToList();
            var titls = ctx.titles.ToList();

            if (pub_id != null)
            {
                titls= ctx.titles.Where(p => p.pub_id == pub_id).ToList();
            }
            else {
                titls = ctx.titles.ToList();
            }
            return View(titls);
        }
        
        // GET: pubs/Details/5
        public ActionResult Details(string id)
        {
            title selectedTitle = ctx.titles.Find(id);
            //title selectedTitle = ctx.titles.FirstOrDefault();
            Debug.WriteLine(selectedTitle.title_id,id);
            return View(selectedTitle);
        }

        // GET: pubs/Create
        public ActionResult Create()
        {
            ViewBag.publisherNames = ctx.publishers.ToList();
            return View();
        }

        // POST: pubs/Create
        [HttpPost]
        public ActionResult Create(title t)
        {
            try
            {
                // TODO: Add insert logic here
                //title newTitle = new title();
                //newTitle.title1 = collection["title1"];
                //newTitle.pub_id = collection["pub_id"];
                //newTitle.price = decimal.Parse( collection["price"]);
                //newTitle.notes = collection["notes"];
                ctx.titles.Add(t);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: pubs/Edit/5
        public ActionResult Edit(string id)
        {
            title findtitle = ctx.titles.Find(id);
            ViewBag.publisherNames = ctx.publishers.ToList();

            return View(findtitle);
        }

        // POST: pubs/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                title updatedTitle = ctx.titles.Find(id);
                updatedTitle.title1 = collection["title1"];
                updatedTitle.pub_id = collection["pub_id"];
                ctx.SaveChanges();
                //collection[0] =    //pubdate

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: pubs/Delete/5
        public ActionResult Delete(string id)
        {
            title deleTitle = ctx.titles.Find(id);
            ViewBag.publisherNames = ctx.publishers.ToList();

            return View(deleTitle);
        }

        // POST: pubs/Delete/5
        [HttpPost]
        public  ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                title deldTitle = ctx.titles.Find(id);
                ctx.titles.Remove(deldTitle);
                ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
