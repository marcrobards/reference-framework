namespace Reference.Framework.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Reference.Framework.Model;
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
                Manufacturer = "Hoka One One",
                GearModel = "Bondi 4",
                GearTypeId = 2,
                Size = "9",
                Description = "My current pair of Hoka One One Bondi 4's. This is my 4th pair of these shoes",
                DatePurchased = new System.DateTime(2017, 1, 10),
                CurrentMileage = 243,
                IsActive = true,
            };

            var gearTypes = this.gearService.GetGearTypes();

            model.GearTypes = this.GetGearTypes(gearTypes);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(GearViewModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: save to database
            }

            return View(model);
        }

        private IEnumerable<SelectListItem> GetGearTypes(IEnumerable<LuGearType> gearTypes)
        {
            var types = gearTypes.Select(x => new SelectListItem
            {
                Value = x.GearTypeId.ToString(),
                Text = x.Name,
            });

            return new SelectList(types, "Value", "Text");
        }
    }
}