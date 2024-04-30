using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
     abstract class flight
    {
        // fields
        public string flight_num;
        public string departure;
        public string arrival;
        public DateTime depart_time;
        public DateTime arrive_time;
        public int capacity;
        public int num_of_seats;
        // Constructor
        public flight(string flight_num, string departure, string arrival, DateTime depart_time, DateTime arrive_time, int capacity,int num_of_seats)
        {
            this.flight_num = flight_num;
            this.departure = departure;
            this.arrival = arrival;
            this.depart_time = depart_time;
            this.arrive_time = arrive_time;
            this.capacity = capacity;
            this.num_of_seats=num_of_seats;
        }

        // Method to book a seat
        public void BookSeat()
        {
            if (num_of_seats < capacity)
            {
                num_of_seats++;
                Console.WriteLine("Seat booked successfully.");
            }
            else
            {
                Console.WriteLine("No seats available for booking.");
            }
        }

        // Method to cancel booking
        public void CancelBooking()
        {
            if (num_of_seats > 0)
            {
                num_of_seats--;
                Console.WriteLine("Booking canceled successfully.");
            }
            else
            {
                Console.WriteLine("No bookings to cancel.");
            }
        }

        // Method to check availability
        public bool CheckAvailability()
        {
            return num_of_seats < capacity;
        }

        
    }
}
