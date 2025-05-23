using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

using SignalRClass.Application.Identity;
using SignalRClass.Infrastructure;

namespace SignalRClass.DI
{
    public static  class IdentityServices
    {

        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppIdentityContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("IdentityConnection")));

            services.AddAuthorization();

            services.AddIdentity<AppUser, IdentityRole>(opt => {
            })
            .AddEntityFrameworkStores<AppIdentityContext>()
            .AddDefaultTokenProviders();

            services.AddSingleton<IEmailSender, DefaultEmailSender>();

            return services;
        }
    }
}
