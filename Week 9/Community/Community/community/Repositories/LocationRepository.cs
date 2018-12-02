using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using community.Models;
namespace community.Repositories
{
    public class LocationRepository :ILocationRepository
    {

            AppDBContext context;
            public LocationRepository(AppDBContext context)
            {
                this.context = context;
            }
            public List<Location> Locations { get { return context.Locations.ToList<Location>(); } }

            public void AddLocation(Location newLocation)
            {
                this.context.Add(newLocation);
                this.context.SaveChanges();
            }
        // Lab 9 //
            public Location SearchLocation(string location)
            {
                Location query = (
               from loc in Locations
               where loc.Name.Contains(location)
               select loc)
               .First();
                return query;
            }
    }
}
