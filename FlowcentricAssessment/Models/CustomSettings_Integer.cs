using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlowcentricAssessment.Models
{
  public class CustomSettings_Integer : CustomSettings
  {
    [Required]
    public int value {  get; set; }
  }
}
