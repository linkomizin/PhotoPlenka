namespace PhotoPlenka.Services.ProductAPI.DbContexts.Models.Dtos;

public class ResponseDto
{
    public bool IsSuccess { get; set; } = true;
    public object Reuslt { get; set; }
    public string DisplayMessage { get; set; }
    public List<string> ErrorMessages { get; set; }   
}