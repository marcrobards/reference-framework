namespace Reference.Framework.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class GearViewModel
    {
        public int GearId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name="Gear Type")]
        public int GearTypeId { get; set; }

        public IEnumerable<SelectListItem> GearTypes { get; set; }

        public string Manufacturer { get; set; }

        [Display(Name = "Model")]
        public string GearModel { get; set; }

        public string Size { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Purchased")]
        public DateTime DatePurchased { get; set; }

        [Display(Name = "Current Mileage")]
        [DisplayFormat(DataFormatString = "{0:n1}", ApplyFormatInEditMode = true)]
        public decimal CurrentMileage { get; set; }

        public bool IsActive { get; set; }
    }
}