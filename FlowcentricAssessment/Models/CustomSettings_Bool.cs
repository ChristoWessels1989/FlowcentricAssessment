using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlowcentricAssessment.Models
{
  public class CustomSettings_Bool : CustomSettings
  {
    [Required]
    public bool Value { get; set; }
  }
}
