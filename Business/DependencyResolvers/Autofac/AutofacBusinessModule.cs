using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Security.Jwt;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {         
            builder.RegisterType<BrandManager>().As< IBrandService > ();
            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<ColorManager >().As<IColorService>();
            builder.RegisterType<CarMaintenanceManager  >().As<ICarMaintenanceService>();
            builder.RegisterType<IndividualCustomerManager>().As<IIndividualCustomerService > ();
            builder.RegisterType<CorporateCustomerManager >().As<ICorporateCustomerService>();
            builder.RegisterType<AuthManager>().As<IAuthService > ();
            builder.RegisterType<UserManager > ().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal> ();
            builder.RegisterType<EfUserOperationClaimDal  >().As<IUserOperationClaimDal>();
            builder.RegisterType<EfClaimDal>().As<IClaimDal>();
            builder.RegisterType<ClaimManager > ().As<IClaimService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper > ();
            builder.RegisterType<EfBrandDal>().As<IBrandDal > ();
            builder.RegisterType<EfColorDal > ().As<IColorDal>();
            builder.RegisterType<EfCarDal>().As<ICarDal > ();
            builder.RegisterType<EfCarMaintenanceDal > ().As<ICarMaintenanceDal>();
            builder.RegisterType<EfIndividualCustomerDal>().As<IIndividualCustomerDal>();
            builder.RegisterType<EfCorporateCustomerDal  >().As<ICorporateCustomerDal>();
            builder.RegisterType<EfUserOperationsDal  >().As<IUserOperationDal>();
            builder.RegisterType<UserOperationManager  >().As<IUserOperationService>();
           
            builder.RegisterType<CarBusinessRules>();
            builder.RegisterType<ColorBusinessRules>();
            builder.RegisterType<BrandBusinessRules>();
            builder.RegisterType<CarMaintenanceBusinessRules>();
            builder.RegisterType<IndividualCustomerBusinessRules>();
            builder.RegisterType<CorporateCustomerBusinessRules>();
            builder.RegisterType<UserBusinessRules>();
            builder.RegisterType<ClaimBusinessRules>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new Core.Utilities.Interseptions.AspectInterceptorSelector()
                }).SingleInstance();
        }



    }
}
