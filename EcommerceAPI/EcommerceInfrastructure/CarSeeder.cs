using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceCore.Models;
using Newtonsoft.Json;

namespace EcommerceInfrastructure
{
    public class CarSeeder
    {
        public static async Task SeedData(CarDbContext dbContext)
        {
            var baseDir = Directory.GetCurrentDirectory();

            await dbContext.Database.EnsureCreatedAsync();

            if(!dbContext.Roles.Any())
            {
                var role = new Role()
                {
                    Id = "ce380e88-faf2-4358-b5e4-3791e224976e",
                    RoleName = "Customer"
                };

                await dbContext.AddAsync(role);
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Users.Any())
            {

                var path = File.ReadAllText(FilePath(baseDir, "db/Users.json"));

                var hbaUsers = JsonConvert.DeserializeObject<User>(path);

                await dbContext.AddRangeAsync(hbaUsers);
                await dbContext.SaveChangesAsync();
                var userRole = new UserRole() {Id ="hhkdk66383638383393933", RoleId = "ce380e88-faf2-4358-b5e4-3791e224976e", UserId = "e29844c5-10eb-44a5-a0a9-b922b1cdec9b" };

                await dbContext.AddAsync(userRole);
                await dbContext.SaveChangesAsync();


            }


           


            
        }

        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }
    }

   

}
