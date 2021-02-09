using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class ToyPlane : Airplane
    {
        public bool isWoundUp { get; set; }

        public ToyPlane()
        {
            MaxAltitude = 50;
        }

        public string getWindUpString()
        {
            if (isWoundUp)
                return $"{ToString()} string is wound up.";
            else
                return $"{ToString()} string is not wound up.";
        }

        public void StartEngine()
        {
            if (isWoundUp)
            {
                Engine.Start();
                Unwind();
            }
                
        }

        public string TakeOff()
        {
            if (Engine.IsStarted)
            {
                IsFlying = true;
                return $"{ToString()} is flying.";
            }
            else
                return $"{ToString()} can't fly its engine isn't started.";
        }

        public void Unwind()
        {
            isWoundUp = false;
        }

        public void WindUp()
        {
            isWoundUp = true;
        }
    }
}
