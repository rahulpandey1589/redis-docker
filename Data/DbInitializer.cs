using Microsoft.EntityFrameworkCore;

namespace redis_docker.Data;

public static class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Employees.Any())
        {
            context.Employees.AddRange(
                new Employee
                {
                    Id = 1, FirstName = "Johny", LastName = "Bravo",Age = 24, Gender = "Male"
                },
                new Employee
                {
                    Id = 2, FirstName = "Mark", LastName = "Bravo",Age = 24, Gender = "Male"
                }
            );
            context.SaveChanges();
        }
    }
    
}