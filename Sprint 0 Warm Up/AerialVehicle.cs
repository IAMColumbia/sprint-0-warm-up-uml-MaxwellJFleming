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
            if (Engine.IsStarted)
                return $"This {ToString()} has a max altitude of {MaxAltitude} ft.\nIt's current altitude is {CurrentAltitude} ft.\n{Engine.ToString()} is started.";
            else
                return $"This {ToString()} has a max altitude of {MaxAltitude} ft.\nIt's current altitude is {CurrentAltitude} ft.\n{Engine.ToString()} is not started.";
        }

        public string TakeOff()
        {
            if (Engine.IsStarted)
            {
                IsFlying = true;
                return $"{ToString()} is flying";
            }  
            else
                return $"{ToString()} can't fly it's engine is not started.";
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public void StopEngine()
        {
            Engine.Stop();
        }

        public void FlyDown()
        {
            if (CurrentAltitude - 1000 >= 0)
                CurrentAltitude -= 1000;
        }

        public void FlyDown(int howMuch)
        {
            if (CurrentAltitude - howMuch >= 0)
                CurrentAltitude -= howMuch;
        }

        public void FlyUp()
        {
            if (CurrentAltitude + 1000 <= MaxAltitude)
                CurrentAltitude += 1000;
        }

        public void FlyUp(int howMuch)
        {
            if (CurrentAltitude + howMuch <= MaxAltitude)
                CurrentAltitude += howMuch;
        }
    }
}