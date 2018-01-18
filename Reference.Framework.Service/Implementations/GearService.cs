namespace Reference.Framework.Service
{
    using System.Collections.Generic;
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Data.Repositories;
    using Reference.Framework.Model;

    public class GearService : IGearService
    {
        private readonly ILuGearTypeRepository luGearTypeRepository;
        private readonly IUnitOfWork unitOfWork;

        public GearService(ILuGearTypeRepository luGearTypeRepository, IUnitOfWork unitOfWork)
        {
            this.luGearTypeRepository = luGearTypeRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<LuGearType> GetGearTypes()
        {
            var gearTypes = this.luGearTypeRepository.GetAll();

            return gearTypes;
        }
    }
}
