using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
