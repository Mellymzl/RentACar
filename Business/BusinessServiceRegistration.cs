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
            services.AddSingleton<IIndividualCustomerService, IndividualCustomerManager>();
            services.AddSingleton<ICorporateCustomerService, CorporateCustomerManager>();
          
            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IColorDal, EfColorDal>();
            services.AddSingleton<ICarDal, EfCarDal>();
            services.AddSingleton<ICarMaintenanceDal, EfCarMaintenanceDal>();
            services.AddSingleton< IIndividualCustomerDal, EfIndividualCustomerDal> ();
            services.AddSingleton<ICorporateCustomerDal, EfCorporateCustomerDal> ();
            services.AddSingleton<CarBusinessRules>();
            services.AddSingleton<ColorBusinessRules>();
            services.AddSingleton<BrandBusinessRules>();
            services.AddSingleton<CarMaintenanceBusinessRules>();
            services.AddSingleton<IndividualCustomerBusinessRules>();
            services.AddSingleton<CorporateCustomerBusinessRules>();
     
            return services;
        }
    }
}
