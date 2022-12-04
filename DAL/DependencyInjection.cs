using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabase(this IServiceCollection
            services)
        {
            services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase(databaseName: "InMemoryDb"));
            return services;
        }
    }
}
