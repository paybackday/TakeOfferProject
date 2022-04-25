using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Concrete.EntityFramework.Context;
using Project.SERVICES.Abstract;
using Project.SERVICES.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.SERVICES.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection) 
        {
            serviceCollection.AddDbContext<MyContext>();
            serviceCollection.AddScoped<IAppUserService,AppUserManager>();
            serviceCollection.AddScoped<IAppUserProfileService, AppUserProfileManager>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            serviceCollection.AddScoped<IEventCommentService, EventCommentManager>();
            serviceCollection.AddScoped<IEventService, EventManager>();

            //Automapper configurations will come here.

            return serviceCollection;
        }
    }
}
