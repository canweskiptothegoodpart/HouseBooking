﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Model.Mapper;

namespace DataLayer.IRepository
{
    public interface IAddressService
    {

        Task<AddressDTO> GetBuildingByAddressIdAsync(int id);
        AddressDTO GetBuildingByAddressId(int id);
        Task<IEnumerable<AddressDTO>> GetBuildingsByCountryAsync(string country);
        Task<IEnumerable<AddressDTO>> GetBuildingsByCityAsync(string city);

        Task<IEnumerable<AddressDTO>> GetBuildingsByDistrictAsync(string district);

        Task<IEnumerable<AddressDTO>> GetBuildingsByHouseTypeAsync(string? house, string country);

        Task<int> GetBuildingsCountByCityAsync(string city);



    }
}