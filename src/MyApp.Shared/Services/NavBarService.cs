using MyApp.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Shared.Services
{
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
                }
            };
        }
    }
}
