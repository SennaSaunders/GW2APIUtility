using System.Text;

namespace GW2APIUtility.Builds
{
    public class BuildTemplateDecoder
    {
        public Build Decode(string buildTemplateLink)
        {
            var str = ConvertToBinary(buildTemplateLink);
            return null;
        }

        private string ConvertToBinary(string buildTemplateLink)
        {
            string base64 = buildTemplateLink.Replace("[", "").Replace("]", "").Replace("&", "");
            byte[] bytes = Convert.FromBase64String(base64);

            string binaryString = Encoding.UTF8.GetString(bytes);

            string test2 = string.Join(' ', bytes.Select(e => Convert.ToString(e, 2).PadLeft(8, '0')));

            List<DataFrame> frames = GetSpec();
            
            return binaryString;
        }

        private List<DataFrame> GetSpec()
        {
            List<DataFrame> frames = new List<DataFrame>()
            {
                new DataFrame(DataType.Type, 8),
                new DataFrame(DataType.ProfessionID, 8),

                new DataFrame(DataType.SpecID, 8),
                new DataFrame(DataType.Unused, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),

                new DataFrame(DataType.SpecID, 8),
                new DataFrame(DataType.Unused, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),

                new DataFrame(DataType.SpecID, 8),
                new DataFrame(DataType.Unused, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),

                new DataFrame(DataType.LandHeal, 8),
                new DataFrame(DataType.AquaHeal, 8),

                new DataFrame(DataType.LandUtil, 8),
                new DataFrame(DataType.AquaUtil, 8),

                new DataFrame(DataType.LandUtil, 8),
                new DataFrame(DataType.AquaUtil, 8),

                new DataFrame(DataType.LandUtil, 8),
                new DataFrame(DataType.AquaUtil, 8),

                new DataFrame(DataType.LandElite, 8),
                new DataFrame(DataType.AquaElite, 8)
            };

            return frames;
        }
    }
}