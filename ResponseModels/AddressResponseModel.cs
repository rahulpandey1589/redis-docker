namespace redis_docker.ResponseModels;

public class AddressResponseModel
{
    public int Id { get; set; }
    
    public string City { get; set; } = default!;

    public string State { get; set; } = default!;

    public string Country { get; set; } = default!;
}