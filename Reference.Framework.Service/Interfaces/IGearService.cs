namespace Reference.Framework.Service
{
    using System.Collections.Generic;
    using Reference.Framework.Model;

    public interface IGearService
    {
        Gear GetById(int id);

        IEnumerable<LuGearType> GetGearTypes();

        IEnumerable<Gear> GetActiveGear();

        void CreateGear(Gear dto);

        void UpdateGear(Gear dto);
    }
}
