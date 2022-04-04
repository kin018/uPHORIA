using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using uPhoriaClientAPI.Models;

namespace uPhoriaClientAPI.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<DataContext>());
            }
        }

        private static void SeedData(DataContext context) //does seeding for all data and migrations 
        {
            if (!context.Posts.Any()) //check if we have data in Database posts(from DataContext) (!=not operator) 
            {
                Console.WriteLine("--> ...Seeding Data... <--");

                context.Posts.AddRange(
                    new Post()
                    {
                        text = "Here is my first test post for the uPhoria platform",
                    },

                    new Post()
                    {
                        text = "Post 2 already...Think I am going to eat some ice cream after writing some code today",
                    },

                    new Post()
                    {
                        text = "3...That...is....all.....",
                    }
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> Data is currently present <--");
            }
        }
    }
}
