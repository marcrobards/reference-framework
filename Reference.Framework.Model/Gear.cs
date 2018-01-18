namespace Reference.Framework.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Gear")]
    public class Gear
    {
        [Key]
        public int GearId { get; set; }

        [Required]
        public int GearTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Manufacturer { get; set; }

        [StringLength(100)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Size { get; set; }

        public DateTime? DatePurchased { get; set; }
        
        public decimal? CurrentMileage { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
