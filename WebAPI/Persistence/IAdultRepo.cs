﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Persistence
{
    public interface IAdultRepo
    {
        Task<List<Adult>> GetAdultsAsync();
        Task<Adult> AddAdultAsync(Adult adult);
        Task<Adult> GetAdultAsync(int id);
        Task RemoveAdultAsync(int id);
        Task<Adult> UpdateAsync(Adult adult);
    }
}