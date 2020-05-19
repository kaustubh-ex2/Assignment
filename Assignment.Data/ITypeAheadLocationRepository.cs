using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment.Core;

public interface ITypeAheadLocationRepository
{
    Task<ICollection<Location>> GetAllLocationsAsync(int partnerId, string search, string Types, bool IncludeAll);
}