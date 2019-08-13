using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Mapper
{
    public static class UserMapper
    {
        internal static IMapper mapper;
        static UserMapper()
        {
            mapper = new MapperConfiguration(cfg => cfg.AddProfile<UserMapperProfile>())
                .CreateMapper();
        }

        public static Models.User ToModel(this Entities.User entity)
        {
            return mapper.Map<Models.User>(entity);
        }

        public static Entities.User ToEntity(this Models.User model)
        {
            return mapper.Map<Entities.User>(model);
        }
    }
}
