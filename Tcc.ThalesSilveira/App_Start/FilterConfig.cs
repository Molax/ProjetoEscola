﻿using System.Web;
using System.Web.Mvc;

namespace Tcc.ThalesSilveira
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
