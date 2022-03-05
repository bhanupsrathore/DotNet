var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc(); //enable gRPC support

var app = builder.Build();
app.MapGrpcService<Shopping.OrderManagerService>(); //pass request to gRPC service
app.Run();
