using SingleResponsibilityPrinciple.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Concrete
{
    public class EarthquakeNotifier
    {
        IFilter filter;
        INotifier notifier;

        public EarthquakeNotifier(IFilter filter, INotifier notifier)
        {
            this.filter = filter;
            this.notifier = notifier;
        }

        public void DevastatingEarthquakeNotificationSender(Customer customer, Earthquake earthquake)
        {
            var devastatingEarthquakes = filter.GetLastEarthquakeIfDevastating();
            notifier.SendNotifier(customer, earthquake);
        }
    }
}
