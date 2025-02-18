﻿namespace Resources.Api.resources;

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
