
using System;
using Microsoft.AspNetCore.Mvc;
using SolareEnergySystem.Api.DataTransferObjects;
using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;
using SolarEnergySystem.Infrastructure;

namespace SolareEnergySystem.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PanelsController : ControllerBase
    {
        private readonly SolarEnergySystemDatabaseContext _context;

        public PanelsController(SolarEnergySystemDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Panel.OrderByDescending(x => x.PanelType).ToList());
        }
    }
}

