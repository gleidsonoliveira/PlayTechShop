using PlayTechShop.CrossCutting.DependencyInjection.DbConfig;
using PlayTechShop.CrossCutting.DependencyInjection.Repository.;
using PlayTechShop.CrossCutting.DependencyInjection.Validation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Ioc
builder.Services.AddSqlServerDependency(builder.Configuration);
builder.Services.AddSqlRepositorydependency();
builder.Services.AddServiceDependency();
builder.Services.AddMapperConfiguration();
builder.Services.AddValidators();

#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
