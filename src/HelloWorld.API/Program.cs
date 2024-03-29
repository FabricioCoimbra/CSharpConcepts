using HelloWorld.API.Service;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IEmployeeSalaryService, EmployeeSalaryService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Simple API",
        Description = "Repository of concepts basics and advance from my life experience."
    });

    foreach (var filePath in Directory.GetFiles(AppContext.BaseDirectory, "*.xml"))
    {
        if (File.Exists(filePath))
            c.IncludeXmlComments(filePath);
    }    
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
