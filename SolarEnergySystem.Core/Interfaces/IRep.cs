using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarEnergySystem.Core.Interfaces
{
    public interface IRepo<T>
    {
        IEnumerable<T> Get();

        T Get(string id);

        T Add(T entity);

        T Update(T entity);

    }
}
