using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
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

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<ICarService, CarManager>();
            services.AddSingleton<IColorService, ColorManager>();
            services.AddSingleton<IBrandDal, EfBrandDal>();
            services.AddSingleton<IColorDal, EfColorDal>();
            services.AddSingleton<ICarDal, EfCarDal>();
            return services;
        }
    }
}
