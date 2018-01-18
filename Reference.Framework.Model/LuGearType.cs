namespace Reference.Framework.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LuGearType")]
    public class LuGearType
    {
        [Key]
        public int GearTypeId { get; set; }

        [Required]
        public int SportId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual LuSport LuSport { get; set; }
    }
}
