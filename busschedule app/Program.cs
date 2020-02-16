using System;

namespace busschedule_app
{
    class Program
    {
        static void Main(string[] arg)
        {
            var mybus = new Bus();
            mybus.Stationname = "Station A";
           // mybus.arivingtime = "8am";
           // mybus.nearbystation();
            Console.WriteLine($"BN: {mybus.Busnumber}, SN: {mybus.Stationname}, AR: {mybus.Arivingtime}");
        }
    }
}
