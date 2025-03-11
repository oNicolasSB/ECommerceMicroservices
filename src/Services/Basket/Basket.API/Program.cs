var builder = WebApplication.CreateBuilder(args);

// add services to container

var app = builder.Build();

// configure http pipeline

app.Run();
