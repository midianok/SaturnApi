using Saturn.Api.Extensions;
using Saturn.Application;
using Saturn.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Register();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Wow>());

builder.Services.AddSaturnContext(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.ApplyMigrations();
app.Run();