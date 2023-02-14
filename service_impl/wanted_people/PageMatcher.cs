using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eCI.service_impl.wanted_people
{
    internal class PageMatcher
    {
        // <td class="PagerInfoCell">Page 10 of 188</td>

        public static void ParsePagerInfoCell(string pageContent, out string pageNumber, out string totalPages)
        {
            pageNumber = "0";
            totalPages = "0";

            Regex regex_ = new Regex(@"<td class=['""]PagerInfoCell['""]>(.+?)</td>");
            Match matched_ = regex_.Match(pageContent);

            if (matched_ != null)
            {
                string pageInfo = matched_.Groups[1].Value;

                Regex pageInfoRegex = new Regex(@"Page (\d+) of (\d+)");

                Match pageInfoMatch = pageInfoRegex.Match(pageInfo);

                if (pageInfoMatch != null)
                {
                    pageNumber = pageInfoMatch.Groups[1].Value;
                    totalPages = pageInfoMatch.Groups[2].Value;
                }
            }
        }

    }
}
