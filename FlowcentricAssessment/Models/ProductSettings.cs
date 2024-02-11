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
    public List<ClientSettings> ClientSettings { get; set; } //link to client Settings // Not sure if this is one to many ? i left it at 1 to many easy enough to change if need be just change the prop list <ClientSettings> will effect FK 
  }
}
