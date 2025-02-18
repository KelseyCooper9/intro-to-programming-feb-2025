using Microsoft.AspNetCore.Mvc;

namespace Resources.Api.resources;
//get a 200 OK 
public class Api: ControllerBase
{
    [HttpGet("/resources")]

    public async Task<ActionResult> GetAllResources()
    {

        var fakeData = new List<ResourceListItemModel>()
        {
            new ResourceListItemModel()
            {
                ID = Guid.NewGuid(),
                Title = "Title",
                Description = "Description",
                CreatedBy = "me",
                CreatedOn = DateTime.Now,
                Link = "www.google.com",
                Tags = [".net"]
            }
        };
        return this.Ok();
    }
}
