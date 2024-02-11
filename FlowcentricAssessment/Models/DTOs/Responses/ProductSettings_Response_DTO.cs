using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlowcentricAssessment.Models.DTOs.Responses
{
  public class ProductSettings_Response_DTO
  {
    public class ProductSettings
    {
      public Guid Id { get; set; }
      public string Company { get; set; }
      public string License { get; set; }
      public string ServerAddress { get; set; } //DO URL Validation
      public int LoginAttemptLimit { get; set; }
      public int PasswordHistory { get; set; }
      public List<ClientSettings> ClientSettings { get; set; } //link to client Settings // Not sure if this is one to many ? i left it at 1 to many easy enough to change if need be just change the prop list <ClientSettings> will effect FK 
    }
  }
}
