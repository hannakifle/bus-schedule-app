using System;

namespace busschedule_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var mybus = new bus();
            mybus.busnumber = 1;
            mybus.stationname = "A";
            mybus.arivingtime = "8 am";
            var mybus2 = new bus();
            mybus2.busnumber = 2;
            mybus2.stationname = "B";
            mybus2.arivingtime = "1 AM";
        }
    }
}
