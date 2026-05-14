
using Donezo.Web.Data;
using Donezo.Web.Models;
using Donezo.Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Donezo.Web.Services;

public class ProjectService : IProjectService
{
    private readonly AppDbContext _context;

    public  ProjectService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Project>> GetAllAsync()
    {
        return await _context.Projects
        .Include( p => p.Tasks)
        .ToListAsync();
    }
    public async Task<Project?> GetByIdAsync(int id)
    {
        return await _context.Projects
        .Include(p => p.Tasks)
        .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task CreatedAsync(Project project)
    {
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Project project)
    {
        _context.Projects.Update(project);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project != null)
        {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
        }
    }


}
