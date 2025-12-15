using Cortex.Mediator.DependencyInjection;
using LetPot.Platform.u202215721.Allocation.Application.ACL.Services;
using LetPot.Platform.u202215721.Allocation.Application.Internal.EventHandlers;
using LetPot.Platform.u202215721.Allocation.Application.Internal.QueryServices;
using LetPot.Platform.u202215721.Allocation.Domain.Repositories;
using LetPot.Platform.u202215721.Allocation.Domain.Services;
using LetPot.Platform.u202215721.Allocation.Infrastructure.Persistence.EFC.Repositories;
using LetPot.Platform.u202215721.Allocation.Interfaces.ACL;
using LetPot.Platform.u202215721.Shared.Domain.Model.Events;
using LetPot.Platform.u202215721.Shared.Infrastructure.Interfaces.ASP.Configuration;
using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using LetPot.Platform.u202215721.Telemetry.Application.Internal.CommandServices;
using LetPot.Platform.u202215721.Telemetry.Application.Internal.QueryServices;
using LetPot.Platform.u202215721.Telemetry.Domain.Repositories;
using LetPot.Platform.u202215721.Telemetry.Domain.Services;
using LetPot.Platform.u202215721.Telemetry.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new KebabCaseRouteNamingConvention());
});

// Add Database Services
builder.AddDatabaseServices();

// Register repositories
builder.Services.AddScoped<IDataRecordRepository, DataRecordRepository>();
builder.Services.AddScoped<IPotRepository, PotRepository>();

// Register services
builder.Services.AddScoped<IDataRecordCommandService, DataRecordCommandService>();
builder.Services.AddScoped<IDataRecordQueryService, DataRecordQueryService>();
builder.Services.AddScoped<IPotQueryService, PotQueryService>();

// Register ACL
builder.Services.AddScoped<IAllocationContextFacade, AllocationContextFacade>();

// Register Event Handlers
builder.Services.AddScoped<Cortex.Mediator.IEventHandler<DataRecordRegisteredEvent>, DataRecordRegisteredEventHandler>();

// Add Cortex Mediator
builder.Services.AddCortexMediator(typeof(Program).Assembly);

// Add Localization
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// Configure OpenAPI/Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "LetPot Platform API",
        Version = "v1",
        Description = "RESTful API for LetPot Smart Self-Watering Planter operations",
        Contact = new OpenApiContact
        {
            Name = "Deybbi Caviedes",
            Email = "u202215721@upc.edu.pe"
        }
    });
    c.EnableAnnotations();
});

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseDatabaseCreationAssurance();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "LetPot Platform API v1");
        c.RoutePrefix = string.Empty;
    });
}

// Configure supported cultures for localization
var supportedCultures = new[] { "en", "en-US", "es", "es-PE" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("en")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
