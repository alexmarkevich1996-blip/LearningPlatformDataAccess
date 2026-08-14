using stepik.Services.ADO.NET;

namespace stepik_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            builder.Services.AddTransient<stepik.Services.EF.UsersService>();
            builder.Services.AddTransient<CommentsService>();
            builder.Services.AddTransient<CoursesService>();
            builder.Services.AddTransient<CertificatesService>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint(
                        "/openapi/v1.json",
                        "Swagger Test API v1");
                });
            }

            //app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
