using Donezo.Web.Models;

namespace Donezo.Web.Services.Interfaces;

public interface IProjectService
{
    Task<List<Project>> GetAllAsync();
    Task<Project?> GetByIdAsync(int id);
    Task CreatedAsync(Project project);
    Task UpdateAsync(Project project);
    Task DeleteAsync(int id);

}