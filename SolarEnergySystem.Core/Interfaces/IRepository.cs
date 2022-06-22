using System;
namespace SolarEnergySystem.Core.Interfaces
{
    public interface IRepository<TEntity, TKey>
    {
        void Add(TEntity entity);

        TEntity GetById(TKey key);

        IReadOnlyList<TEntity> GetAll();
    }
}

