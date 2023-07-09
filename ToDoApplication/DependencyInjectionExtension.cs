using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDoInfrastructure.Repositories;
using ToDoRepository.Interfaces;

namespace ToDoApplication
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            #region Service



            #endregion

            #region Repository
            services.AddScoped<ITarefaRepository, TarefaRepository>();

            #endregion

            #region Validators


            #endregion

            return services;
        }

    }
}
