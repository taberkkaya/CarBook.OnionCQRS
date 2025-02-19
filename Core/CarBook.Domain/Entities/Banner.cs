﻿namespace CarBook.Domain.Entities;

public class Banner : EntityBase
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string VideoDescription { get; set; }
    public string VideoUrl { get; set; }
}
