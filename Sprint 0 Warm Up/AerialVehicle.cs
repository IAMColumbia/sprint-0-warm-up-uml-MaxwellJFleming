using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }

        public Engine Engine { get; set; }

        public bool IsFlying { get; set; }

        public int MaxAltitude { get; set; }

        public AerialVehicle()
        {
            Engine = new Engine();
        }

        public string About()
        {
            if (Engine.isStarted)
                return $"This {ToString()} has a max altitude of {MaxAltitude} ft.\nIt's current altitude is {CurrentAltitude} ft.\n{ToString()} engine is started.";
            else
                return $"This {ToString()} has a max altitude of {MaxAltitude} ft.\nIt's current altitude is {CurrentAltitude} ft.\n{ToString()} engine is not started.";
        }

        public string TakeOff()
        {
            if (Engine.isStarted)
            {
                IsFlying = true;
                return $"{ToString()} is flying.";
            }  
            else
                return $"{ToString()} can't fly it's engine is not started.";
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public void FlyDown(int howMuch)
        {
            if (CurrentAltitude - howMuch >= 0)
                CurrentAltitude -= howMuch;
        }

        internal void FlyUp()
        {
            if (CurrentAltitude + 1000 <= MaxAltitude)
                CurrentAltitude += 1000;
        }

        internal void FlyUp(int HowMuch)
        {
            if (CurrentAltitude + HowMuch <= MaxAltitude)
                CurrentAltitude += HowMuch;
        }
    }
}