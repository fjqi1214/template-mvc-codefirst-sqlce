using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    using Business;
    using Business.Model;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ctx = new BusinessContext();
            ctx.Items.Add(new Item() { Id = 1, Name = "Item 1", AddDate = DateTime.Now, ModifyDate = DateTime.Now });
            ctx.SaveChanges();

            return this.View();
        }
    }
}
