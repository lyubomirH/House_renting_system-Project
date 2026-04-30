using House_renting_system_Project.Data.Data;
using House_renting_system_Project.Servises.Contracts;
using House_renting_system_Project.Servises.House;
using House_renting_system_Project.Servises.House.Helpers;
using House_renting_system_Project.Servises.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace House_renting_system_Project.Servises.Implementations
{
    public class HouseService : IHouseService
    {
        private readonly HouseRentingDbContext context;
        public HouseService(HouseRentingDbContext context)
        {
            this.context = context;
        }
        public async Task<AllHouseViewModel> GetHousesByUserId(string userId)
        {
            var houses = await context.Houses
                .AsNoTracking()
                .Where(h => h.AgentId == userId)
                .Select(h => new HousesViewModel
                {
                    Address = h.Address,
                    ImageUrl = h.ImageUrl,
                    Name = h.Title,
                    Id = h.Id,
                    CurentUserIsOwner = true
                })
                .ToListAsync();

            var allCategories = await context.Categories
                .AsNoTracking()
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();

            var allHouseViewModel = new AllHouseViewModel
            {
                Houses = houses,
                Query = new QueryViewModel
                {
                    AllCategory = allCategories,
                    IsDecending = false
                }
            };

            return allHouseViewModel;
        }
    }
}
