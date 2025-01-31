using MyApp.Web.Components;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Persistence;
using MyApp.Application.UseCases.Music;
using MyApp.Domain.Repositories.Music;
using MyApp.Infrastructure.Repositories.Music;
using MyApp.Application.Configurations;
using MyApp.Domain.Repositories.Management;
using MyApp.Application.UseCases.Management;
using MyApp.Infrastructure.Repositories.Management;
using MyApp.Application.UseCases.NPI;
using MyApp.Domain.Abstractions.NPI;
using MyApp.Infrastructure.ExternalServices.NPI;
using System.Net.Http.Headers;
using MyApp.Shared.Services;
using MyApp.Domain.Repositories.Medical;
using MyApp.Infrastructure.Repositories.Medical;
using MyApp.Application.UseCases.Medical;
using MyApp.Application.Validators.Medical;
using FluentValidation;
using FluentValidation.AspNetCore;
using BlazorBootstrap;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
.AddInteractiveServerComponents();

builder.Services.AddFluentValidationAutoValidation();

// Add Blazor Bootstrap services
builder.Services.AddBlazorBootstrap();

// Music:
builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();
builder.Services.AddScoped<IAlbumUseCases, AlbumUseCases>();

// Management:
builder.Services.AddScoped<ITaskItemRepository, TaskItemRepository>();
builder.Services.AddScoped<ITaskItemUseCases, TaskItemUseCases>();

// Medical:
builder.Services.AddScoped<IClaimRepository, ClaimRepository>();
builder.Services.AddScoped<IClaimUseCases, ClaimUseCases>();

// Register all validators from the assembly containing ClaimDtoValidator
builder.Services.AddValidatorsFromAssemblyContaining<ClaimDtoValidator>();

// Shared:
builder.Services.AddScoped<IStateService, StateService>();
builder.Services.AddScoped<INavBarService, NavBarService>();

// NPI:
builder.Services.AddScoped<IProviderUseCases, ProviderUseCases>();

var npiRegistryBaseUrl = builder.Configuration["NpiRegistry:BaseUrl"];
builder.Services.AddHttpClient<INpiRegistryClient, NpiRegistryService>(client =>
{
    client.BaseAddress = new Uri(npiRegistryBaseUrl!);
    client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/json"));
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions =>
        {
            sqlOptions.MigrationsAssembly("MyApp.Infrastructure");
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
        }),
        ServiceLifetime.Scoped);

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Apply pending migrations automatically
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.Migrate();
}

app.Run();
