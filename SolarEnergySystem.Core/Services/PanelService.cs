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
    public class PanelService : IService<Panel>
    {
        private readonly IRepo<Panel> _panelRepository;

        public PanelService(IRepo<Panel> panelRepository)
        {
            _panelRepository = panelRepository;
        }

        public Result<Panel> Add(Panel entity)
        {
            throw new NotImplementedException();
        }

        public Result<Panel> Delete(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Panel> Get()
        {
            return _panelRepository.Get();
        }

        public Result<Panel> Get(string name)
        {
            throw new NotImplementedException();
        }

        public Result<Panel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result<Panel> Update(Panel entity)
        {
            var panel = _panelRepository.Update(entity);
            return new Result<Panel>(panel);
        }
    }
}
