using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibonacciSequenceMVC2.Controllers
{
    public class FibSeqController : Controller
    {
        // GET: FibSeq
        public ActionResult Index()
        {
            int[] fib = new int[20];
            fib[0] = 1;
            fib[1] = 1;
            for (int counter = 2; counter <= 19; counter++)
            {
                fib[counter] = fib[counter - 2] + fib[counter - 1];
            }
            ViewBag.fib = fib;
            return View();
        }
    }
}