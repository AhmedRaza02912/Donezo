using System.ComponentModel.DataAnnotations;
namespace Donezo.Web.Models;

public class Project
{
    public int Id{get;set;}

    [Required]
    [MaxLength(100)]
    public string Name {get;set;} = string.Empty;

    [MaxLength(100)]
    public string? Description{get;set;}

    public DateTime CreatedAt{get;set;} = DateTime.UtcNow;

    public List<TaskItem> Tasks{get;set;} = new();
}