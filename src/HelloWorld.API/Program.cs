using HelloWorld.API.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IEmployeeSalaryService, EmployeeSalaryService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
