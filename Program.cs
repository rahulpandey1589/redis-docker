using Microsoft.AspNetCore.HttpOverrides;
using redis_docker.Data;
using redis_docker.Utils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();



var connectionstring =
    builder.Configuration.GetConnectionString("DatabaseConnection") ??
    Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");


builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
    {
        options.UseSqlServer(connectionstring);
    });

builder
    .Services
    .RegisterServices()
    .RegisterDbServices();


var app = builder.Build();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

/*
 Uncomment this if we want to have seed in memory data
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    DbInitializer.Seed(context);
}
*/

app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

app.UseHttpsRedirection();

app.Run();