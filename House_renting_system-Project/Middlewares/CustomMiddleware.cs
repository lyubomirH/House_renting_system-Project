using House_renting_system_Project.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace House_renting_system_Project.Middlewares
{
    public class CustomMiddleware
    {
        private RequestDelegate next;
        public CustomMiddleware(RequestDelegate next) 
        { 
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext, HouseRentingDbContext ctx, IConfiguration config) //IConfiguration
        {
            var housesCount = await ctx.Houses.CountAsync();
            Console.WriteLine();
            await this.next(httpContext);
        }
    }
}
