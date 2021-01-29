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

        public string getWindUpString()
        {
            if (isWoundUp)
                return "String is wound up.";
            else
                return "String is not wound up.";
        }

        public void StartEngine()
        {
            if (isWoundUp)
                Engine.Start();
        }

        public string TakeOff()
        {
            throw new NotImplementedException();
        }

        public void Unwind()
        {
            throw new NotImplementedException();
        }

        public void WindUp()
        {
            throw new NotImplementedException();
        }
    }
}
