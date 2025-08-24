namespace TodoMvc.Backend.Playwright.Test.Model;

public class CreatedTodoResponse : CreateTodoRequest
{
    public string id { get; set; }
    public bool completed { get; set; }
    public string url { get; set; }
}
