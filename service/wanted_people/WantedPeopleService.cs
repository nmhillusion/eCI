using eCI.model.wanted_people;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace eCI.service.wanted_people
{
    interface IWantedPeopleService
    {
        List<WantedPeopleEntity> CrawlWantedPeople(string urlOfWantedPeople, System.Action<object, string> updateUI);
    }
}
