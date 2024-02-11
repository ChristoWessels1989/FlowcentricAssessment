using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlowcentricAssessment.Models
{
  public class CustomSettings
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; } //Key value from XML File

    //Not doing value here as we have Different values and group settings have no values (will add Values in extension classes ) 
    public CustomSettings ParentLink { get; set; } //Used for adding into a group N level

  }
}
