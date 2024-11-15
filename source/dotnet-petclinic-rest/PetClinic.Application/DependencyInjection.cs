using System.Reflection;
using AutoMapper;
using FluentValidation;
using Intent.RoslynWeaver.Attributes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetClinic.Application.Implementation;
using PetClinic.Application.Interfaces;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.DependencyInjection.DependencyInjection", Version = "1.0")]

namespace PetClinic.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<IValidationService, ValidationService>();
            services.AddTransient<IOwnerService, OwnerService>();
            services.AddTransient<IPetService, PetService>();
            services.AddTransient<IPetTypeService, PetTypeService>();
            services.AddTransient<ISpecialtyService, SpecialtyService>();
            services.AddTransient<IVetService, VetService>();
            services.AddTransient<IVisitService, VisitService>();
            return services;
        }
    }
}