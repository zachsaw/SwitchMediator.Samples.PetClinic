using System.Reflection;
using AutoMapper;
using FluentValidation;
using Intent.RoslynWeaver.Attributes;
using Mediator.Switch;
using Mediator.Switch.Extensions.Microsoft.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetClinic.Application.Common.Behaviours;
using PetClinic.Application.Common.Validation;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.DependencyInjection.DependencyInjection", Version = "1.0")]

namespace PetClinic.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly(), lifetime: ServiceLifetime.Transient);
            services.AddMediator<SwitchMediator>(cfg =>
            {
                cfg.KnownTypes = SwitchMediator.KnownTypes;
            });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IValidatorProvider, ValidatorProvider>();
            return services;
        }
    }
}