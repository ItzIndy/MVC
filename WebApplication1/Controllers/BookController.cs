using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVC.Controllers {
    public class BookController : Controller{
        public string Index() {
            return "Hello from the BookController - action method Index";
        }

        public IActionResult Edit(int id) {
            ViewData["BoekId"] = id;
            return View();
        }
    }
}
