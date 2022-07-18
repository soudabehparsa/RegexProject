using ConsoleAppFramework;
using RegexProject;
using RegexProject.Command;

var builder = ConsoleApp.CreateBuilder(args);

builder.ConfigureServices((services) =>
{
    services.AddConfig();
});

var app = builder.Build();

app.AddCommands<ScanCommand>();

app.RunAsync();