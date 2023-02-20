using eCI.helper;
using eCI.model.common.events;
using eCI.model.common.office;
using eCI.model.wanted_people;
using eCI.service.wanted_people;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace eCI.service_impl.wanted_people
{
    internal class WantedPeopleServiceImpl : IWantedPeopleService
    {
        private const string BASE_URL = "http://vpcqcsdt.bocongan.gov.vn/Truy-n%C3%A3-TP/%C4%90%E1%BB%91i-t%C6%B0%E1%BB%A3ng-truy-n%C3%A3";

        public List<WantedPeopleEntity> CrawlWantedPeople(string urlOfWantedPeople, System.Action<object, string> updateUI)
        {
            List<WantedPeopleEntity> resultList = new List<WantedPeopleEntity>() { };

            int pageNumber = 1;
            int totalPage;
            long startTime_;
            do
            {
                startTime_ = DateTime.Now.Ticks;
                resultList.AddRange(CrawlOnePage(urlOfWantedPeople, pageNumber, out totalPage));
                pageNumber += 1;

                updateUI(this, $"progress {pageNumber}/{totalPage}");

                while (DateTime.Now.Ticks - startTime_ < 1_000) ;
            } while (totalPage >= pageNumber);

            updateUI(this, "completed");

            return resultList;
        }

        private List<WantedPeopleEntity> CrawlOnePage(string urlOfWantedPeople, int pageNumber, out int totalPage)
        {
            List<WantedPeopleEntity> resultList = new List<WantedPeopleEntity>();

            //HttpHelper httpHelper = InstanceFactory.GetInstanceOfType<HttpHelper>();

            //string pageContent = httpHelper.GetContentOfUrl(urlOfWantedPeople ?? BASE_URL);

            string pageContent = File.ReadAllText(@"D:\temp_data\data.html");

            //Debug.WriteLine("wanted people page: " + pageContent);

            PageMatcher.ParsePagerInfoCell(pageContent, out string pageNumber_, out string totalPages_);
            
            totalPage = Convert.ToInt16(totalPages_);

            resultList = PageMatcher.ParseListWantedPeople(pageContent);

            Debug.WriteLine("[info] size of wanted people on this page: " + resultList.Count);

            return resultList;
        }
    }
}
