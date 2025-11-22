using JornadaTrabalhoApi.Data;
using JornadaTrabalhoApi.Services;
using JornadaTrabalhoApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<JornadaContext>(options =>
    options.UseNpgsql("Host=db.vjnpannrribdfoxewiyd.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=hxdtoWLuReZzlRlQ"));

builder.Services.AddScoped<IPausaService, PausaService>();
builder.Services.AddScoped<IHumorService, HumorService>();
builder.Services.AddScoped<IFocoService, FocoService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
