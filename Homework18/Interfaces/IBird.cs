﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18.Interfaces
{
    public interface IBird : IFlier
    {
        double WingSpan { get; set; }
    }
}
