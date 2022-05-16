using MVCCB.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<TelaViewModel> lst = null;
            using (Models.BD_TALLERDECONFECCION2Entities db = new Models.BD_TALLERDECONFECCION2Entities())
            {
                 lst =
                    (from d in db.tb_tela
                     select new TelaViewModel
                     {
                         Id = (int)d.tela_id,
                         Nombre = d.tela_nom
                     }).ToList();
            }
            List<SelectListItem> items = lst.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.Id.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}