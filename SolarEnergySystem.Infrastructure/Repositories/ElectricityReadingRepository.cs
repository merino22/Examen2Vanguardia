using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarEnergySystem.Infrastructure.Repositories
{
    public class ElectricityReadingRepository : IRepo<ElectricityReading>
    {
        private readonly SolarEnergySystemDatabaseContext _context;

        public ElectricityReadingRepository(SolarEnergySystemDatabaseContext context)
        {
            _context = context;
        }
        public ElectricityReading Add(ElectricityReading entity)
        {
            var reading = _context.ElectricityReading.Add(entity);
            _context.SaveChanges();
            return reading.Entity;
        }

        public IEnumerable<ElectricityReading> Get()
        {
            return _context.ElectricityReading;
        }

        public ElectricityReading Get(string id)
        {
            return _context.ElectricityReading.SingleOrDefault(x => x.PanelId == id);
        }

        public ElectricityReading Update(ElectricityReading entity)
        {
            var reading = _context.ElectricityReading.Update(entity);
            _context.SaveChanges();
            return reading.Entity;
        }
    }
}
