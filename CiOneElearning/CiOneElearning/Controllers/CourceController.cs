using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CiOneElearning.Models;
using System.Net;

namespace CiOneElearning.Controllers
{
    
    public class CourceController : Controller
    {
        //
        // GET: /Cource/
        dataModel db = new dataModel();
       
        public ActionResult Index()
        {
            var listcource = db.KhoaHocs;
            return View(listcource);
        }
        public ActionResult DetailPartial()
        {
            var listcource = db.KhoaHocs.ToList();
            return PartialView(listcource);
        }
        //Thông tin khóa học
           
        public ActionResult DetailCource()
        {
            
            return View();
        }
       
        public ActionResult DetailCources(int ?id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            KhoaHoc kh = db.KhoaHocs.SingleOrDefault(n => n.ID_KhoaHoc == id );
            if (kh == null)
            {
                
                return HttpNotFound();
            }
            return View(kh);
        }
        public ActionResult VideoCource()
        {

            return View();
        }
      

	}
}