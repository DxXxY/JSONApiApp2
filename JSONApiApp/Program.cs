using JSONApiApp.Controlles;
using JSONApiApp.Message;
using JSONApiApp.Service;

var builder = WebApplication.CreateBuilder(args);

//���������� ��������
builder.Services.AddSingleton<ServiceConvertDistance>();
//����������
builder.Services.AddSingleton<MainController>();
builder.Services.AddSingleton<ControllerConvertDistance>();

var app = builder.Build();

//�����������
app.MapGet("/ping", () => "pong");

app.MapGet("/status", app.Services.GetService<MainController>().Status);
app.MapGet("/info", app.Services.GetService<MainController>().Info);
app.MapPost("convert", app.Services.GetService<ControllerConvertDistance>().ConvertNumber);

app.Run();
