using Hangfire;
using Hangfire.PostgreSql;
using DotNetEnv;

Env.Load();

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();

// Retrieve the connection string from environment variables
var connectionString = builder.Configuration.GetConnectionString("HANGFIRE_CONNECTION")
                       ?? Environment.GetEnvironmentVariable("HANGFIRE_CONNECTION");

Console.WriteLine($"Hangfire connection string: {connectionString}");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Hangfire connection string is not set in environment variables.");
}

// Add services to the container.

builder.Services.AddHangfire(config =>
{
    config.UsePostgreSqlStorage(options =>
    {
        options.UseNpgsqlConnection(connectionString);
    });
});
builder.Services.AddHangfireServer();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHangfireDashboard("/hangfire");

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
