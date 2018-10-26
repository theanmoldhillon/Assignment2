using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models.ActionFilter
{
    public class IsCrawler
    {
        bool isCrawler = HttpContext.Current.Request.Browser.Crawler;
    }
}