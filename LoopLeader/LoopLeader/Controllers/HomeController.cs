using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoopLeader.Domain.Entities;
using LoopLeader.Domain.Abstract;
using LoopLeader.Domain.Concrete;
using LoopLeader.Models;

namespace LoopLeader.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        public ActionResult Index()
        {
            ContentRepository repo = new ContentRepository();
            Content homeContent = (from hc in repo.Content
                                   where hc.ContentID == "Home"
                                   select hc).FirstOrDefault<Content>();
            return View(homeContent);
        }

        public ActionResult Info()
        {
            ContentRepository repo = new ContentRepository();
            Content infoContent = (from hc in repo.Content
                                   where hc.ContentID == "Information"
                                   select hc).FirstOrDefault<Content>();
            return View(infoContent);
        }

        public ActionResult About()
        {
            ContentRepository repo = new ContentRepository();
            Content aboutContent = (from hc in repo.Content
                                   where hc.ContentID == "About"
                                   select hc).FirstOrDefault<Content>();
            return View(aboutContent);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Contact(EmailResponse emailResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thankyou", emailResponse);//Thank you, we will respond asap.
            }
            else
            {
                // there is a validation error
                return View();
            }
        }

        public ViewResult Thankyou(EmailResponse emailResponse)
        {
            return View();
        }

        public ViewResult SiteMap()
        {
            return View();
        }

        public ActionResult Legal()
        {
            ContentRepository repo = new ContentRepository();
            Content legalContent = (from hc in repo.Content
                                    where hc.ContentID == "Legal"
                                    select hc).FirstOrDefault<Content>();
            return View(legalContent);
        }
    }
}