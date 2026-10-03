
using Microsoft.EntityFrameworkCore;
using TrinhHoangBach2410900008_exam.Models;

namespace TrinhHoangBach2410900008_exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Kết nối SQL Server
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<HvtStudentDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("ThbStudentConnection")
                ));
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}