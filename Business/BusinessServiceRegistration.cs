using Business.Abstracts;
using Business.BusinessRules;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public  static  class BusinessServiceRegistration
    {


        public static IServiceCollection  AddBusinessServices(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<ICarService, CarManager>();
            services.AddSingleton<IColorService, ColorManager>();
            services.AddSingleton<ICarMaintenanceService,CarMaintenanceManager>();
            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IColorDal, EfColorDal>();
            services.AddSingleton<ICarDal, EfCarDal>();
            services.AddSingleton<ICarMaintenanceDal, EfCarMaintenanceDal>();
            services.AddSingleton<CarBusinessRules>();
            services.AddSingleton<ColorBusinessRules>();
            services.AddSingleton<BrandBusinessRules>();
            services.AddSingleton<CarMaintenanceBusinessRules>();
     
            return services;
        }
    }
}
