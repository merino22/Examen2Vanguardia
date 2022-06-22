using Microsoft.AspNetCore.Mvc;
using SolareEnergySystem.Api.DataTransferObjects;
using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;

namespace SolareEnergySystem.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElectricityReadingsController : ControllerBase
    {
        private readonly IService<ElectricityReading> _readingService;

        public ElectricityReadingsController(IService<ElectricityReading> readingService)
        {
            _readingService = readingService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ElectricityReadingDTO>> Get()
        {
            return Ok(_readingService.Get().Select(x => new ElectricityReadingDTO
            {
                Panel = x.Panel,
                PanelId = x.PanelId,
                KiloWatt = x.KiloWatt,
                ReadingDateTime = x.ReadingDateTime
            }
            ).ToList()
            );
        }

        [HttpPost]
        public ActionResult<ElectricityReadingDTO> Post([FromBody] ElectricityReadingDTO newReading)
        {
            var result = _readingService.Add(new ElectricityReading
            {
                PanelId = newReading.PanelId,
                Panel = newReading.Panel,
                ReadingDateTime = DateTime.UtcNow,
                KiloWatt = newReading.KiloWatt,
            });
            return result.Success ? Ok(new ElectricityReadingDTO
            {
                PanelId = result.Value.PanelId,
                Panel = result.Value.Panel,
                ReadingDateTime = DateTime.UtcNow,
                KiloWatt = result.Value.KiloWatt,
            }) : BadRequest(result.ErrorMessage);
        }
    }
}
