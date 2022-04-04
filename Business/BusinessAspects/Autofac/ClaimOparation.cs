using AutoMapper;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Extensions;
using Core.Utilities.Interseptions;
using Core.Utilities.IoC;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessAspects.Autofac
{
    public class ClaimOparation: MethodInterception
    {

        string _operationName;
        IUserOperationService _userOperationService;

        private IHttpContextAccessor _httpContextAccessor;

        public ClaimOparation(string operationName)
        {
            _operationName = operationName;
           
         
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
            _userOperationService = ServiceTool.ServiceProvider.GetService<IUserOperationService>();
        }

        protected override void OnBefore(IInvocation invocation)
        {

            var x = _httpContextAccessor;
            var id =Convert.ToInt32( _httpContextAccessor.HttpContext.User.GetUserId());
         
            var UserOperation = _userOperationService.GetUserOperations(id);
               
         
                if (UserOperation.Any(w=>w.Operation==_operationName))
                {
                    return;
                }
            

            throw new BusinessException("Yetkiniz yok!");
        }
    }
}
