using MicroRabbit.Infra.IoC;

namespace MicroRabbit.Transfer.Api.Extentions
{
    
        public static class MiddlewareExtention
        {
            public static void RegisterServices(this IServiceCollection services)
            {

                DependencyContainer.RegisterServices(services);
            }
        }
}
