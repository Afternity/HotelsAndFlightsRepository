using HotelsAndFlights.Persistence.Data;
using HotelsAndFlights.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistance(builder.Configuration);

var app = builder.Build();

app.Run();
