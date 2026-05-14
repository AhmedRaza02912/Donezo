using System.ComponentModel.DataAnnotations;

namespace Donezo.Web.Models;

public class TaskItem
{
    public int Id{get;set;}

    [Required]
    [MaxLength(100)]
    public string Title {get;set;} = string.Empty;

    public string? Description{get;set;}

    public bool isCompleted{get;set;} = false;

    public DateTime CreatedAt {get;set;} = DateTime.UtcNow;

    public int ProjectId {get;set;} // Foreign Key

    public Project? Project {get;set;}


}