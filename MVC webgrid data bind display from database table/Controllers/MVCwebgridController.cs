using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_webgrid_data_bind_display_from_database_table.Controllers
{
    public class MVCwebgridController : Controller
    {
        // GET: MVCwebgrid
        public ActionResult Index()
        {
            MyDatabaseEntities sd=new MyDatabaseEntities();

            return View(sd.MyTables.ToList());
        }
    }
}