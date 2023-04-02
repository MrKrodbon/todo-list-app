﻿namespace ToDoList.Models.Requests;

public class ToDoUpdateRequestModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsDone { get; set; }
}
