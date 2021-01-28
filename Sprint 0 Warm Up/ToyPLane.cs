using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class ToyPlane : Airplane
    {
        public bool isWoundUp { get; set; }

        public ToyPlane()
        {
            MaxAltitude = 50;
        }
    }
}
