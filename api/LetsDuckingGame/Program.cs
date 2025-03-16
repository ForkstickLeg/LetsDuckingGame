using Hangfire;
using Hangfire.PostgreSql;
using DotNetEnv;

Env.Load();

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();

// Retrieve the connection string from environment variables
var connectionString = builder.Configuration.GetConnectionString("HangfireConnection") 
                       ?? Environment.GetEnvironmentVariable("HangfireConnection");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Hangfire connection string is not set in environment variables.");
}

// Configure Hangfire services with the PostgreSQL storage API
builder.Services.AddHangfire(config =>
{
    config.UsePostgreSqlStorage(options =>
    {
        options.UseNpgsqlConnection(connectionString);
    });
});
builder.Services.AddHangfireServer();
builder.Services.AddControllers();
builder.Services.AddAuthorization();

// Adding Swagger generation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Use Hangfire dashboard
app.UseHangfireDashboard("/hangfire");

// Map controllers
app.MapControllers();

app.Run();
