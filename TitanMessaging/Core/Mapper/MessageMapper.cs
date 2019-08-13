using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Mapper
{
    public static class MessageMapper
    {
        internal static IMapper mapper;
        static MessageMapper()
        {
            mapper = new MapperConfiguration(cfg => cfg.AddProfile<MessageMapperProfile>())
                .CreateMapper();
        }

        public static Models.Message ToModel(this Entities.Message entity)
        {
            return mapper.Map<Models.Message>(entity);
        }

        public static Entities.Message ToEntity(this Models.Message model)
        {
            return mapper.Map<Entities.Message>(model);
        }
    }
}
