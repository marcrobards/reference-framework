namespace Reference.Framework.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class GearViewModel
    {
        public int GearId { get; set; }

        public string Name { get; set; }

        public string GearType { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Size { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DatePurchased { get; set; }

        public decimal CurrentMileage { get; set; }

        public bool IsActive { get; set; }
    }
}