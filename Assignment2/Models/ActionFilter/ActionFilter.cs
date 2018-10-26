using Assignment2.Models.ActionFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Models.ActionFilter
{
    public class ActionFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var isCrawler = new IsCrawler();
            //base.OnActionExecuting(filterContext);
        }


    }
}