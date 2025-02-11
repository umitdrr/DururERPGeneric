﻿using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface ILocationServices
    {
        Task<IEnumerable<Location>> GetLocationsAsync();
        Task<IEnumerable<Location>> GetByCountryID(int countryID);
        Task<Location> GetLocationByIDAsync(int id);

        Task AddLocationAsync(Location location);

        Location UpdateLocation(Location locationToUpdate,Location location);

        Task RemoveLocation(int id);
        Task RemoveLocation(Location location);

        Task<IEnumerable<Location>> GetLocationsWithCountries();
    }
}
