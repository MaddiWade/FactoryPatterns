using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
     static class TimeSlot
    {
        public static IRestrauntReservations GetReservations(string reservation)
        {
           
               
            switch (reservation.ToLower())
            {
                case "breakfast":
                    return new BreakfastReservations();
                case "lunch":
                    return new LunchReservation();
                default : return null;
            }
        
              
        }
    }
}
