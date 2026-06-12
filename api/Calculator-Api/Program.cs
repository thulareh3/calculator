using Calculator_Api.Interfaces;
using Calculator_Api.Services;

var builder = WebApplication.CreateSlimBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularPolicy", policy =>
    {
        policy.WithOrigins(
            "http://localhost:4200",
            "https://localhost:4200"
            ).AllowAnyHeader()
            .AllowAnyMethod();
    });
});
builder.Services.AddScoped<ICalculatorService, CalculatorService>();
builder.Services.AddSingleton<ICalculatorMemory, CalculatorMemoryService>();
builder.Services.AddSingleton<ICalculatorHistory, CalculatorHistoryService>();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("AngularPolicy");
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    { 
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Calculator API V1");
    });
}

app.UseAuthorization();
app.MapControllers();

app.Run();

