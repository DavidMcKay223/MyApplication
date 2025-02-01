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

| Name | Signature | Definition |
|------|-----------|-------------|
| `AddAutoMapper` | `public static void AddAutoMapper(IServiceCollection services)` | `public static void AddAutoMapper(this IServiceCollection services)<br>        {<br>            var mapperConfig = new MapperConfiguration(cfg =><br>            {<br>                // Register all AutoMapper profiles here<br>                cfg.AddProfile(new AlbumProfile());<br>                cfg.AddProfile(new CDProfile());<br>                cfg.AddProfile(new TrackProfile());<br>                cfg.AddProfile(new TaskItemProfile());<br>                cfg.AddProfile(new ProviderProfile());<br>                cfg.AddProfile(new ClaimProfile());<br>            });<br><br>            var mapper = mapperConfig.CreateMapper();<br>            services.AddSingleton(mapper);<br>        }` |

