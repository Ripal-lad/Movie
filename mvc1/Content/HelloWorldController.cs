using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc1.Content
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
       /* public String Index()
        {
            return "This is my <b>Default</b> Action";
        }
        */

       /* public ActionResult Index()
        {
            return View();
        }*/
        //Get hello world welcome

      /*  public String welcome(String name,int Id=1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + " , Id : " + Id);
        }*/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

	}
}