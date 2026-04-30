using House_renting_system_Project.Servises.House;
using System;
using System.Collections.Generic;
using System.Text;

namespace House_renting_system_Project.Servises.Contracts
{
    public interface IHouseService
    {
        Task<AllHouseViewModel> GetHousesByUserId(string userId);
    }
}
