using SingleResponsibilityPrinciple;
using SingleResponsibilityPrinciple.Abstract;
using SingleResponsibilityPrinciple.Concrete;

HttpClient httpClient = new HttpClient();
string apiUrl = "http://udim.koeri.boun.edu.tr/zeqmap/xmlt/son24saat.xml";

EarthquakeDataReader earthquakeDataReader = new EarthquakeDataReader(new KandilliAPI(httpClient, apiUrl), new KandilliDataConverter());

var earthquakes = await earthquakeDataReader.GetEarthquakes();

EarthquakeFilter earthquakeFilter = new EarthquakeFilter(earthquakes);

var devastatingEarthquakes = earthquakeFilter.GetLastEarthquakeIfDevastating();

Customer customer = new Customer { 
    Id = 1, 
    FirstName = "Samet", 
    LastName = "TUNAY", 
    Email = "hacisamettunay@gmail.com", 
    Location = "Malatya", 
    PhoneNumber = "555555555"
};

SmsNotifier smsNotifier = new SmsNotifier();

EarthquakeNotifier earthquakeNotifier = new EarthquakeNotifier(earthquakeFilter, smsNotifier);

earthquakeNotifier.DevastatingEarthquakeNotificationSender(customer, devastatingEarthquakes);


