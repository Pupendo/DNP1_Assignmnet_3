using System;
using System.Linq;
using System.Threading.Tasks;
using RestApi.DataAccess;
using WebAPI.Models;

namespace WebAPI.Authentication
{
    public class UserRepo: IUserRepo
    {
        public async Task<Account> ValidateUserAsync(string username, string password)
        {
            using (AdultDBContext adultDbContext = new AdultDBContext())
            {
              Account first = adultDbContext.Accounts.FirstOrDefault(user => user.Username.Equals(username));
              if (first == null)
              { 
                  throw new Exception("User not found");
              }
              if (!first.Password.Equals(password))
              { 
                  throw new Exception("Incorrect password");
              } 
              return first;
            }
        }
    }
}