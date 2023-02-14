using eCI.model.wanted_people;
using eCI.service.wanted_people;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace eCI.service_impl.wanted_people
{
    internal class WantedPeopleServiceImpl : IWantedPeopleService
    {
        private const string BASE_URL = "http://vpcqcsdt.bocongan.gov.vn/Truy-n%C3%A3-TP/%C4%90%E1%BB%91i-t%C6%B0%E1%BB%A3ng-truy-n%C3%A3";

        public List<WantedPeopleEntity> CrawlWantedPeople()
        {
            List<WantedPeopleEntity> resultList = new List<WantedPeopleEntity>() { };

            int pageNumber = 1;
            int totalPage;
            do
            {
                resultList.AddRange(crawlOnePage(pageNumber, out totalPage));
                pageNumber += 1;
            } while(totalPage >= pageNumber);

            return resultList;
        }

        private List<WantedPeopleEntity> crawlOnePage(int pageNumber, out int totalPage) {
            List<WantedPeopleEntity> resultList = new List<WantedPeopleEntity>() { };

            //HttpHelper httpHelper = InstanceFactory.GetInstanceOfType<HttpHelper>();

            //string pageContent = httpHelper.GetContentOfUrl(BASE_URL);

            string pageContent = File.ReadAllText(@"D:\temp_data\data.html");

            Debug.WriteLine("wanted people page: " + pageContent);

            PageMatcher.ParsePagerInfoCell(pageContent, out string pageNumber_, out string totalPages_);
            Debug.WriteLine("pageInfo: " + pageNumber_ + " / " + totalPages_);

            totalPage = Convert.ToInt16(totalPages_);

            return resultList;
        }
    }
}
