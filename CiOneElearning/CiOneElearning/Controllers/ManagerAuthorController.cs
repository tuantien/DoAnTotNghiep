using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CiOneElearning.Models;

namespace CiOneElearning.Controllers
{
    public class ManagerAuthorController : Controller
    {
        private dataModel db = new dataModel();

        // GET: /ManagerAuthor/
        public ActionResult Index()
        {
            return View(db.TacGias.ToList());
        }

        // GET: /ManagerAuthor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TacGia tacgia = db.TacGias.Find(id);
            if (tacgia == null)
            {
                return HttpNotFound();
            }
            return View(tacgia);
        }

        // GET: /ManagerAuthor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ManagerAuthor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include="ID_TacGia,TenTacGia,ChucVi,GioiThieuTG,AnhTG")] TacGia tacgia)
        {
            if (ModelState.IsValid)
            {
                db.TacGias.Add(tacgia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tacgia);
        }

        // GET: /ManagerAuthor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TacGia tacgia = db.TacGias.Find(id);
            if (tacgia == null)
            {
                return HttpNotFound();
            }
            return View(tacgia);
        }

        // POST: /ManagerAuthor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include="ID_TacGia,TenTacGia,ChucVi,GioiThieuTG,AnhTG")] TacGia tacgia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tacgia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tacgia);
        }

        // GET: /ManagerAuthor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TacGia tacgia = db.TacGias.Find(id);
            if (tacgia == null)
            {
                return HttpNotFound();
            }
            return View(tacgia);
        }

        // POST: /ManagerAuthor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TacGia tacgia = db.TacGias.Find(id);
            db.TacGias.Remove(tacgia);
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
