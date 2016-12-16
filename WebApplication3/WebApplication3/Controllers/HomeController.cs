using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string job,string name,string motto)
        {

            List<Models.project> list = new List<Models.project>();
            var item = new Models.project();

            item.job = "組長";
            item.name = "李益銘";
            item.motto = "The Best Of The Men At Work";

            list.Add(item);

            var item2 = new Models.project();

            item2.job = "組員";
            item2.name = "方光明";
            item2.motto = "Black Light Syndrome";
            list.Add(item2);
            ViewBag.ListDatas = list;

            var item3 = new Models.project();

            item3.job = "組員";
            item3.name = "張維哲";
            item3.motto = "Everything ought to be beautiful in a human being: face, dress, soul and idea";
            list.Add(item3);
            ViewBag.ListDatas = list;

            var item4 = new Models.project();

            item4.job = "組員";
            item4.name = "柯軒安";
            item4.motto = "When an opportunity is neglected,it never comes back to you";
            list.Add(item4);
            ViewBag.ListDatas = list;

            var item5 = new Models.project();

            item5.job = "組員";
            item5.name = "王偉鈞";
            item5.motto = "Have but few friends, though many acquaintances";
            list.Add(item5);
            ViewBag.ListDatas = list;

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