using Microsoft.EntityFrameworkCore;
using PayrollApi.Data;

var builder = WebApplication.CreateBuilder(args);

// MySQL connection
var connectionString = "server=localhost;database=payroll_system;user=root;password=;";

builder.Services.AddDbContext<PayrollContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();
app.Run();
