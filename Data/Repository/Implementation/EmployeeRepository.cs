using Microsoft.EntityFrameworkCore;
using redis_docker.Data.Repository.Contract;

namespace redis_docker.Data.Repository.Implementation;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public EmployeeRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Employee>> GetEmployeesAsync()
    {
        var employees = await _dbContext.Employees.ToListAsync();
        return employees;
    }
}