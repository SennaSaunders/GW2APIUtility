using FluentAssertions;
using GW2APIUtility.DataRetrieval;
using GW2APIUtility.Models.Skills;
using GW2APIUtility.Models.Specializations;
using GW2APIUtility.Models.Traits;

namespace GW2APIUtilityTests
{
    public class PagingHttpAdaptorTests
    {
        private IHttpPort _httpPort;

        [SetUp]
        public void Setup()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.guildwars2.com/v2/");
            _httpPort = new HttpPort(httpClient);
        }

        [Test]
        public async Task ShouldGetAllTraits()
        {
            // Arrange
            string endpoint = "traits";
            string? url = $"{endpoint}?page=";
            IPagingHttpAdaptor<Trait> pagingHttpAdaptor = new PagingHttpAdaptor<Trait>(_httpPort);

            // Act
            var traits = await pagingHttpAdaptor.GetItems(url);

            // Assert
            int professions = 9;
            int coreSpecs = 5;
            int eliteSpecs = 3;
            int traitsPerSpec = 12;
            int tier0 = eliteSpecs * professions; //trait that describes the weapon the elite spec can use
            int expected = professions * traitsPerSpec * (coreSpecs + eliteSpecs) + tier0;

            traits.Count.Should().Be(expected);
        }

        [Test]
        public async Task ShouldGetAllSkills()
        {
            // Arrange
            string endpoint = "skills";
            string? url = $"{endpoint}?page=";
            IPagingHttpAdaptor<Skill> pagingHttpAdaptor = new PagingHttpAdaptor<Skill>(_httpPort);

            // Act
            var skills = await pagingHttpAdaptor.GetItems(url);

            // Assert
            int pages = 81;
            int pageSize = 50;
            int finalPageCount = 45;
            int expected = (pages - 1)*pageSize + finalPageCount;

            skills.Count.Should().Be(expected);
        }

        [Test]
        public async Task ShouldGetAllSpecializations()
        {
            // Arrange
            string endpoint = "specializations";
            string? url = $"{endpoint}?page=";
            IPagingHttpAdaptor<Specialization> pagingHttpAdaptor = new PagingHttpAdaptor<Specialization>(_httpPort);

            // Act
            var specs = await pagingHttpAdaptor.GetItems(url);

            // Assert
            int professions = 9;
            int coreSpecs = 5;
            int eliteSpecs = 3;
            int expected = professions * (coreSpecs + eliteSpecs);
            specs.Count.Should().Be(expected);
        }
    }
}
