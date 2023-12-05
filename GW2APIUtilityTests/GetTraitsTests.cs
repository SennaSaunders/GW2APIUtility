using FluentAssertions;
using GW2APIUtility;
using GW2APIUtility.Data.Traits;

namespace GW2APIUtilityTests
{
    public class GetTraitsTests
    {
        private ITraitAdaptor _traitAdaptor;

        [SetUp]
        public void Setup()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.guildwars2.com/v2/");
            IHttpPort httpPort = new HttpPort(httpClient);
            _traitAdaptor = new TraitAdaptor(httpPort);
        }

        [Test]
        public async Task ShouldGetAllTraitIds()
        {
            //Arrange
            int professions = 9;
            int coreSpecs = 5;
            int eliteSpecs = 3;
            int traitsPerSpec = 12;
            int tier0 = eliteSpecs * professions; //trait that describes the weapon the elite spec can use


            //Act
            IEnumerable<int> traitIds = await _traitAdaptor.GetTraitIds();

            //Assert
            int expected = professions * traitsPerSpec * (coreSpecs + eliteSpecs) + tier0;
            traitIds.Count().Should().Be(expected);
        }

        [Test]
        public async Task ShouldGetTrait()
        {
            //Arrange
            int id = 214;

            //Act
            Trait trait = await _traitAdaptor.GetTrait(id);

            //Assert            
            trait.Name.Should().Be("Raging Storm");
        }

        [Test]
        public async Task ShouldGetAllTraits()
        {
            //Arrange
            int professions = 9;
            int coreSpecs = 5;
            int eliteSpecs = 3;
            int traitsPerSpec = 12;
            int tier0 = eliteSpecs * professions; //trait that describes the weapon the elite spec can use

            //Act
            List<Trait> traits = await _traitAdaptor.GetTraits();            

            //Assert            
            int expected = professions * traitsPerSpec * (coreSpecs + eliteSpecs) + tier0;
            traits.Count().Should().Be(expected);

        }
    }
}
