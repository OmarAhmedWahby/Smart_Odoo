using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Smart_Odoo.Models;
using Smart_Odoo.Repository;
using Smart_Odoo.Service;

namespace Smart_Odoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(
            builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddMemoryCache();

            builder.Services
            .AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            builder.Services.AddScoped<DbConnectionFactory>();
            builder.Services.AddScoped<IDashboardSalesRepository, DashboardSalesRepository>();
            builder.Services.AddScoped<IDashboardSalesService, DashboardSalesService>();
            builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            builder.Services.AddScoped<IPurchaseService, PurchaseService>();
            builder.Services.AddScoped<IHrRepository, HrRepository>();
            builder.Services.AddScoped<IHrService, HrService>();
            builder.Services.AddScoped<IInventoryRepository, InventoryRepository>();
            builder.Services.AddScoped<IInventoryService, InventoryService>();
            builder.Services.AddScoped<ICrmRepository, CrmRepository>();
            builder.Services.AddScoped<ICrmService, CrmService>();
            builder.Services.AddScoped<IMlRepository, MlRepository>();
            builder.Services.AddScoped<IMlService, MlService>();
            builder.Services.AddHttpClient();
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

