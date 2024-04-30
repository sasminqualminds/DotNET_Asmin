namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Domestic_flight domesticFlight = new Domestic_flight("DL123", "New York", "Los Angeles", DateTime.Now, DateTime.Now.AddDays(1), 200, 30, 25);
            domesticFlight.BookSeat();


            International_flight internationalFlight = new International_flight("AI456", "London", "Paris", DateTime.Now, DateTime.Now.AddDays(1), 150, 40, 20);
            internationalFlight.CancelBooking();


            Business_flight businessFlight = new Business_flight("BF789", "Paris", "Tokyo", DateTime.Now, DateTime.Now.AddDays(1), 50, 50, 20);
            businessFlight.BookSeat();
            businessFlight.RequestAssistance();
            Console.WriteLine($"Luggage weight within limit: {businessFlight.CheckLuggageWeight(45)}");
        }
    }
}
