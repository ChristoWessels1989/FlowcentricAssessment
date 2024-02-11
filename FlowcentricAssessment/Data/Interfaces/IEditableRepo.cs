using static FlowcentricAssessment.Data.Interfaces.IReadOnlyRepo;

namespace FlowcentricAssessment.Data.Interfaces
{
  public interface IEditableRepo<T> : IReadOnlyRepo<T>
  {
    T CreateRecord(T obj);
    bool DeleteRecord(object KeyValue);
    abstract T updateRecord(T obj);
    bool SaveChanges();

  }
}
