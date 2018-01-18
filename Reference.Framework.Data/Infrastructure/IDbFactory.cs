namespace Reference.Framework.Data.Infrastructure
{
    using System;

    public interface IDbFactory : IDisposable
    {
        ExerciseEntities Init();
    }
}
