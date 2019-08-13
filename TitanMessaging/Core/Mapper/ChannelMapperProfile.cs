using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TitanMessaging.Core.Mapper
{
    public class ChannelMapperProfile : Profile
    {
        public ChannelMapperProfile()
        {
            CreateMap<Entities.Channel, Models.Channel>()
                .ForMember(x => x.Users, opts => opts.MapFrom(src => src.UserChannels.Select(uc => uc.User)));
        }
    }
}
