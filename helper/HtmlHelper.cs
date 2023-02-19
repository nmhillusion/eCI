using System.Text.RegularExpressions;

namespace eCI.helper
{
    internal class HtmlHelper
    {
        public static string removeTagSynctax(string content)
        {
            return Regex.Replace(content, @"<\/?\w+\s*.*?>|&\w+;", "")
                ;
        }
    }
}
