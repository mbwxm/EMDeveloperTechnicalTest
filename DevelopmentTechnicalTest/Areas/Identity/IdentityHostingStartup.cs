using System;
using DevelopmentTechnicalTestFrontEnd.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DevelopmentTechnicalTestFrontEnd.Areas.Identity.IdentityHostingStartup))]
namespace DevelopmentTechnicalTestFrontEnd.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LoginDBContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("LoginDBContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<LoginDBContext>();
            });
        }
    }
}