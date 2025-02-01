# Namespace: `MyApp.Application.Configurations`

## Class: `AutoMapperConfiguration`

- **File Path:** `MyApp.Application/Configurations/AutoMapperConfiguration.cs`
- **Inherits From:** N/A

### Class Code

```csharp
public static class AutoMapperConfiguration
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                // Register all AutoMapper profiles here
                cfg.AddProfile(new AlbumProfile());
                cfg.AddProfile(new CDProfile());
                cfg.AddProfile(new TrackProfile());
                cfg.AddProfile(new TaskItemProfile());
                cfg.AddProfile(new ProviderProfile());
                cfg.AddProfile(new ClaimProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `AddAutoMapper` | `public static void AddAutoMapper(IServiceCollection services)` |

#### Method: `AddAutoMapper`

```csharp
public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                // Register all AutoMapper profiles here
                cfg.AddProfile(new AlbumProfile());
                cfg.AddProfile(new CDProfile());
                cfg.AddProfile(new TrackProfile());
                cfg.AddProfile(new TaskItemProfile());
                cfg.AddProfile(new ProviderProfile());
                cfg.AddProfile(new ClaimProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
```

