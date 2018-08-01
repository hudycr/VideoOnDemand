using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoOnDemand.Web.Helpers
{
    public class MapHelper
    {
        internal static IMapper mapper;

        static MapHelper()
        {
            var config = new MapperConfiguration(x => {


               });
            mapper = config.CreateMapper();
        }

        public static T Map<T>(object source)
        {
            return mapper.Map<T>(source);
        }
    }
}