using BusinessLayer.Services;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Helpers
{
    public static class CustomExtensions
    {
       public static void AddDIRepositories(this IServiceCollection services )
        {
            services.AddTransient<IBiochemicalExaminationRepository, BiochemicalExaminationRepository>();
            services.AddTransient<IBloodExaminationRepository, BloodExaminationRepository>();
            services.AddTransient<IVisitRepository, VisitRepository>();
            services.AddTransient<IUserManagementRepository, UserManagementRepository>();

        }

        public static void AddDIServices(this IServiceCollection services)
        {
            services.AddTransient<IBiochemicalExaminationService, BiochemicalExaminationService>();
            services.AddTransient<IBloodExaminationService, BloodExaminationService>();
        }
    }
}
