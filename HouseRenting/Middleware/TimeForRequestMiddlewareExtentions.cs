namespace HouseRenting.Middleware
{
    public static class TimeForRequestMiddlewareExtensions
    {
        public static IApplicationBuilder UseTimer
            (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeForRequestMiddleware>();
        }
    }
}
