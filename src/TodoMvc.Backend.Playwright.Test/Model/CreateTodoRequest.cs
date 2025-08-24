using Lombok.NET;

namespace TodoMvc.Backend.Playwright.Test.Model;

[With]
public partial class CreateTodoRequest
{
    [Property] private int _order;
    [Property] private string _title;
}
