using RacingTheCounters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RacingTheCounters.Models
{
    class RacaAble : IRace 
    {
        int IRace.counter { get; set; }
    }
}
