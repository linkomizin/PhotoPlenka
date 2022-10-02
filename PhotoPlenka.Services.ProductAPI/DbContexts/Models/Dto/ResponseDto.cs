namespace PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dto;

public class ResponseDto
{
    public bool IsSuccess { get; set; } = true;
    public object Reuslt { get; set; }
    public string DisplayMessage { get; set; }
    public List<string> ErrorMessages { get; set; }   
}