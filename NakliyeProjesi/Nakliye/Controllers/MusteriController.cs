using Nakliye.BLL;
using Nakliye.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nakliye.Controllers
{
    public class MusteriController : Controller
    {
        MusteriBLL musteribll = new MusteriBLL();
        // GET: Musteri
        public ActionResult KayıtOl(Müsteriler musteriler)
        {
            musteribll.AddCustomers(musteriler);
            return View(musteriler);
        }
    }
}