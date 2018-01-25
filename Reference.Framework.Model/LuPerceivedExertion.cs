namespace Reference.Framework.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LuPerceivedExertion")]
    public class LuPerceivedExertion
    {
        [Key]
        public int PerceivedExertionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
