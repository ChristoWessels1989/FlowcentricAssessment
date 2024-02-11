using FlowcentricAssessment.Models.DTOs.Requests;
using FlowcentricAssessment.Models.DTOs.Responses;
using FlowcentricAssessment.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Xml.Linq;

namespace FlowcentricAssessment.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ImportConfigController : ControllerBase
  {
    private readonly IImportConfigService _importConfigService;
    protected Response_DTO _response;

    public ImportConfigController(IImportConfigService authenticationservice)
    {
      _importConfigService = authenticationservice;
      _response = new();
    }

    [HttpPost]
    public async Task<IActionResult> ImportConfig([FromBody] Configuration configuration)
    {
      var Response = await _importConfigService.ImportConfig(configuration);
      if (Response == null)
      {
        _response.IsSuccess = false;
        _response.Message = "Error importing Config";
        return BadRequest(_response);
      }

      _response.Result = Response;

      return Ok();
    }
  }
}
