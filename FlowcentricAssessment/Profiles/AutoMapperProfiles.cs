using AutoMapper;
using FlowcentricAssessment.Models;
using FlowcentricAssessment.Models.DTOs.Responses;
using System.Diagnostics.Metrics;

namespace FlowcentricAssessment.Profiles
{
  public class AutoMapperProfiles : Profile
  {
    public AutoMapperProfiles()
    {
      // Source -> Target
      //CreateMap<Request_Register_DTO, IdentityUser>()
      //          .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
      //          .ForMember(dest => dest.NormalizedEmail, opt => opt.MapFrom(src => src.Email.ToUpper()));
      CreateMap<ProductSettings, ProductSettings_Response_DTO>();

    }
  }
}
