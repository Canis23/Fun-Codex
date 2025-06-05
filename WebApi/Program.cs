using WebApi.Middleware;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<WebApi.Services.IHelloService, WebApi.Services.HelloService>();
builder.Services.AddScoped<WebApi.Services.IWeatherForecastService, WebApi.Services.WeatherForecastService>();

// required for JWT configuration in middleware
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// custom middleware to validate JWT tokens
app.UseJwtValidation();

app.MapControllers();

app.Run();
