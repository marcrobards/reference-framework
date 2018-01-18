namespace Reference.Framework.Data
{    
    using System.Data.Entity;
    using Reference.Framework.Model;

    public class ExerciseEntities : DbContext
    {
        public ExerciseEntities() : base("ExerciseEntities")
        {
        }

        public DbSet<Gear> Gear { get; set; }

        public DbSet<LuGearType> LuGearType { get; set; }

        public DbSet<LuSport> LuSport { get; set; }

        public DbSet<LuWorkoutType> LuWorkoutType { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Workout> Workout { get; set; }
    }
}
