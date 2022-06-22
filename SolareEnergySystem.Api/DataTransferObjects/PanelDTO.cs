using SolarEnergySystem.Core.Enums;

namespace SolareEnergySystem.Api.DataTransferObjects
{
    public class PanelDTO
    {
        public PanelType PanelType { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public string Brand { get; set; }

        public MeasuringUnit MeasuringUnit { get; set; }
    }
}
