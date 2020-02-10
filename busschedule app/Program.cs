using System;

namespace busschedule_app
{
    class Program
    {
        static void Main(string[] arg)
        {
            var mybus = new Bus();
            mybus.Busnumber = 1;
            mybus.Stationname = "station A";
           // mybus.arivingtime = "8am";
           // mybus.nearbystation();
            Console.WriteLine($"BN: {mybus.Busnumber}, SN: {mybus.Stationname}, AR: {mybus.Arivingtime}");
        }
    }
}
