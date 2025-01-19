using redis_docker.Data;
using redis_docker.ResponseModels;

namespace redis_docker.Services.Extensions;

public  static class MappingExtensions
{
    public static List<EmployeeResponseModel> ConvertToEmployeeResponseModel(
        this List<Employee> employees)
    {
      return  employees.Select(ConvertToEmployeeResponseModel).ToList();
    }

    private static EmployeeResponseModel ConvertToEmployeeResponseModel(
        this Employee employees)
    {
        return new EmployeeResponseModel()
        {
            Id = employees.Id,
            FirstName = employees.FirstName,
            Age = employees.Age,
            Gender = employees.Gender,
            LastName = employees.LastName,
        };
    }
}