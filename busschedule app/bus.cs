using System;
using System.Collections.Generic;
using System.Text;

namespace busschedule_app
{
    /// <summary>
    /// this represent bus schedule
    /// where you can get bus arriving time 
    /// and destination time
    /// </summary>
    class Bus
    {
        enum TypeofStation
        {
            StationA,
            StationB,
            StationC,
        }
        private static int lastBusnumber = 0;
        #region properties

        /// <summary>
        /// unique bus number
        /// </summary>
        public int Busnumber { get; private set; }
        public string Stationname {  get; set; }
        public string Transit { get; set; }
        public int Arivingtime { get; private set; }
        public int Destinationtime { get; set; }
        public string Address { get; set; }
        #endregion\\

        #region constructor
        public Bus()
        {
            //lastbusnumber +=1;
            Busnumber = ++lastBusnumber;

        }

        #endregion

        #region method
        /// <summary>
        /// view near by station
        /// </summary>
        /// <returns>view all line for this station</returns>
        public void Nearbystation(string Station)
        {
            Station += Stationname; 
        }
        public int Arrivingtime(int time)
        {
            time += 15;
            return time;
        }
        #endregion
    }
}
