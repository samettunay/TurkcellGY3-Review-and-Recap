using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public interface IMinistry
    {
        List<Policy> CheckPolicies(Policy policy);
    }


}
