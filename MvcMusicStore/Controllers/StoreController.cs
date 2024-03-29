﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        //
        // GET: /Store/Browse
        public string Browse(string genre)
        {
            return HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
        }
        //
        // GET: /Store/Details
        public string Details(int id)
        {
            return "Store.Details, ID = " + id;
        }
    }
}
