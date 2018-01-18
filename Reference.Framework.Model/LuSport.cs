namespace Reference.Framework.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LuSport")]
    public class LuSport
    {
        [Key]
        public int SportId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
