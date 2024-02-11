using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FlowcentricAssessment.Models
{
  public class ClientSettings
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    [Required]
    public string WebsiteUrl { get; set; } //DO URL Validation
    [Required]
    public bool ShowHeader { get; set; }
    [Required]
    public bool ShowMenuBar { get; set; } 
    [Required]
    public int SubMenusToShow { get; set; }
    [Required]
    public bool EnableFeature1 { get; set; }
    [Required]
    public bool EnableFeature1AdvancedSearch { get; set; }
    [Required]
    public bool EnableFeature2 { get; set; }
    [Required]
    public bool EnableFeature3 { get; set; }
    [Required]
    public bool EnableFeature3AdvancedSearch { get; set; }
    [Required]
    public int Feature3ItemCount { get; set; }
    [Required]
    public bool EnableFeature4 { get; set; }
    [Required]
    public bool EnableFeature5 { get; set; }
    [Required]
    public bool DisplayFullError { get; set; }

    public List<CustomSettings> CustomSettings { get; set; } //Link to product Settings

  }
}
