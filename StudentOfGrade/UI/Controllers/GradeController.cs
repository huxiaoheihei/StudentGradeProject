using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class GradeController : Controller
    {
        //
        // GET: /Grade/

        private MethodOfCenter dbCenter = new MethodOfCenter();
        public GradeController(MethodOfCenter dbcenter)
        {
            this.dbCenter = dbcenter;
        }

        public GradeController()
        { }
        //[HttpPost]
        public ActionResult Index(string itemName, string itemWeight, string item)
        {
            ModelToView center = new ModelToView();
            center.gradeItem.GradeItemName = itemName;
            center.gradeItem.Wight = itemWeight;
            center.gradeItem.PerOrTeam = item;

            dbCenter.Add(center.gradeItem);
            return View(center);
        }

    }
}
