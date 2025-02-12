

using Alba;
using Todos.Api.Todos;

namespace Todos.Tests.Todos;
public class GettingTodos
{

    [Fact]
    public async Task GetsAOkStatusCode()
    {
        var host =  await AlbaHost.For<Program>();
        //a bit of time between these 2
        await host.Scenario(api =>
        {
            api.Get.Url("/todos");
            api.StatusCodeShouldBeOk(); //200
        });

     
    }

    [Fact]
    public async Task CanAddAnItemToTodoList()
    {
        var host = await AlbaHost.For<Program>();
        var itemToAdd = new TodoListCreateItem
        {
            Description = "Make Tacos " + Guid.NewGuid(),
        };
        await host.Scenario(api =>
        {
            api.Post.Json(itemToAdd).ToUrl("/todos");
            api.StatusCodeShouldBeOk();
        });

        var getResponse = await host.Scenario(api =>
        {
            api.Get.Url("/todos");
        });

        var listofTodos = getResponse.ReadAsJson<List<TodoListItem>>(); // ? mark when hovering ovr listoftodos means it might get nothing back- might come back null

        Assert.NotNull(listofTodos);

        //var hasMyItem =listofTodos.Any(item => item.Description == itemToAdd.Description);
        //fewer elements 
        bool found = false;

        foreach (TodoListItem v in listofTodos)
        {
            if (v.Description == itemToAdd.Description)
            {
                found = true;
                break;
            }
        }

        Assert.True(found);
    }
}
