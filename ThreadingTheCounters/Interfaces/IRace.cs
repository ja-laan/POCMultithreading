using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadingTheCounters.Interfaces
{
    interface IRace
    {
        int Counter { get; set; }
    }
}
