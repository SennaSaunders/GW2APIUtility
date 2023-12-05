using FluentAssertions;
using GW2APIUtility;
using GW2APIUtility.Data.Specializations;
using GW2APIUtility.Data.Specializations.Models;

namespace GW2APIUtilityTests
{
    public class GetSpecializationsTests
    {
        ISpecializationAdaptor _specializationAdaptor;

        [SetUp]
        public void Setup()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.guildwars2.com/v2/");
            IHttpPort httpPort = new HttpPort(httpClient);
            _specializationAdaptor = new SpecializationAdaptor(httpPort);
        }

        [Test]
        public async Task ShouldGetAllSpecializationIds()
        {
            //Arrange
            int professions = 9;
            int coreSpecs = 5;
            int eliteSpecs = 3;

            //Act
            IEnumerable<int> specializationIds = await _specializationAdaptor.GetSpecializationIds();

            // Assert
            int expected = professions * (coreSpecs + eliteSpecs);
            specializationIds.Count().Should().Be(expected);
        }

        [Test]
        public async Task ShouldGetAllSpecializations()
        {
            //Arrange
            int professions = 9;
            int coreSpecs = 5;
            int eliteSpecs = 3;

            //Act
            IEnumerable<ISpecialization> specializations = await _specializationAdaptor.GetSpecializations();

            // Assert
            int expected = professions * (coreSpecs + eliteSpecs);
            specializations.Should().NotBeNullOrEmpty();
        }
    }
}