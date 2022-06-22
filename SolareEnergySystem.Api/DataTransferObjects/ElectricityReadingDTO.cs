using SolarEnergySystem.Core.Entities;

namespace SolareEnergySystem.Api.DataTransferObjects
{
    public class ElectricityReadingDTO
    {
        public string PanelId { get; set; }

        public Panel Panel { get; set; }

        public double KiloWatt { get; set; }

        public DateTime ReadingDateTime { get; set; }
    }
}
