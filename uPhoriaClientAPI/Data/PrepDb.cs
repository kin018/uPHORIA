using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

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


            }
            else
            {
                Console.WriteLine("--> Data is currently present <--");
            }
        }
    }
}
