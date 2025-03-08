using ScaffNet.Utils;
using ScaffNetAPI.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        var services = builder.Services;

        services.AddControllers();

        services.AddHealthChecks();
        services.AddSwaggerGen();

        services.AddScoped<ScaffEventHandler>();

        var config = builder.Configuration;
        var allowedOrigins = config.GetSection("AllowedOrigins").Get<string[]>();
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", policy =>
                policy.WithOrigins(allowedOrigins)
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      .AllowCredentials());
        });

        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
            .AddConfiguration(config.GetSection("Logging"))
            .AddConsole();
        });

        var logger = loggerFactory.CreateLogger<Program>();

        var eventHandler = services.BuildServiceProvider().GetService<ScaffEventHandler>();
        ScaffUtils.SetEventHandler(eventHandler);

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHealthChecks("/health");

        app.UseHttpsRedirection();

        app.UseCors("CorsPolicy");

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}