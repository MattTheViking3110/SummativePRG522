﻿using System.Web;
using System.Web.Mvc;

namespace SummativePRG522
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
