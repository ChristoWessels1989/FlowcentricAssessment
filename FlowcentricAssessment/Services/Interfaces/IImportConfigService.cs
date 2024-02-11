using FlowcentricAssessment.Models.DTOs.Requests;
using FlowcentricAssessment.Models.DTOs.Responses;

namespace FlowcentricAssessment.Services.Interfaces
{
  public interface IImportConfigService
  {
    Task<ProductSettings_Response_DTO> ImportConfig(Configuration configuration);
  }
}
