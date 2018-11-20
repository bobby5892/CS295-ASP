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
        }
}
