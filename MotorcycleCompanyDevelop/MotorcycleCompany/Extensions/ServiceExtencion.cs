using Contracts;
using Microsoft.EntityFrameworkCore;
using MotorcycleCompany.ContextFactory;
using Repository;
using Service;
using Service.Contract;

namespace MotorcycleCompany.Extensions
{
    public static class ServiceExtencion
    {
        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(Options =>
        {
            Options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                );
        });

        public static void configureIISIntegratio(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
        //public static void ConfigureLoggerService(this IServiceCollection services) =>
        // service.AddSingleton<ILoggerManager, LoggerManager();
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();

        public static void Configuremysqlcontext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(opts => opts.UseMySql(configuration.GetConnectionString("sqlConnection"), new MySqlServerVersion(new Version(8, 0, 30))));
    }
}
