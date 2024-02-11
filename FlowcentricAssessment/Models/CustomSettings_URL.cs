using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlowcentricAssessment.Models
{
  public class CustomSettings_URL : CustomSettings
  {
    [Required]
    public string Value {  get; set; } //URL Validation
  }
}
