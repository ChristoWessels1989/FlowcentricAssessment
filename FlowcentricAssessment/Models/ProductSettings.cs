using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlowcentricAssessment.Models
{
  public class ProductSettings
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    [Required]
    public string Company { get; set; }
    [Required]
    public Guid License { get; set; }
    [Required]
    public string ServerAddress { get; set; } //DO URL Validation
    [Required]
    public int LoginAttemptLimit { get; set; }
    [Required]
    public int PasswordHistory { get; set; }
  }
}
