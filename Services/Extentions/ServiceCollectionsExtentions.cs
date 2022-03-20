using Data.Abstract;
using Data.Concrete;
using Data.Concrete.EntityFramework.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Extentions
{
    public static class ServiceCollectionsExtentions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BlogContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;
        }
    }
}
