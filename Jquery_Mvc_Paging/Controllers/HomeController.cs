using Jquery_Mvc_Paging.Helper;
using Jquery_Mvc_Paging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jquery_Mvc_Paging.Controllers
{
    public class HomeController : Controller
    {
        POSEntities context = new POSEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetPaggedData(int pageNumber = 1, int pageSize = 20)
        {
            List<Item> listData = context.Items.ToList();
            var pagedData = Pagination.PagedResult(listData, pageNumber, pageSize);
            return Json(pagedData, JsonRequestBehavior.AllowGet);
        }
    }
}