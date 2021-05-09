using System;
using System.Linq;
using System.Threading.Tasks;
using RestApi.DataAccess;

namespace WebAPI.Persistence
{
    public class StatisticsRepo : IStatisticsRepo
    {
        public async Task<int> GetAdultAgeGroupAsync(int minimum, int maximum)
        {
            using (AdultDBContext context = new AdultDBContext())
            {
                int count = 0;
                foreach (var a in context.Adults)
                {
                    if (a.Age >= minimum && a.Age <= maximum)
                    {
                        count++;
                    }
                }
                return count;   
            }
        }

        public async Task<double> GetEyeColorPercentageAsync(string color)
        {
            using (AdultDBContext Context = new AdultDBContext())
            {
               int count = 0;
               foreach (var a in Context.Adults) 
               {
                   if (a.EyeColor.Equals(color))
                   {
                       count++;
                   } 
               }
               return (double) count / Context.Adults.Count();
            }
        }
    }
}