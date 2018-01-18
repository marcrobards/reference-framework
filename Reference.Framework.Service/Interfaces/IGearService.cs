namespace Reference.Framework.Service
{    
    using System.Collections.Generic;
    using Reference.Framework.Model;

    public interface IGearService
    {
        IEnumerable<LuGearType> GetGearTypes();
    }
}
