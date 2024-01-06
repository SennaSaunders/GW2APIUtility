namespace GW2APIUtility.Builds
{
    public class BuildTemplateDecoder
    {
        private BuildCreator _buildCreator;

        public Build Decode(string buildTemplateLink)
        {
            string binary = ConvertToBinary(buildTemplateLink);
            

            return _buildCreator.GetBuild(binary);
        }

        private string ConvertToBinary(string buildTemplateLink)
        {
            string base64 = buildTemplateLink.Replace("[", "").Replace("]", "").Replace("&", "");
            byte[] bytes = Convert.FromBase64String(base64);
            string binary = string.Join(String.Empty, bytes.Select(e => Convert.ToString(e, 2).PadLeft(8, '0')));
            return binary;
        }        
    }
}