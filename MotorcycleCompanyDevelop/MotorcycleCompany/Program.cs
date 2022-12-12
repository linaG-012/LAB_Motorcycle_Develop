using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using MotorcycleCompany.Extensions;
using NLog;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));


        builder.Services.ConfigureCors();
        builder.Services.configureIISIntegration();
        builder.Services.ConfigureRepositoryManager();
        builder.Services.ConfigureServiceManager();
        builder.Services.Configuremysqlcontext(builder.Configuration);
        builder.Services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly)
            .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        builder.Services.AddAutoMapper(typeof(Program));

        //Learn more about configuring Swagger/openAPI at https://aka.ms/aspnetcore/swashbuckle
        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        var logger = app.Services.GetRequiredService<IloggerManager>();
        app.ConfigureExceptionHandler(logger);
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHsts();

        }


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
    }
}