using SingleResponsibilityPrinciple.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Concrete
{
    public class EarthquakeDataReader
    {
        IEarthquakeAPI earthquakeAPI;
        IDataConverter<Earthquake> dataConverter;
        public EarthquakeDataReader(IEarthquakeAPI earthquakeAPI, IDataConverter<Earthquake> dataConverter)
        {
            this.earthquakeAPI = earthquakeAPI;
            this.dataConverter = dataConverter;
        }
        public async Task<List<Earthquake>> GetEarthquakes()
        {
            var result = await earthquakeAPI.GetAsync();
            return dataConverter.APIStringToList(result);
        }
    }
}
