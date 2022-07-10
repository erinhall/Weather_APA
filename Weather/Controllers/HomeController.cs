using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weather.Models;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new WeatherModel());
        }

        [HttpPost]
        public ActionResult GetWeather(string city)
        {
            //initialize model and call getweatherlist to make api call using user inputted city from ui
            WeatherModel weather = new WeatherModel();
            weather.City = city;
            return Json(weather.GetWeatherList(), JsonRequestBehavior.AllowGet);
        }

    }
}