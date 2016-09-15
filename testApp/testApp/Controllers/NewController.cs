using System.Web.Mvc;

namespace testApp.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View("test");
        }

        //add sstring
        public string getString()
        {
            return "this is a string";
        }
    }
}