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

        private static void SeedData(DataContext context)
        {

        }
    }
}
