using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WaterDetector
{
    class WaterTank
    {
        private int _value = 0;

        public WaterTank(int capacity, string name)
        {
            Capacity = capacity;
            Name = name;
            Reset();
        }

        public int Capacity { get; }
        public string Name { get; }
        public int CurrentValue { get { return _value; } }
        public void Reset()
        {
            _value = 0;
        }

        public void Add(int value)
        {
            _value += value;
        }
    }
}
