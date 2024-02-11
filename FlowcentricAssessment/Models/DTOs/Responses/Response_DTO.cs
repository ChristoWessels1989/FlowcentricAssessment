namespace FlowcentricAssessment.Models.DTOs.Responses
{
  public class Response_DTO
  {
    public object? Result { get; set; }
    public bool IsSuccess { get; set; } = true;
    public string Message { get; set; } = "";
  }
}
