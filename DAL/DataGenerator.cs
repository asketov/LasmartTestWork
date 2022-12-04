using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new DataContext(serviceProvider
                       .GetRequiredService<DbContextOptions<DataContext>>()))
            {
                context.AddRange(new Point
                {
                    Color = "gray", Id = Guid.NewGuid(), X = 100, Y = 100, Radius = 20, 
                    Comments = new List<Comment>()
                    {
                        new()
                        {
                            BackgroundColor = "white", Id = Guid.NewGuid(), Text = "comment 1"
                        },
                        new()
                        {
                            BackgroundColor = "yellow", Id = Guid.NewGuid(), Text = "comment 2"
                        }
                    }
                },
                    new Point
                    {
                        Color = "red", Id = Guid.NewGuid(), X = 400, Y = 100, Radius = 50,
                        Comments = new List<Comment>()
                        {
                            new()
                            {
                                BackgroundColor = "white", Id = Guid.NewGuid(), Text = "comment 3"
                            },
                            new()
                            {
                                BackgroundColor = "gray", Id = Guid.NewGuid(), Text = "comment 4"
                            },
                            new()
                            {
                                BackgroundColor = "white", Id = Guid.NewGuid(), Text = "comment 5"
                            },
                            new()
                            {
                                BackgroundColor = "yellow", Id = Guid.NewGuid(), Text = "comment 6 loooooooooooooooong comment"
                            },
                            new()
                            {
                                BackgroundColor = "gray", Id = Guid.NewGuid(), Text = "comment 7"
                            },
                            new()
                            {
                                BackgroundColor = "white", Id = Guid.NewGuid(), Text = "comment 8"
                            }
                        }
                    });
                context.SaveChanges();
            }
        }
    }
}
