using SolarEnergySystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarEnergySystem.Core.Interfaces
{
    public interface IService<T>
    {
        IEnumerable<T> Get();

        Result<T> Get(string id);

        Result<T> Add(T entity);

        Result<T> Update(T entity);

        Result<T> Delete(string name);
    }
}
