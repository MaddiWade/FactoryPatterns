using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    internal class BreakfastReservations : IRestrauntReservations
    {
        public void Confirmation()
        {
            Console.WriteLine("The guest have Confirmed their reservation!");
        }


    }
}
