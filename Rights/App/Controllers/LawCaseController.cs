using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Langben.App.Models;

namespace Langben.App.Controllers
{
    public class LawCaseController : Controller
    {
        private BusinessDBContext db = new BusinessDBContext();

        // GET: /LawCase/
        public ActionResult Index()
        {
            return View(db.Cases.ToList());
        }

        // GET: /LawCase/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LawCase lawcase = db.Cases.Find(id);
            if (lawcase == null)
            {
                return HttpNotFound();
            }
            return View(lawcase);
        }

        // GET: /LawCase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /LawCase/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name,CaseNumber,CaseInfo,ExistingAppraisal,HappenedTime,Remark,CreateUserName,CreateDate,ModifyUserName,ModifyDate")] LawCase lawcase)
        {
            if (ModelState.IsValid)
            {
                db.Cases.Add(lawcase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lawcase);
        }

        // GET: /LawCase/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LawCase lawcase = db.Cases.Find(id);
            if (lawcase == null)
            {
                return HttpNotFound();
            }
            return View(lawcase);
        }

        // POST: /LawCase/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name,CaseNumber,CaseInfo,ExistingAppraisal,HappenedTime,Remark,CreateUserName,CreateDate,ModifyUserName,ModifyDate")] LawCase lawcase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lawcase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lawcase);
        }

        // GET: /LawCase/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LawCase lawcase = db.Cases.Find(id);
            if (lawcase == null)
            {
                return HttpNotFound();
            }
            return View(lawcase);
        }

        // POST: /LawCase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LawCase lawcase = db.Cases.Find(id);
            db.Cases.Remove(lawcase);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
