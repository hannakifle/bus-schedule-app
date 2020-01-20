using System;
using System.Collections.Generic;
using System.Text;

namespace busschedule_app
{
    class bus
    {
        /// <summary>
        /// this represent bus schedule
        /// where you can get bus arriving time 
        /// and destination time
        /// </summary>
        #region properties
        public int busnumber { get; set; }
        public string stationname { get; set; }
        public string transit { get; set; }
        public int arivingtime { get; set; }
        public int destinationtime { get; set; }
        public string direction { get; set; }
        #endregion
    }
}
