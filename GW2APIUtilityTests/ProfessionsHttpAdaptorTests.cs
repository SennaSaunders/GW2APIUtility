using FluentAssertions;
using GW2APIUtility.DataRetrieval;

namespace GW2APIUtilityTests
{
    internal class ProfessionsHttpAdaptorTests
    {
        [Test]
        public async Task ShouldGetAllProfessions()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.guildwars2.com/v2/");
            IHttpPort httpPort = new HttpPort(httpClient);
            // Arrange            
            IProfessionsHttpAdaptor professionsHttpAdaptor = new ProfessionsHttpAdaptor(httpPort);

            // Act
            var professions = await professionsHttpAdaptor.GetProfessions();

            // Assert
            int professionCount = 9;
            professions.Count.Should().Be(professionCount);
        }
    }
}
