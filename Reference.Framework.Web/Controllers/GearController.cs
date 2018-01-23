namespace Reference.Framework.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper;
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
            var model = new GearIndexViewModel();

            var gears = this.gearService.GetActiveGear();

            var vwGears = Mapper.Map<IEnumerable<GearViewModel>>(gears);

            model.Gears = vwGears;

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new GearViewModel();

            var gearTypes = this.gearService.GetGearTypes();

            model.GearTypes = this.GetGearTypes(gearTypes);

            model.DatePurchased = DateTime.Now;

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(GearViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.IsActive = true;

                var dto = Mapper.Map<Gear>(model);

                this.gearService.CreateGear(dto);

                return RedirectToAction(nameof(Index));
            }

            var gearTypes = this.gearService.GetGearTypes();

            model.GearTypes = this.GetGearTypes(gearTypes);

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var dto = this.gearService.GetById(id);

            var model = Mapper.Map<GearViewModel>(dto);

            var gearTypes = this.gearService.GetGearTypes();

            model.GearTypes = this.GetGearTypes(gearTypes);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(GearViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dto = Mapper.Map<Gear>(model);

                this.gearService.UpdateGear(dto);

                return RedirectToAction(nameof(Index));
            }

            var gearTypes = this.gearService.GetGearTypes();

            model.GearTypes = this.GetGearTypes(gearTypes);

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