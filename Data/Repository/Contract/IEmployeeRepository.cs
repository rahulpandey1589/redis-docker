namespace redis_docker.Data.Repository.Contract;

public interface IEmployeeRepository
{
    Task<List<Employee>> GetEmployeesAsync();
    
}