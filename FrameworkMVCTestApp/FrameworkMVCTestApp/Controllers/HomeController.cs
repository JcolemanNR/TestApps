using NewRelic.Api.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace FrameworkMVCTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DoThing1();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            DoThing2();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            DoThing3();
            return View();
        }

        [Trace]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void DoThing1()
        {
            Thread.Sleep(1000);
        }

        [Trace]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void DoThing2()
        {
            Thread.Sleep(1000);
        }

        [Trace]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void DoThing3()
        {
            Thread.Sleep(1000);
        }

    }
}