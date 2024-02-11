namespace FlowcentricAssessment.Models
{
  public class ConfigSettings
  {
    public ProductSettings ProductSettings { get; set; }
    public ClientSettings ClientSettings { get; set; }
    public List <CustomSettings> customSettings { get; set; }
  }
}
