using Microsoft.AspNetCore.Mvc;
using SolareEnergySystem.Api.DataTransferObjects;
using SolarEnergySystem.Infrastructure;

namespace SolareEnergySystem.Api.Controllers;
[ApiController]
[Route("panels")]
public class AnalyticsController : ControllerBase
{
    private readonly SolarEnergySystemDatabaseContext _context;

    public AnalyticsController(SolarEnergySystemDatabaseContext context)
    {
        _context = context;
    }

    [HttpGet("{panelId}/analytics")]
    public IActionResult Get(string panelId)
    {
        return Ok(_context.ElectricityReading.Where(x => x.PanelId == panelId));
    }

    

    // [HttpPost("{panelId}/analytics")]
    //public IActionResult Post(string panelId)
    // {
    // }
}

