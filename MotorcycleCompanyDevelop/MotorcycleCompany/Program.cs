using Contracts;
using Microsoft.AspNetCore.HttpOverrides;
using MotorcycleCompany.Extensions;
using NLog;
using System.Text.Json.Serialization;




    
        var builder = WebApplication.CreateBuilder(args);

         // Add services to the container.
        LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));


        builder.Services.ConfigureCors();
        builder.Services.configureIISIntegration();
        
        builder.Services.ConfigureLoggerService();
        //Add service to the container.
        
        builder.Services.ConfigureRepositoryManager();
        builder.Services.ConfigureServiceManager();
        builder.Services.Configuremysqlcontext(builder.Configuration);
        builder.Services.AddControllers()
            .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly)
            .AddJsonOptions(x =>
                     x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

        builder.Services.AddAutoMapper(typeof(Program));
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        var logger = app.Services.GetRequiredService<IloggerManager>();
       // app.ConfigureExceptionHandler(logger);
        

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHsts();

        }

// Configure the HTTP request pipeline.

        app.UseAuthorization();

        app.UseHttpsRedirection();


        app.MapControllers();

        app.Run();
    
