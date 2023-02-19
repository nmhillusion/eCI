using eCI.helper;
using eCI.model.wanted_people;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace eCI.service_impl.wanted_people
{
    internal class PageMatcher
    {

        public static List<WantedPeopleEntity> ParseListWantedPeople(string pageContent)
        {
            List<WantedPeopleEntity> resultList = new List<WantedPeopleEntity>();

            Regex regex_ = new Regex(@"<tr class=""row1"">(.*?)<\/tr>",
                RegexOptions.IgnoreCase | RegexOptions.Singleline
            );
            MatchCollection matchColl_ = regex_.Matches(pageContent);

            foreach (Match match_ in matchColl_)
            {
                for (int groupIdx_ = 1; groupIdx_ < match_.Groups.Count; ++groupIdx_)
                {
                    var group_ = match_.Groups[groupIdx_].Value;
                    resultList.Add(ParseWantedPeople(group_));
                }
            }

            return resultList;
        }

        private static WantedPeopleEntity ParseWantedPeople(string wantedPeopleContent)
        {
            WantedPeopleEntity entity = new WantedPeopleEntity();

            Regex regex_ = new Regex(@"<td\s*(?:.*?)>(.*?)</td>",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);

            MatchCollection matchColl_ = regex_.Matches(wantedPeopleContent);

            string fullName = ParseValueFromMatchGroups(matchColl_, 1);
            string birthday = ParseValueFromMatchGroups(matchColl_, 2);
            string livePlace = ParseValueFromMatchGroups(matchColl_, 3);
            string nameOfParents = ParseValueFromMatchGroups(matchColl_, 4);
            string crimeName = ParseValueFromMatchGroups(matchColl_, 5);
            string decisionDate = ParseValueFromMatchGroups(matchColl_, 6);
            string decisionOffice = ParseValueFromMatchGroups(matchColl_, 7);

            entity.fullName = fullName;
            entity.birthday = birthday;
            entity.livePlace = livePlace;
            entity.nameOfParents = nameOfParents;
            entity.crimeName = crimeName;
            entity.decisionDate = decisionDate;
            entity.decisionOffice = decisionOffice;


            return entity;
        }

        private static string ParseValueFromMatchGroups(MatchCollection matchColl_, int matchIdx_)
        {
            var group_ = matchColl_[matchIdx_].Groups[1].Value;
            group_ = HtmlHelper.removeTagSynctax(group_);

            return group_;
        }

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
