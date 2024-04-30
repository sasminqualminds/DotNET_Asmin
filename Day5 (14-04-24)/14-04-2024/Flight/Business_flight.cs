using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Business_flight:flight
    {
        
        int baggageAllowance;

        // Constructor
        public Business_flight(string flight_num, string departure, string arrival, DateTime depart_time, DateTime arrive_time, int capacity, int baggageAllowance, int num_of_seats)
            : base(flight_num, departure, arrival, depart_time, arrive_time, capacity, num_of_seats)
        {
            this.baggageAllowance = baggageAllowance;
        }
       

        // Method for requesting assistance from cabin crew
        public void RequestAssistance()
        {
            Console.WriteLine("Passenger requested assistance.");
        }

        // Additional method: Check luggage weight
        public bool CheckLuggageWeight(double totalWeight)
        {
            return totalWeight <= baggageAllowance;
        }
    }
}
