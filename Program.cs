var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestAPI);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
