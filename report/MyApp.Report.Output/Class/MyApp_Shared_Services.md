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

| Name | Signature | Definition |
|------|-----------|-------------|
| `GetNavBarItems` | `public List<NavBarItemDto> GetNavBarItems()` | `public List<NavBarItemDto> GetNavBarItems()<br>        {<br>            return new List<NavBarItemDto><br>            {<br>                new NavBarItemDto<br>                {<br>                    Description = "Home",<br>                    Href = "",<br>                    Class = "bi bi-house-door-fill",<br>                    ChildList = [<br>                        new NavBarItemDto<br>                        {<br>                            Description = "Task",<br>                            Href = "tasks",<br>                            Class = "bi bi-list-task"<br>                        }<br>                    ]<br>                },<br>                new NavBarItemDto<br>                {<br>                    Description = "Albums",<br>                    Href = "albums",<br>                    Class = "bi bi-music-note-list"<br>                },<br>                new NavBarItemDto<br>                {<br>                    Description = "NPI Registry",<br>                    Href = "npi",<br>                    Class = "bi bi-search"<br>                },<br>                new NavBarItemDto<br>                {<br>                    Description = "Claims",<br>                    Href = "claims",<br>                    Class = "bi bi-info-circle"<br>                }<br>            };<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `GetStates` | `public List<StateDto> GetStates()` | `public List<StateDto> GetStates()<br>        {<br>            return<br>            [<br>                new() { Value = "AL", Description = "Alabama" },<br>                new() { Value = "AK", Description = "Alaska" },<br>                new() { Value = "AZ", Description = "Arizona" },<br>                new() { Value = "AR", Description = "Arkansas" },<br>                new() { Value = "CA", Description = "California" },<br>                new() { Value = "CO", Description = "Colorado" },<br>                new() { Value = "CT", Description = "Connecticut" },<br>                new() { Value = "DE", Description = "Delaware" },<br>                new() { Value = "FL", Description = "Florida" },<br>                new() { Value = "GA", Description = "Georgia" },<br>                new() { Value = "HI", Description = "Hawaii" },<br>                new() { Value = "ID", Description = "Idaho" },<br>                new() { Value = "IL", Description = "Illinois" },<br>                new() { Value = "IN", Description = "Indiana" },<br>                new() { Value = "IA", Description = "Iowa" },<br>                new() { Value = "KS", Description = "Kansas" },<br>                new() { Value = "KY", Description = "Kentucky" },<br>                new() { Value = "LA", Description = "Louisiana" },<br>                new() { Value = "ME", Description = "Maine" },<br>                new() { Value = "MD", Description = "Maryland" },<br>                new() { Value = "MA", Description = "Massachusetts" },<br>                new() { Value = "MI", Description = "Michigan" },<br>                new() { Value = "MN", Description = "Minnesota" },<br>                new() { Value = "MS", Description = "Mississippi" },<br>                new() { Value = "MO", Description = "Missouri" },<br>                new() { Value = "MT", Description = "Montana" },<br>                new() { Value = "NE", Description = "Nebraska" },<br>                new() { Value = "NV", Description = "Nevada" },<br>                new() { Value = "NH", Description = "New Hampshire" },<br>                new() { Value = "NJ", Description = "New Jersey" },<br>                new() { Value = "NM", Description = "New Mexico" },<br>                new() { Value = "NY", Description = "New York" },<br>                new() { Value = "NC", Description = "North Carolina" },<br>                new() { Value = "ND", Description = "North Dakota" },<br>                new() { Value = "OH", Description = "Ohio" },<br>                new() { Value = "OK", Description = "Oklahoma" },<br>                new() { Value = "OR", Description = "Oregon" },<br>                new() { Value = "PA", Description = "Pennsylvania" },<br>                new() { Value = "RI", Description = "Rhode Island" },<br>                new() { Value = "SC", Description = "South Carolina" },<br>                new() { Value = "SD", Description = "South Dakota" },<br>                new() { Value = "TN", Description = "Tennessee" },<br>                new() { Value = "TX", Description = "Texas" },<br>                new() { Value = "UT", Description = "Utah" },<br>                new() { Value = "VT", Description = "Vermont" },<br>                new() { Value = "VA", Description = "Virginia" },<br>                new() { Value = "WA", Description = "Washington" },<br>                new() { Value = "WV", Description = "West Virginia" },<br>                new() { Value = "WI", Description = "Wisconsin" },<br>                new() { Value = "WY", Description = "Wyoming" }<br>            ];<br>        }` |

