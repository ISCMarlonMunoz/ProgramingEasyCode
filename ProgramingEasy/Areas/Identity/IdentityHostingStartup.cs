using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProgramingEasy.Areas.Identity.Data;
using ProgramingEasy.Data;

[assembly: HostingStartup(typeof(ProgramingEasy.Areas.Identity.IdentityHostingStartup))]
namespace ProgramingEasy.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProgramingEasyContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProgramingEasyContextConnection")));

                services.AddDefaultIdentity<ProgramingEasyUser>()
                    .AddEntityFrameworkStores<ProgramingEasyContext>();
            });
        }
    }
}