using BLL.Interfaces;
using BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection
            services)
        {
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IPointService, PointService>();
            return services;
        }
    }
}
