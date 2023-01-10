using JSONApiApp.Controlles;
using JSONApiApp.Message;
using JSONApiApp.Service;

var builder = WebApplication.CreateBuilder(args);

//Добавление сервисов
builder.Services.AddSingleton<ServiceConvertDistance>();
builder.Services.AddSingleton<ServiceKnowHost>();
builder.Services.AddSingleton<ServiceMyRequest>();
//Контролеры
builder.Services.AddSingleton<MainController>();
builder.Services.AddSingleton<ControllerConvertDistance>();

var app = builder.Build();

app.UseMiddleware<RequestMiddleware>();

//Обработчики
app.MapGet("/ping", () => "pong");

app.MapGet("/status", app.Services.GetService<MainController>().Status);
app.MapGet("/info", app.Services.GetService<MainController>().Info);
app.MapPost("convert", app.Services.GetService<ControllerConvertDistance>().ConvertNumber);
app.MapPost("known-host",app.Services.GetService<MainController>().KnownHost);
app.MapPost("host-request", app.Services.GetService<MainController>().HostRequest);

app.Run();
