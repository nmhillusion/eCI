using eCI.helper;
using eCI.service.wanted_people;
using eCI.service_impl;
using System;
using System.Collections.Generic;

namespace eCI
{
    class InstanceFactory
    {
        private static readonly Dictionary<Type, object> factoryStorage = new Dictionary<Type, object> {
            { typeof(IWantedPeopleService), new WantedPeopleServiceImpl() },
            { typeof(HttpHelper), new HttpHelper() },
        };

        public static T GetInstanceOfType<T>()
        {
            return (T)factoryStorage[typeof(T)];
        }
    }
}
