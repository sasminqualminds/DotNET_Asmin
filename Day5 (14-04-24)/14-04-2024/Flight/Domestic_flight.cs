using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Domestic_flight:flight
    {
        int baggageAllowance;

        // Constructor
        public Domestic_flight(string flight_num, string departure, string arrival, DateTime depart_time, DateTime arrive_time, int capacity, int baggageAllowance, int num_of_seats)
            : base(flight_num, departure, arrival, depart_time, arrive_time, capacity, num_of_seats)
        {
            this.baggageAllowance = baggageAllowance;
        }

        
        // Calculating flight duration
        public TimeSpan CalculateFlightDuration()
        {
            return arrive_time - depart_time;
        }
    
}
}
