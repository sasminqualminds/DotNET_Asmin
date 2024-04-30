using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class International_flight:flight
    {
        
        int baggageAllowance;

        // Constructor
        public International_flight(string flight_num, string departure, string arrival, DateTime depart_time, DateTime arrive_time, int capacity, int baggageAllowance, int num_of_seats)
            : base(flight_num, departure, arrival, depart_time, arrive_time, capacity, num_of_seats)
        {
            this.baggageAllowance = baggageAllowance;
        }


        // Check luggage weight
        public bool CheckLuggageWeight(double totalWeight)
        {
            return totalWeight <= baggageAllowance;
        }
    }
}
