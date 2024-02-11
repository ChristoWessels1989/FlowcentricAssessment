using FlowcentricAssessment.Models.DTOs.Requests;
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
    //private readonly IAuthService _authenticationService;

    //public ImportConfigController(IAuthService authenticationService)
    //{
    //  _authenticationService = authenticationService;
    //  _response = new();
    //}

    [HttpPost]
    public async Task<IActionResult> ImportConfig([FromBody] Configuration configuration)
    {


      //var doc = new XmlDocument();
      //  doc.Load(request.Content.ReadAsStreamAsync().Result);        
      //  return Ok(doc.DocumentElement.OuterXml.ToString());
      return Ok();
    }
  }
}
