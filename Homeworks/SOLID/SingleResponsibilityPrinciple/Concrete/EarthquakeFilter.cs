using SingleResponsibilityPrinciple.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Concrete
{
    public class EarthquakeFilter : IFilter
    {
        List<Earthquake> earthquakes;

        public EarthquakeFilter(List<Earthquake> earthquakes)
        {
            this.earthquakes = earthquakes;
        }

        public Earthquake GetLastEarthquakeIfDevastating()
        {
            return earthquakes.LastOrDefault(e => e.Magnitude >= 4);
        }

    }
}
