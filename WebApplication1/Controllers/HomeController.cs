using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers {
    public class HomeController : Controller {
        public string Index() {
            return "Hello from HomeController - action method Index!";
        }

        public string About() {
            return "Hello from HomeController - action method About!";
        }
    }
}
