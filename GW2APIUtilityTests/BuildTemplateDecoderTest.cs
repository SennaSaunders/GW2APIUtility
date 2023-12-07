using GW2APIUtility.Builds;

namespace GW2APIUtilityTests
{
    public class BuildTemplateDecoderTest
    {
        private BuildTemplateDecoder _buildTemplateDecoder;

        [SetUp]
        public void Setup()
        {
            _buildTemplateDecoder = new BuildTemplateDecoder();
        }

        [Test]
        public void ShouldGetCorrectBuild()
        {
            // Arrange
            string buildTemplateLink = "[&DQIEOQsOAABwAKYAPQGzAK8AAAAAAKkAnADuAAAAAAAAAAAAAAAAAAAAAAA=]";

            // Act
            var build = _buildTemplateDecoder.Decode(buildTemplateLink);

            // Assert
        }
    }
}
