﻿using System.Web;
using System.Web.Mvc;

namespace TP1_Mod5_Dojo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
