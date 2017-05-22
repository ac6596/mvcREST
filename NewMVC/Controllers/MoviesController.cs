using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewMVC.Models;

namespace NewMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Shutter Island!"};
            return View(movie);
        }
    }
}