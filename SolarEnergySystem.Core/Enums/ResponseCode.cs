using System;
namespace SolarEnergySystem.Core.Enums
{
	public enum ResponseCode
	{
        Success,
        Error,
        InternalServerError = 500,
        NotFound
    }
}

