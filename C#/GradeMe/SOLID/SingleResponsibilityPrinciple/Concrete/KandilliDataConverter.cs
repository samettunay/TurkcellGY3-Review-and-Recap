using SingleResponsibilityPrinciple.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SingleResponsibilityPrinciple.Concrete
{
    public class KandilliDataConverter : IDataConverter<Earthquake>
    {
        public List<Earthquake> APIStringToList(string apiString)
        {
            XDocument doc = XDocument.Parse(apiString);
            List<Earthquake> earthquakes = new List<Earthquake>();

            foreach (XElement element in doc.Descendants("eqlist").Descendants("earhquake"))
            {
                string location = element.Attribute("lokasyon")?.Value?.Trim();
                string dateString = element.Attribute("name")?.Value?.Trim();
                DateTime.TryParse(dateString, out DateTime date);
                double.TryParse(element.Attribute("lat")?.Value?.Trim(), out double latitude);
                double.TryParse(element.Attribute("lng")?.Value?.Trim(), out double longitude);
                double.TryParse(element.Attribute("mag")?.Value?.Trim(), out double magnitude);
                double.TryParse(element.Attribute("Depth")?.Value?.Trim(), out double depth);

                Earthquake earthquake = new Earthquake
                {
                    Location = location,
                    Date = date,
                    Latitude = latitude,
                    Longitude = longitude,
                    Magnitude = magnitude,
                    Depth = depth
                };

                earthquakes.Add(earthquake);
            }

            return earthquakes;
        }
    }
}
