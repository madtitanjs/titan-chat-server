using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Mapper
{
    public static class ChannelMapper
    {
        internal static IMapper mapper;
        static ChannelMapper()
        {
            mapper = new MapperConfiguration(cfg => cfg.AddProfile<ChannelMapperProfile>())
                .CreateMapper();
        }

        public static Models.Channel ToModel(this Entities.Channel entity)
        {
            return mapper.Map<Models.Channel>(entity);
        }

        public static Entities.Channel ToEntity(this Models.Channel model)
        {
            return mapper.Map<Entities.Channel>(model);
        }
    }
}
