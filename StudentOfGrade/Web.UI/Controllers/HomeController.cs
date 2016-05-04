using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.UI.Models;
using Model;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ModelToView mv = new ModelToView();
            mv.team.TeamName = "蛋炒饭";
            StudentOfGradeContext context = new StudentOfGradeContext();
            context.Teams.Add(mv.team);
            return View();
        }

    }
}
