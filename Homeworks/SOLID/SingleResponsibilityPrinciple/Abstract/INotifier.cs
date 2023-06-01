﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Abstract
{
    public interface INotifier
    {
        void SendNotifier(Customer customer, Earthquake earthquake);
    }
}
