using AutoMapper;
using Azure.Core;
using FlowcentricAssessment.Data.Interfaces;
using FlowcentricAssessment.Models;
using FlowcentricAssessment.Models.DTOs.Requests;
using FlowcentricAssessment.Models.DTOs.Responses;
using FlowcentricAssessment.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace FlowcentricAssessment.Services
{
  public class ImportConfigService : IImportConfigService
  {
    private readonly IEditableRepo<ProductSettings> _repository;
    private readonly IMapper _mapper;

    public ImportConfigService(IEditableRepo<ProductSettings> repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    public async Task<ProductSettings_Response_DTO> ImportConfig(Configuration configuration)
    {
      //Should use automapper top map from configuration to  product settings but going to do it manually here 
      ProductSettings productSettings = new ProductSettings();
      ClientSettings clientSettings = new ClientSettings();
      var productSettingsType = typeof(ProductSettings);
      var clientSettingsType = typeof(ClientSettings);
      foreach (Add setting in configuration.AppSettings.Add)
      {
        var propertyInfo = productSettingsType.GetProperty(setting.Key);

        //Product line
        if (propertyInfo != null)
        {
          if (propertyInfo.PropertyType == typeof(string))
          {
            productSettingsType.GetProperty(setting.Key).SetValue(productSettings, setting.Value);

          }
          else
          {
            var propType = propertyInfo.PropertyType;
            var converter = TypeDescriptor.GetConverter(propType);
            var convertedObject = converter.ConvertFromString(setting.Value);
            productSettingsType.GetProperty(setting.Key).SetValue(productSettings, convertedObject);
          }

        }
        //Client Line
        else
        {

          propertyInfo = clientSettingsType.GetProperty(setting.Key);
          if (propertyInfo != null)
          {
            if (propertyInfo.PropertyType == typeof(string))
            {
              clientSettingsType.GetProperty(setting.Key).SetValue(clientSettings, setting.Value);

            }
            else
            {
              var propType = propertyInfo.PropertyType;
              var converter = TypeDescriptor.GetConverter(propType);
              var convertedObject = converter.ConvertFromString(setting.Value);
              clientSettingsType.GetProperty(setting.Key).SetValue(clientSettings, convertedObject);

            }
          }
        }
      }

      productSettings.ClientSettings = new List<ClientSettings> { clientSettings };

      productSettings = _repository.CreateRecord(productSettings);
      _repository.SaveChanges();

      //Import custom Setting
      importCustomSettings(configuration.CustomSettings);


      var result = _mapper.Map<ProductSettings_Response_DTO>(productSettings);
      return result;
    }

    public void importCustomSettings(FlowcentricAssessment.Models.DTOs.Requests.CustomSettings customSettings )
    {

      //This should happen Recursively for each group 
      foreach (var value in customSettings.Value)
      {
        if(int.TryParse(value.Text, out int intValue))
        {
          CustomSettingsInt newintCustomSetting = new CustomSettingsInt();
          newintCustomSetting.intValue = intValue;
          newintCustomSetting.Name = value.Name;
          newintCustomSetting.CustomSettingsType = CustomSettingsType.Integer;
        }
        if (bool.TryParse(value.Text, out bool boolValue))
        {
          CustomSettingsBool newintCustomSetting = new CustomSettingsBool();
          newintCustomSetting.boolValue = boolValue;
          newintCustomSetting.Name = value.Name;
          newintCustomSetting.CustomSettingsType = CustomSettingsType.Boolean;
        }
        //String
        else
        {
          CustomSettingsString newintCustomSetting = new CustomSettingsString();
          newintCustomSetting.stringValue = value.Text;
          newintCustomSetting.Name = value.Name;
          if ( ValidateUrlWithRegex(value.Text))
            newintCustomSetting.CustomSettingsType = CustomSettingsType.Url;
          else
          {
            ////Check for emails
            //newintCustomSetting.CustomSettingsType = CustomSettingsType.Email;

            newintCustomSetting.CustomSettingsType = CustomSettingsType.String;
          }
        }
      }

    }

    static bool ValidateUrlWithRegex(string url)
    {
      string pattern = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
      Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
      return regex.IsMatch(url);
    }

  }
}
