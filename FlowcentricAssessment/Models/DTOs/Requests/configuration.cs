using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FlowcentricAssessment.Models.DTOs.Requests
{
  [XmlRoot(ElementName = "configuration")]
  public class Configuration
  {

    [XmlElement(ElementName = "appSettings")]
    public AppSettings AppSettings { get; set; }

    [XmlElement(ElementName = "customSettings")]
    public CustomSettings CustomSettings { get; set; }
  }

  //CUSTOM SETTINGS
  [XmlRoot(ElementName = "customSettings")]
  public class CustomSettings
  {
    [XmlElement(ElementName = "key")]
    public List<CustomKey> Key { get; set; }

    [XmlElement(ElementName = "value")]
    public List<CustomValue> Value { get; set; }

  }

  [XmlRoot(ElementName = "key")]
  public class CustomKey
  {
    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }

    [XmlElement(ElementName = "value")]
    public List<CustomValue> ChildValues { get; set; }

    [XmlElement(ElementName = "key")]
    public List<CustomKey> ChildKeys { get; set; }
  }

  [XmlRoot(ElementName = "value")]
  public class CustomValue
  {
    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
    [XmlText]
    public string Text { get; set; } = "";
  }
  //APP SETTINGS
  [XmlRoot(ElementName = "appSettings")]
  public class AppSettings
  {

    [XmlElement(ElementName = "add")]
    public List<Add> Add { get; set; }
  }

  [XmlRoot(ElementName = "add")]
  public class Add
  {

    [XmlAttribute(AttributeName = "key")]
    public string Key { get; set; }

    [XmlAttribute(AttributeName = "value")]
    public string Value { get; set; }
  }
}
