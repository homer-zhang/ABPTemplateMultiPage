using System.Web.Mvc;

namespace X.Dev.Web.Controllers
{
    public class AboutController : DevControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}