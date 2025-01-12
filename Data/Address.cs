namespace redis_docker.Data;

public class Address
{
    public int Id{get;set;}
    public string City { get; set; } = default!;

    public string State { get; set; } = default!;

    public string Country { get; set; } = default!;
}