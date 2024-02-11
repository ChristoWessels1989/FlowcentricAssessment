using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlowcentricAssessment.Models
{
  public class CustomSettings // Groups - all others will be extensions 
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string Name { get; set; } //Key value from XML File
    public CustomSettingsType CustomSettingsType { get; set; } // Type Enum 
    public CustomSettings? ParentLinkID { get; set; } //Used for adding into a group N level
    
  }

  public class CustomSettingsString : CustomSettings //freetext , URL ,E-mail
  {
    public string? stringValue { get; set; }  //Splitting string int and bool values here nullable for DB 
  }

  public class CustomSettingsInt : CustomSettings //integer
  {
    public int? intValue { get; set; }  //Splitting string int and bool values here nullable for DB 
  }

  public class CustomSettingsBool : CustomSettings //Boolean
  {
    public string? boolValue { get; set; }  //Splitting string int and bool values here nullable for DB 

  }
}
