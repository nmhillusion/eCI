using eCI.model.wanted_people;
using System.Collections.Generic;

namespace eCI.service.wanted_people
{
    interface IWantedPeopleService
    {
        List<WantedPeopleEntity> CrawlWantedPeople();
    }
}
