using Microsoft.AspNetCore.Authentication.Cookies;

namespace NextFurniture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Login";  // Login sayfasý
        options.AccessDeniedPath = "/Login/Login";
        options.LogoutPath = "/Login/Logout"; // Logout iþlemi
        options.ExpireTimeSpan = TimeSpan.FromMinutes(2); // Cookie'nin geçerlilik süresi
    });

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

            app.UseAuthentication();  // Kimlik doðrulama middleware
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}");

            app.Run();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();  // Session'lar için sunucu belleði kullanýmý
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20); // Session'ýn sona erme süresi
                options.Cookie.HttpOnly = true;                // Çerezlerin sadece HTTP üzerinden eriþilebilir olmasý
            });

            services.AddControllersWithViews();
        }

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();  // Kimlik doğrulama middleware
			app.UseAuthorization();   // Yetkilendirme middleware

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Login}/{action=Login}/{id?}");
			});
		}

	}
}