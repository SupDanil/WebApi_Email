using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Contracts;
using WebApi.Models;

namespace WebApi.Infrastructure
{
    public  class ApiMappingProfile : Profile 
    {
       public ApiMappingProfile()
        {
            CreateMap<EmailContract, EmailModel>().
                ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Subject));
        }

    }
}
