//Serve.Run(RunOptions.Default);
var builder = WebApplication.CreateBuilder(args).Inject();

builder.Services.AddControllers().AddInject();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseInject();

app.MapControllers();

app.Run();