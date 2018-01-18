namespace Reference.Framework.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LuWorkoutType")]
    public class LuWorkoutType
    {
        [Key]
        public int WorkoutTypeId { get; set; }

        [Required]
        public int SportId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
