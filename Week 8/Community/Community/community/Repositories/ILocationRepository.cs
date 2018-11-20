using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;
namespace community.Repositories
{
    public interface ILocationRepository
    {
        List<Location> Locations { get; }
    }
}
