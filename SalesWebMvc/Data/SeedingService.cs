using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Linq;

namespace SalesWebMvc.Data
{
    public static class SeedingService
    {
        public static void Seed(SalesWebMvcContext context)
        {
            if (!context.Department.Any())
            {
                context.Department.Add(new Department { Name = "Sales" });
                context.Department.Add(new Department { Name = "Marketing" });
                context.SaveChanges();
            }
        }
    }
}
