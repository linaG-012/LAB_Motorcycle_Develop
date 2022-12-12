using Microsoft.AspNetCore.HttpOverrides;
using MotorcycleCompany.Extensions;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureCors();
builder.Services.configureIISIntegration();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.Configuremysqlcontext(builder.Configuration);
builder.Services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly)
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler= ReferenceHandler.IgnoreCycles);


//Learn more about configuring swagger/openAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseHsts();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hola desde el middleware personalizado");

//app.Use(async (context, next) =>
//{
//    Console.WriteLine($"Hola desde el middleware personalizado");
//    await next.Invoke();
//    Console.WriteLine($"Hola desde el middleware personalizado");
//});

app.MapControllers();

app.Run();
