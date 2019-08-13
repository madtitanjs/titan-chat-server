using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Mapper
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<Entities.User, Models.User>();
        }
    }
}
