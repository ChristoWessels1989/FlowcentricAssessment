using FlowcentricAssessment.Data.Interfaces;
using FlowcentricAssessment.Models;

namespace FlowcentricAssessment.Data
{
  public class ProductSettingsRepo : IEditableRepo<ProductSettings>
  {
    private readonly AppDBContext _appDBContext;

    public ProductSettingsRepo(AppDBContext appDBContext)
    {
      _appDBContext = appDBContext;
    }
    public ProductSettings CreateRecord(ProductSettings obj)
    {
      if (obj == null)
      {
        throw new ArgumentNullException(nameof(obj));
      }

      _appDBContext.ProductSettings.Add(obj);

      return obj;
    }

    public bool DeleteRecord(object KeyValue)
    {
      Guid id = (Guid)KeyValue;
      var bloodGroup = _appDBContext.ProductSettings.FirstOrDefault(p => p.Id == id);
      if (bloodGroup == null)
      {
        throw new ArgumentNullException(nameof(bloodGroup));
      }

      _appDBContext.ProductSettings.Remove(bloodGroup);

      return true;
    }

    public IEnumerable<ProductSettings> GetAllRecords()
    {
      return _appDBContext.ProductSettings.ToList();
    }

    public ProductSettings GetRecordById(object KeyValue)
    {
      Guid id = (Guid)KeyValue;
      return _appDBContext.ProductSettings.FirstOrDefault(p => p.Id == id);
    }

    public bool SaveChanges()
    {
      return (_appDBContext.SaveChanges() >= 0);
    }

    public ProductSettings updateRecord(ProductSettings obj)
    {
      ProductSettings RecordToupdate = _appDBContext.ProductSettings.Find(obj.Id);

      if (RecordToupdate == null)
      {
        throw new ArgumentNullException(nameof(RecordToupdate));
      }

      RecordToupdate.Company = obj.Company;
      RecordToupdate.License = obj.License;
      RecordToupdate.ServerAddress = obj.ServerAddress;
      RecordToupdate.LoginAttemptLimit = obj.LoginAttemptLimit;
      RecordToupdate.PasswordHistory = obj.PasswordHistory;
      RecordToupdate.ClientSettings = obj.ClientSettings;

      _appDBContext.SaveChanges();

      return RecordToupdate;
    }
  }
}
