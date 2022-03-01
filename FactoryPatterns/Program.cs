using System;

namespace FactoryPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you prefer a Breakfast or Lunch reservation?");
            string reservationTime = Console.ReadLine();

            IRestrauntReservations reservation = TimeSlot.GetReservations(reservationTime);
            reservation.Confirmation();
            Console.WriteLine();
        }
    }
}
