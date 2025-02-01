# Namespace: `MyApp.Shared.Services`

## Class: `NavBarService`

- **File Path:** `MyApp.Shared/Services/NavBarService.cs`
- **Inherits From:** `INavBarService`

### Class Code

```csharp
public class NavBarService : INavBarService
    {
        public List<NavBarItemDto> GetNavBarItems()
        {
            return new List<NavBarItemDto>
            {
                new NavBarItemDto
                {
                    Description = "Home",
                    Href = "",
                    Class = "bi bi-house-door-fill",
                    ChildList = [
                        new NavBarItemDto
                        {
                            Description = "Task",
                            Href = "tasks",
                            Class = "bi bi-list-task"
                        }
                    ]
                },
                new NavBarItemDto
                {
                    Description = "Albums",
                    Href = "albums",
                    Class = "bi bi-music-note-list"
                },
                new NavBarItemDto
                {
                    Description = "NPI Registry",
                    Href = "npi",
                    Class = "bi bi-search"
                },
                new NavBarItemDto
                {
                    Description = "Claims",
                    Href = "claims",
                    Class = "bi bi-info-circle"
                }
            };
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `GetNavBarItems` | `public List<NavBarItemDto> GetNavBarItems()` |

#### Method: `GetNavBarItems`

```csharp
public List<NavBarItemDto> GetNavBarItems()
        {
            return new List<NavBarItemDto>
            {
                new NavBarItemDto
                {
                    Description = "Home",
                    Href = "",
                    Class = "bi bi-house-door-fill",
                    ChildList = [
                        new NavBarItemDto
                        {
                            Description = "Task",
                            Href = "tasks",
                            Class = "bi bi-list-task"
                        }
                    ]
                },
                new NavBarItemDto
                {
                    Description = "Albums",
                    Href = "albums",
                    Class = "bi bi-music-note-list"
                },
                new NavBarItemDto
                {
                    Description = "NPI Registry",
                    Href = "npi",
                    Class = "bi bi-search"
                },
                new NavBarItemDto
                {
                    Description = "Claims",
                    Href = "claims",
                    Class = "bi bi-info-circle"
                }
            };
        }
```

## Class: `StateService`

- **File Path:** `MyApp.Shared/Services/StateService.cs`
- **Inherits From:** `IStateService`

### Class Code

```csharp
public class StateService : IStateService
    {
        public List<StateDto> GetStates()
        {
            return
            [
                new() { Value = "AL", Description = "Alabama" },
                new() { Value = "AK", Description = "Alaska" },
                new() { Value = "AZ", Description = "Arizona" },
                new() { Value = "AR", Description = "Arkansas" },
                new() { Value = "CA", Description = "California" },
                new() { Value = "CO", Description = "Colorado" },
                new() { Value = "CT", Description = "Connecticut" },
                new() { Value = "DE", Description = "Delaware" },
                new() { Value = "FL", Description = "Florida" },
                new() { Value = "GA", Description = "Georgia" },
                new() { Value = "HI", Description = "Hawaii" },
                new() { Value = "ID", Description = "Idaho" },
                new() { Value = "IL", Description = "Illinois" },
                new() { Value = "IN", Description = "Indiana" },
                new() { Value = "IA", Description = "Iowa" },
                new() { Value = "KS", Description = "Kansas" },
                new() { Value = "KY", Description = "Kentucky" },
                new() { Value = "LA", Description = "Louisiana" },
                new() { Value = "ME", Description = "Maine" },
                new() { Value = "MD", Description = "Maryland" },
                new() { Value = "MA", Description = "Massachusetts" },
                new() { Value = "MI", Description = "Michigan" },
                new() { Value = "MN", Description = "Minnesota" },
                new() { Value = "MS", Description = "Mississippi" },
                new() { Value = "MO", Description = "Missouri" },
                new() { Value = "MT", Description = "Montana" },
                new() { Value = "NE", Description = "Nebraska" },
                new() { Value = "NV", Description = "Nevada" },
                new() { Value = "NH", Description = "New Hampshire" },
                new() { Value = "NJ", Description = "New Jersey" },
                new() { Value = "NM", Description = "New Mexico" },
                new() { Value = "NY", Description = "New York" },
                new() { Value = "NC", Description = "North Carolina" },
                new() { Value = "ND", Description = "North Dakota" },
                new() { Value = "OH", Description = "Ohio" },
                new() { Value = "OK", Description = "Oklahoma" },
                new() { Value = "OR", Description = "Oregon" },
                new() { Value = "PA", Description = "Pennsylvania" },
                new() { Value = "RI", Description = "Rhode Island" },
                new() { Value = "SC", Description = "South Carolina" },
                new() { Value = "SD", Description = "South Dakota" },
                new() { Value = "TN", Description = "Tennessee" },
                new() { Value = "TX", Description = "Texas" },
                new() { Value = "UT", Description = "Utah" },
                new() { Value = "VT", Description = "Vermont" },
                new() { Value = "VA", Description = "Virginia" },
                new() { Value = "WA", Description = "Washington" },
                new() { Value = "WV", Description = "West Virginia" },
                new() { Value = "WI", Description = "Wisconsin" },
                new() { Value = "WY", Description = "Wyoming" }
            ];
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `GetStates` | `public List<StateDto> GetStates()` |

#### Method: `GetStates`

```csharp
public List<StateDto> GetStates()
        {
            return
            [
                new() { Value = "AL", Description = "Alabama" },
                new() { Value = "AK", Description = "Alaska" },
                new() { Value = "AZ", Description = "Arizona" },
                new() { Value = "AR", Description = "Arkansas" },
                new() { Value = "CA", Description = "California" },
                new() { Value = "CO", Description = "Colorado" },
                new() { Value = "CT", Description = "Connecticut" },
                new() { Value = "DE", Description = "Delaware" },
                new() { Value = "FL", Description = "Florida" },
                new() { Value = "GA", Description = "Georgia" },
                new() { Value = "HI", Description = "Hawaii" },
                new() { Value = "ID", Description = "Idaho" },
                new() { Value = "IL", Description = "Illinois" },
                new() { Value = "IN", Description = "Indiana" },
                new() { Value = "IA", Description = "Iowa" },
                new() { Value = "KS", Description = "Kansas" },
                new() { Value = "KY", Description = "Kentucky" },
                new() { Value = "LA", Description = "Louisiana" },
                new() { Value = "ME", Description = "Maine" },
                new() { Value = "MD", Description = "Maryland" },
                new() { Value = "MA", Description = "Massachusetts" },
                new() { Value = "MI", Description = "Michigan" },
                new() { Value = "MN", Description = "Minnesota" },
                new() { Value = "MS", Description = "Mississippi" },
                new() { Value = "MO", Description = "Missouri" },
                new() { Value = "MT", Description = "Montana" },
                new() { Value = "NE", Description = "Nebraska" },
                new() { Value = "NV", Description = "Nevada" },
                new() { Value = "NH", Description = "New Hampshire" },
                new() { Value = "NJ", Description = "New Jersey" },
                new() { Value = "NM", Description = "New Mexico" },
                new() { Value = "NY", Description = "New York" },
                new() { Value = "NC", Description = "North Carolina" },
                new() { Value = "ND", Description = "North Dakota" },
                new() { Value = "OH", Description = "Ohio" },
                new() { Value = "OK", Description = "Oklahoma" },
                new() { Value = "OR", Description = "Oregon" },
                new() { Value = "PA", Description = "Pennsylvania" },
                new() { Value = "RI", Description = "Rhode Island" },
                new() { Value = "SC", Description = "South Carolina" },
                new() { Value = "SD", Description = "South Dakota" },
                new() { Value = "TN", Description = "Tennessee" },
                new() { Value = "TX", Description = "Texas" },
                new() { Value = "UT", Description = "Utah" },
                new() { Value = "VT", Description = "Vermont" },
                new() { Value = "VA", Description = "Virginia" },
                new() { Value = "WA", Description = "Washington" },
                new() { Value = "WV", Description = "West Virginia" },
                new() { Value = "WI", Description = "Wisconsin" },
                new() { Value = "WY", Description = "Wyoming" }
            ];
        }
```

