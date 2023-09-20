using System.Text.RegularExpressions;

namespace ExtractNodeNameSelfClosingTags
{
    public class ExtractNodeName
    {
        public string GetNodeName(string element)
        {
            return Regex.Match(element, @"(?<=<)(.*)(?=/>)").Value.Trim();
        }
    }
}