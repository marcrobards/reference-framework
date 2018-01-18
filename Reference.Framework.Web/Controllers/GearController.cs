namespace Reference.Framework.Web.Controllers
{
    using System.Web.Mvc;
    using Reference.Framework.Service;

    public class GearController : Controller
    {
        private readonly IGearService gearService;

        public GearController(IGearService gearService)
        {
            this.gearService = gearService;
        }

        public ActionResult Index()
        {
            var gearTypes = this.gearService.GetGearTypes();
            return View();
        }
    }
}