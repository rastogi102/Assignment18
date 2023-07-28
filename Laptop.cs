using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    public class Laptop: IConnectable, IRechargeble, IDisplayable
    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }

        public Laptop(string model)
        {
            Model = model;
            IsConnected = false;
            BatteryLevel = 0;
        }

        public bool Connect()
        {
            IsConnected = true;
            Console.WriteLine($"Laptop {Model} is now connected.");
            return true;
        }

        public void Charge(int minutes)
        {
            BatteryLevel += minutes;
            Console.WriteLine($"Laptop {Model} is charged for {minutes} minutes. Battery level: {BatteryLevel}%");
        }

        public string Display()
        {
            return $"Laptop {Model}: Connected: {IsConnected}, Battery Level: {BatteryLevel}%";
        }
    }
}
