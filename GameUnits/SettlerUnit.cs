using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost { get; }

        public SettlerUnit()
            : base(1, 2)
        {
            Cost = 5;
        }
    }
}




