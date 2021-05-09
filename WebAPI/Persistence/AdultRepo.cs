using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestApi.DataAccess;
using WebAPI.Models;

namespace WebAPI.Persistence
{
    public class AdultRepo : IAdultRepo
    {

        public Task<List<Adult>> GetAdultsAsync()
        {
            using (AdultDBContext context = new AdultDBContext())
            {
                return context.Adults.Include(a => a.JobTitle).ToListAsync();
            }
            
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            using (AdultDBContext context = new AdultDBContext())
            {
                context.Adults.Add(adult);
                await context.SaveChangesAsync();
                return adult;
            }
        }

        public async Task<Adult> GetAdultAsync(int id)
        {
            using (AdultDBContext context = new AdultDBContext())
            {
               Adult adult = context.Adults.Where(a => a.Id == id).
                               Include(a => a.JobTitle).First();
                           return adult; 
            }
            
        }

        public async Task RemoveAdultAsync(int id)
        {
            using (AdultDBContext context = new AdultDBContext())
            {
                Adult adult = context.Adults.Where(a => a.Id == id).
                                Include(a => a.JobTitle).First();
                context.Adults.Remove(adult);
                context.Jobs.Remove(adult.JobTitle);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Adult> UpdateAsync(Adult adult)
        {
            using (AdultDBContext dbContext = new AdultDBContext())
            {
                dbContext.Adults.Update(adult);
                await dbContext.SaveChangesAsync();
                return adult;
            } 
        }
    }
}