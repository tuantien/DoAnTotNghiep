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
    public class ManagerCourcesController : Controller
    {
        private dataModel db = new dataModel();
     
        // GET: /ManagerCources/
        public ActionResult Index()
        {
            var khoahocs = db.KhoaHocs.Include(k => k.TacGia);
            return View(khoahocs.ToList());
        }

        // GET: /ManagerCources/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaHoc khoahoc = db.KhoaHocs.Find(id);
            if (khoahoc == null)
            {
                return HttpNotFound();
            }
            return View(khoahoc);
        }

        // GET: /ManagerCources/Create
        public ActionResult Create()
        {
            ViewBag.ID_TacGia = new SelectList(db.TacGias, "ID_TacGia", "TenTacGia");
            return View();
        }

        // POST: /ManagerCources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include="ID_KhoaHoc,TenKhoaHoc,ThoiLuong,MoTaNgan,GioiThieu,NgayMoKH,ID_TacGia,Hello")] KhoaHoc khoahoc)
        {
            if (ModelState.IsValid)
            {
                db.KhoaHocs.Add(khoahoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_TacGia = new SelectList(db.TacGias, "ID_TacGia", "TenTacGia", khoahoc.ID_TacGia);
            return View(khoahoc);
        }

        // GET: /ManagerCources/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaHoc khoahoc = db.KhoaHocs.Find(id);
            if (khoahoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_TacGia = new SelectList(db.TacGias, "ID_TacGia", "TenTacGia", khoahoc.ID_TacGia);
            return View(khoahoc);
        }

        // POST: /ManagerCources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include="ID_KhoaHoc,TenKhoaHoc,ThoiLuong,MoTaNgan,GioiThieu,NgayMoKH,ID_TacGia,Hello")] KhoaHoc khoahoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoahoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_TacGia = new SelectList(db.TacGias, "ID_TacGia", "TenTacGia", khoahoc.ID_TacGia);
            return View(khoahoc);
        }

        // GET: /ManagerCources/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaHoc khoahoc = db.KhoaHocs.Find(id);
            if (khoahoc == null)
            {
                return HttpNotFound();
            }
            return View(khoahoc);
        }

        // POST: /ManagerCources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KhoaHoc khoahoc = db.KhoaHocs.Find(id);
            db.KhoaHocs.Remove(khoahoc);
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
