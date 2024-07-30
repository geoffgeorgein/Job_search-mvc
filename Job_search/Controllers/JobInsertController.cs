using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Job_search.Models;


namespace Job_search.Controllers
{
    public class JobInsertController : Controller
    {
        // GET: JobInsert
        MVC_PROJECTEntities dbobj = new MVC_PROJECTEntities();
        public ActionResult Insert_PageLoad()
        {
            //Job job=new Job();
            Console.WriteLine("Skills");
            return View();
        }

        public ActionResult Insert_Click(Job clsobj)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(clsobj.Skills);
                dbobj.sp_JInsert(clsobj.Company_id, clsobj.Skills, clsobj.Experience, "Available", clsobj.Last_date);
                return View("Insert_PageLoad", clsobj);


            }
            //else
            //{
            //    Console.WriteLine(clsobj.Company_id);
            //    Console.WriteLine(clsobj.Skills);
            //}

            return View("Insert_PageLoad", clsobj);
        }
    }
}