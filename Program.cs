using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ProvaBlue.Business;
using ProvaBlue.Business.Implementations;
using ProvaBlue.Db;
using ProvaBlue.Extensions;
using ProvaBlue.Models;
using ProvaBlue.Repository.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region swagger t�picos
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1",
        new OpenApiInfo {
            Title = "Desafio pr�tico BLUE",
            Version = "v1",
            Description = "API referente ao teste pr�tico da BLUE :-)",
            Contact = new OpenApiContact {
                Name = "Felipe Valen�a",
                Url = new Uri("https://github.com/FelipeeSaM/ProvaBlue")
            }
        }
    );
});
#endregion

builder.Services.AddTransient<ErrorHandlerExtension>();

var connection = builder.Configuration.GetConnectionString("MSSQLConnection:MSSQLConnectionString");
builder.Services.AddDbContext<Prova_db_context>(options => options.UseSqlServer(connection));
builder.Services.AddScoped<IContatoBusiness, ContatoBusinessImplementations>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddApiVersioning();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if(app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

#region swagger configs
app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "swagger endpointsd");
});
var option = new RewriteOptions();
option.AddRedirect("^$", "swagger");
app.UseRewriter(option);
app.UseAuthentication();
#endregion

app.UseAuthorization();
app.UseMiddleware<ErrorHandlerExtension>();

app.MapControllers();

app.Run();
