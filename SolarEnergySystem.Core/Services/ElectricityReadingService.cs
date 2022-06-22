using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;
using SolarEnergySystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarEnergySystem.Core.Services
{
    public class ElectricityReadingService : IService<ElectricityReading>
    {
        private readonly IRepo<ElectricityReading> _readingRepository;

        public ElectricityReadingService(IRepo<ElectricityReading> readingRepository)
        {
            _readingRepository = readingRepository;
        }

        public Result<ElectricityReading> Add(ElectricityReading entity)
        {
            if(_readingRepository.Get().Any(x => x.Id == entity.Id))
            {
                return new Result<ElectricityReading>($"Reading {entity.PanelId} ya existe");
            }
            var entry = _readingRepository.Add(entity);
            return new Result<ElectricityReading>(entry);
        }

        public Result<ElectricityReading> Delete(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ElectricityReading> Get()
        {
            return _readingRepository.Get();    
        }

        public Result<ElectricityReading> Get(string id)
        {
            var reading = _readingRepository.Get(id);
            if(reading == null)
            {
                reading = new ElectricityReading
                {     
                    PanelId = id,
                    ReadingDateTime = DateTime.UtcNow,
                };
                reading = _readingRepository.Add(reading);
            }
            return new Result<ElectricityReading>(reading);
        }

        public Result<ElectricityReading> Update(ElectricityReading entity)
        {
            throw new NotImplementedException();
        }
    }
}
