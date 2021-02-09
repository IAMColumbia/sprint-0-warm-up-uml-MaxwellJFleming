using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class Airport
    {
        public int MaxVehicles;

        public List<AerialVehicle> Vehicles = new List<AerialVehicle>();

        private string AirportCode { get; set; }

        public Airport(string _AirportCode)
        {
            AirportCode = _AirportCode;
        }

        public Airport(string _AirportCode, int _MaxVehicles)
        {
            AirportCode = _AirportCode;
            MaxVehicles = _MaxVehicles;
        }

        public string AllTakeOff()
        {
            string ret = "";
            
            foreach (AerialVehicle a in Vehicles)
            {
                a.StartEngine();
                a.TakeOff();
                if (a.IsFlying)
                {
                    ret += $"\n{a.ToString()} took off successfully.";
                    Vehicles.Remove(a);
                }
                else
                    ret += $"\n{a.ToString()} could not take off.";
            }
            
            return ret;
        }

        public string Land(AerialVehicle a)
        {
            a.CurrentAltitude = 0;
            a.StopEngine();
            a.IsFlying = false;
            Vehicles.Add(a);
            
            return $"{a.ToString()} has landed";
        }

        public string Land(List<AerialVehicle> landing)
        {
            string ret = "";
            
            foreach (AerialVehicle a in landing)
            {
                ret += ("\n" + Land(a));
            }
            
            return ret;
        }

        public string TakeOff(AerialVehicle a)
        {
            string ret;
            
            a.StartEngine();
            a.TakeOff();
            if (a.IsFlying)
            {
                ret = $"{a.ToString()} took off successfully.";
                Vehicles.Remove(a);
            }
            else
                ret = $"{a.ToString()} could not take off.";

            return ret;
        }
    }
}