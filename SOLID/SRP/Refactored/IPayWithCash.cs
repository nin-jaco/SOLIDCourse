﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Refactored
{
    public interface IPayWithCash
    {
        void AcceptCash();
        void DispenseChange();
    }
}
