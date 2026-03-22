using GameStore.api.Dtos;
using GameStore.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();  

var app = builder.Build(); 

app.MapGamesEndpoints();
app.Run();  
