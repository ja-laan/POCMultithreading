using System;
using System.Collections.Generic;
using System.Text;
using ThreadingTheCounters.Interfaces;

namespace ThreadingTheCounters.Models
{
    class Race : IRace
    {
        private int counter;
        public int Counter { get => counter; set { counter = new Random().Next(0, 200); } }
    }
}
