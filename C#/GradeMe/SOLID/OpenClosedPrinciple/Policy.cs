using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Policy
    {
        public string PolicyName { get; set; }
        public int MinimumAge { get; set; }
        public bool AllowInternational { get; set; }
        public decimal MaximumBudget { get; set; }
    }
}
