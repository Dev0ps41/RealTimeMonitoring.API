using Microsoft.EntityFrameworkCore;
using RealTimeMonitoring.API.Data;
using RealTimeMonitoring.API.Hubs;

var builder = WebApplication.CreateBuilder(args);

//  Add Swagger Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddSignalR();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

//  Enable Swagger Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.MapHub<ProductionHub>("/productionHub");

app.Run();
