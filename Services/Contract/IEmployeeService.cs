using redis_docker.ResponseModels;

namespace redis_docker.Services.Contract;

public interface IEmployeeService
{
    Task<List<EmployeeResponseModel>> GetAllEmployeesAsync();
}