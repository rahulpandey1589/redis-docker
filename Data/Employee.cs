namespace redis_docker.Data;

public class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;

    public string Gender { get; set; } = default!;

    public int Age { get; set; }
}