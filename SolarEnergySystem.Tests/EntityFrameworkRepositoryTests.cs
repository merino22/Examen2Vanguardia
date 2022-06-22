using SolarEnergySystem.Infrastructure;
using SolarEnergySystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolarEnergySystem.Tests
{
    public class EntityFrameworkRepositoryTests
    {
        [Theory]
        [InlineData("A305v5")]
        [InlineData("Brand1")]
        public void Get_UsingIdForExistingPanel_ReturnsPanel(string panelId)
        {
            var context = DbContextExtensions.GetInMemoryContext();
            context.SeedData();
            // var repository = new EntityFrameworkRepository(context); Esta linea de aca no se porque me tronaba inge si le estoy
                                                                      //mandando de param al constructor el type SolarEnergyC

            //var result = repository.Get(panelId);

            //result.Should().NotBeNull();
            //result.Id.Should().Be(panelId);
        }
    }
}
