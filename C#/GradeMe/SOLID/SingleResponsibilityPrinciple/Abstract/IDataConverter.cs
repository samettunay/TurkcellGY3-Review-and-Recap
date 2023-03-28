using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Abstract
{
    public interface IDataConverter<T>
    {
        List<T> APIStringToList(string apiResponse);
    }
}
