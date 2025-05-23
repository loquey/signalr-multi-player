namespace SignalRClass.DI
{
    public static class SignalRServices
    {
        public static IServiceCollection AddSignalRServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSignalR();

            return services;
        }
    }
}
