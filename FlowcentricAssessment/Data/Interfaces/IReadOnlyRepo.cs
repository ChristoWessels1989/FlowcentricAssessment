namespace FlowcentricAssessment.Data.Interfaces
{
  public interface IReadOnlyRepo
  {
    public interface IReadOnlyRepo<T>
    {
      IEnumerable<T> GetAllRecords();
      T GetRecordById(object KeyValue);
    }
  }
}
