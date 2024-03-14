namespace apiemojis
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy", builder =>
                {
                    // Replace with trusted client origins (can be IPs or domains)
                    builder.WithOrigins("http://localhost:4200", "http://localhost:7037", "http://localhost:5265");

                    // Optionally restrict allowed methods, headers, etc.
                    builder.WithMethods("GET");
                    builder.WithHeaders("Content-Type", "Authorization");
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseRouting();
            app.UseCors("MyPolicy"); // Reference the same CORS policy
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
