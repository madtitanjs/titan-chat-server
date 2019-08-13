using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.Core.Mapper
{
    public class MessageMapperProfile : Profile
    {
        public MessageMapperProfile()
        {
            CreateMap<Entities.Message, Models.Message>();
        }
    }
}
