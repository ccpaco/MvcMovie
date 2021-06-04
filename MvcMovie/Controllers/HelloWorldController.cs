using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
   
    public class HelloWorldController : Controller
    // Every public method in a controller is callable as an HTTP endpoint
    {
        // Viewable at localhost:xxxx/HellowWorld
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action and message degozaru (Samurai-era Japanese dialect)";
        }

        // Viewable at localhost:xxxx/HellowWorld/Welcome
        // GET: /HelloWorld/Welcome
        public string Welcome(string name, int numTimes = 1)
        {
            /*return "This is the Welcome action method degozaru (Samurai-era Japanese dialect)"*/
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
  
            // works at url https://localhost:44337/HelloWorld/Welcome?name=Rick&numtimes=5 where port 44337
            // is unique. ? is separator, & separates field-value pairs
        }
    }
}
