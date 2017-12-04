using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithWebSite.Data;
using ZenithWebSite.Models.ZenithSocietyModels;

namespace ZenithWebSite.Models
{
    public class DummyData
    {

        public static void Initialize(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            IServiceScopeFactory SF = serviceProvider.GetRequiredService<IServiceScopeFactory>();

            using (IServiceScope s = SF.CreateScope())
            {
                RoleManager<IdentityRole> roleManger = s.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                UserManager<ApplicationUser> userManager = s.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                SeedUsers(context, userManager, roleManger);
            }
            if(!context.ActivityCategories.Any())
            {
                context.ActivityCategories.AddRange(GetActivityCategories().ToArray());
                context.SaveChanges();
            }
            if (!context.Events.Any())
            {
                context.Events.AddRange(GetEvents().ToArray());
                context.SaveChanges();
            }
        }

        public static List<ActivityCategory> GetActivityCategories()
        {
            var activityCategories = new List<ActivityCategory>
            {
                new ActivityCategory
                {
                    ActivityDescription = "Senior's Golf Tournament",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Leadership General Assembly Meeting",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Youth Bowling Tournament",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Young ladies cooking lessons",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Youth craft lessons",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Youth choir practice",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Lunch",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Pancake Breakfast",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Swimming Lessons for the youth",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Swimming Excercise for parents",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Bingo Tournament",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "BBQ Lunch",
                    CreationDate = DateTime.Now
                },
                new ActivityCategory
                {
                    ActivityDescription = "Garage Sale",
                    CreationDate = DateTime.Now
                }
            };

            return activityCategories;
        }

        public static List<Event> GetEvents()
        {
            var events = new List<Event>
            {
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 17, 8, 30, 0),
                    EventToDate = new DateTime(2017, 10, 17, 10, 30, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Senior's Golf Tournament",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 18, 8, 30, 0),
                    EventToDate = new DateTime(2017, 10, 18, 10, 30, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Leadership General Assembly Meeting",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 20, 17, 30, 0),
                    EventToDate = new DateTime(2017, 10, 20, 19, 15, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Youth Bowling Tournament",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 20, 19, 0, 0),
                    EventToDate = new DateTime(2017, 10, 20, 20, 0, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Young ladies cooking lessons",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 21, 8, 30, 0),
                    EventToDate = new DateTime(2017, 10, 21, 10, 30, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Youth craft lessons",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 21, 10, 30, 0),
                    EventToDate = new DateTime(2017, 10, 21, 12, 00, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Youth choir practice",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 21, 12, 0, 0),
                    EventToDate = new DateTime(2017, 10, 21, 13, 30, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Lunch",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 22, 7, 30, 0),
                    EventToDate = new DateTime(2017, 10, 2, 8, 30, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Pancake Breakfast",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 22, 8, 30, 0),
                    EventToDate = new DateTime(2017, 10, 22, 10, 30, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Swimming Lessons for the youth",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 22, 8, 30, 0),
                    EventToDate = new DateTime(2017, 10, 22, 10, 30, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Swimming Excercise for parents",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 22, 10, 30, 0),
                    EventToDate = new DateTime(2017, 10, 22, 12, 00, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Bingo Tournament",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 22, 12, 0, 0),
                    EventToDate = new DateTime(2017, 10, 22, 13, 0, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "BBQ Lunch",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                },
                new Event
                {
                    EventFromDate = new DateTime(2017, 10, 22, 13, 0, 0),
                    EventToDate = new DateTime(2017, 10, 22, 18, 0, 0),
                    CreatedBy = "Seed",
                    ActivityCategory = new ActivityCategory {
                        ActivityDescription = "Garage Sale",
                        CreationDate = DateTime.Now
                    },
                    CreationDate = DateTime.Now,
                    IsActive = true
                }
            };

            return events;
        }

        public static async void SeedUsers(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (!await roleManager.RoleExistsAsync("Member"))
            {
                await roleManager.CreateAsync(new IdentityRole("Member"));
            }
            if (await userManager.FindByNameAsync("a") == null)
            {
                var admin = new ApplicationUser
                {
                    Email = "a@a.a",
                    UserName = "a",
                };
                var createAdmin = await userManager.CreateAsync(admin, "P@$$w0rd");
                if(createAdmin.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                }
            }

            if (await userManager.FindByNameAsync("m") == null)
            {
                var member = new ApplicationUser
                {
                    Email = "m@m.m",
                    UserName = "m",
                };
                var createMember = await userManager.CreateAsync(member, "P@$$w0rd");
                if (createMember.Succeeded)
                {
                    await userManager.AddToRoleAsync(member, "Member");
                }
            }
        }
    }
}
