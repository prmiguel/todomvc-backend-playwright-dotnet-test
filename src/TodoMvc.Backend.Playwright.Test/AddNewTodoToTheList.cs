using System.Text.Json;
using FluentAssertions;
using Microsoft.Playwright;
using TodoMvc.Backend.Playwright.Test.Model;
using TodoMvc.Backend.Playwright.Test.Support;

namespace TodoMvc.Backend.Playwright.Test;

[TestClass]
public class AddNewTodoToTheList : TodoBaseTest
{
    [TestMethod]
    [TestCategory("smoke")]
    [Priority(1)]
    public async Task ShouldBeAddedTheNewItem()
    {
        // Arrange
        var todo = new CreateTodoRequest
        {
            Order = 0,
            Title = "Testing item"
        };

        // Act
        var response = await Request.PostAsync(StaticConfigurationManager.BaseUri, new APIRequestContextOptions
        {
            DataObject = todo
        });

        // Assert
        response.Status.Should().Be(200);
        var responseJsonBody = await response.JsonAsync();
        var createdTodo = responseJsonBody?.Deserialize<CreatedTodoResponse>(new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
        createdTodo?.id.Should().NotBe(null);
        createdTodo?.Title.Should().Be(todo.Title);
        createdTodo?.Order.Should().Be(todo.Order);
        createdTodo?.completed.Should().Be(false);
        createdTodo?.url.Should().NotBe(string.Empty);
    }
}
