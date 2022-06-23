using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//04-3-8 using _03Model.Models
using _03Model.Models;


namespace _03Model.Controllers
{
    public class DefaultController : Controller
    {

        dbSutdentEntities1 db = new dbSutdentEntities1();


        public ActionResult Index()
        {
            var tStudent = db.tStudent.ToList();

            return View(tStudent);
        }

        public ActionResult Create()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult Create(tStudent s)
        {
            db.tStudent.Add(s);//資料先到model
            db.SaveChanges();//model再到db


            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            //delete from tStudent where fStuId = 888888

            //var student = from s in db.tStudent
            //              where s.fStuId == id
            //              select s;
            //var student = db.tStudent.Where(s => s.fStuId == id).FirstOrDefault();
            var student = db.tStudent.First(s=>s.fStuId==id);//linq語法
            db.tStudent.Remove(student);//模型改變
            db.SaveChanges();//真正寫入db

            return RedirectToAction("index");


        }
    }
}