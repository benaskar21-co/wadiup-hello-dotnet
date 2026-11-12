// No Dockerfile: Wadiup detects Hello.csproj, publishes it and sets ASPNETCORE_URLS from PORT.
var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/", () => $"Hello from Wadiup · .NET {Environment.Version} · {Environment.MachineName}\n");
app.Run();
