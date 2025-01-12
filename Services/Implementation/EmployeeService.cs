using redis_docker.ResponseModels;
using redis_docker.Services.Contract;
using redis_docker.Data.Repository.Contract;
using redis_docker.Services.Extensions;

namespace redis_docker.Services.Implementation;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<List<EmployeeResponseModel>> GetAllEmployeesAsync()
    {
        var data = await _employeeRepository.GetEmployeesAsync();
        return data.ConvertToEmployeeResponseModel();
    }
}