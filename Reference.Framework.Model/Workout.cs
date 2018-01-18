namespace Reference.Framework.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Workout")]
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int WorkoutTypeId { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime WorkoutDateTime { get; set; }

        public decimal? WorkoutDuration { get; set; }

        public int? PerceivedExertion { get; set; }

        public int? NormalizedPower { get; set; }

        public int? TrainingStressScore { get; set; }

        public decimal? AveragePace { get; set; }

        public decimal? Distance { get; set; }

        public string Route { get; set; }

        public int? GearId { get; set; }

        public string Notes { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public virtual User User { get; set; }

        public virtual LuWorkoutType LuWorkoutType { get; set; }

        public virtual Gear Gear { get; set; }
    }
}
