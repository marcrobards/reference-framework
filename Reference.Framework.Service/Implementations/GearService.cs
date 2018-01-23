namespace Reference.Framework.Service
{
    using System;
    using System.Collections.Generic;
    using Reference.Framework.Data.Infrastructure;
    using Reference.Framework.Data.Repositories;
    using Reference.Framework.Model;

    public class GearService : IGearService
    {
        private readonly IGearRepository gearRepository;
        private readonly ILuGearTypeRepository luGearTypeRepository;
        private readonly IUnitOfWork unitOfWork;

        public GearService(
            IGearRepository gearRepository,
            ILuGearTypeRepository luGearTypeRepository,
            IUnitOfWork unitOfWork)
        {
            this.gearRepository = gearRepository;
            this.luGearTypeRepository = luGearTypeRepository;
            this.unitOfWork = unitOfWork;
        }

        public Gear GetById(int id)
        {
            return this.gearRepository.GetById(id);
        }

        public IEnumerable<LuGearType> GetGearTypes()
        {
            var gearTypes = this.luGearTypeRepository.GetAll();

            return gearTypes;
        }

        public IEnumerable<Gear> GetActiveGear()
        {
            return this.gearRepository.GetMany(x => x.IsActive == true && x.IsDeleted == false);
        }

        public void CreateGear(Gear dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            this.unitOfWork.BeginTransaction();

            try
            {
                this.gearRepository.Add(dto);

                this.unitOfWork.SaveChanges();

                this.unitOfWork.Commit();
            }
            catch (System.Exception ex)
            {
                this.unitOfWork.Rollback();
                throw ex;
            }
        }

        public void UpdateGear(Gear dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            this.unitOfWork.BeginTransaction();

            try
            {
                this.gearRepository.Update(dto);

                this.unitOfWork.SaveChanges();

                this.unitOfWork.Commit();
            }
            catch (System.Exception ex)
            {
                this.unitOfWork.Rollback();
                throw ex;
            }
        }
    }
}
