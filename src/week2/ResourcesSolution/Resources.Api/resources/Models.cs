using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Resources.Api.resources;

public record ResourceListItemModel
{
    public Guid ID { get; set; }
    public string Title { get; set; } = string.Empty;


    public string Description { get; set; } = string.Empty ;

    public string Link {  get; set; } = string.Empty ;

    public string CreatedBy { get; set; } = string.Empty;

    public DateTimeOffset CreatedOn {  get; set; }

    public List<string> Tags { get; set; } = new();
}

public class ResourceListItemCreateModel
{
    
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public string LinkText { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
}
public class ResourceListItemCreateModelValidations : AbstractValidator<ResourceListItemCreateModel>
{
    public ResourceListItemCreateModelValidations()
    {
        RuleFor(m => m.Title).NotEmpty().MinimumLength(3).MaximumLength(100);
        RuleFor(m => m.Link).NotEmpty();
        RuleFor(m => m.LinkText).NotEmpty().MinimumLength(3).MaximumLength(10);
    }
}
