using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    //Controller
    public class MoviesController : Controller
    {
        //action
        public string List()
        {
            return "Film Listesi";
        }
        public string Details()
        {
            return "Film Detayı";
        }
    }
}
