namespace Reference.Framework.Web.Controllers
{
    using System.Web.Mvc;
    using Reference.Framework.Service;
    using Reference.Framework.Web.ViewModels;

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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new GearViewModel
            {
                GearId = 1,
                Name = "Hoka Bondi 4 #4",
                GearType = "Running Shoes",
                Manufacturer = "Hoka One One",
                Model = "Bondi 4",
                Size = "9",
                Description = "My current pair of Hoka One One Bondi 4's. This is my 4th pair of these shoes",
                DatePurchased = new System.DateTime(2017, 1, 10),
                CurrentMileage = 243,
                IsActive = true,
            };

            return View(model);
        }
    }
}