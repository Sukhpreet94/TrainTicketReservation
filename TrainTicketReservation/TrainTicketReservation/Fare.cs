using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketReservation
{
    class Fare : Train
    {
        private int numberOfSeats;
        private double totalSeatFare;

        //getter
        public int GetNumberOfSeats()
        {
            return numberOfSeats;
        }
        public double GetTotalSeatFare()
        {
            return totalSeatFare;
        }

        //setter
        public void SetNumberOfseats(int numberOfSeats)
        {
            this.numberOfSeats = numberOfSeats;
        }
        public void SetTotalSeatFare()
        {
            this.totalSeatFare = numberOfSeats * SEAT_FARE;
        }
    }
}
