using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketReservation
{
    class Train
    {
        public string reservationID;
        private string customerName;
        private long contact;
        public const double SEAT_FARE = 80;
        public const double LUGGAGE_FARE_PER_KG = 2;

        //getter
        public string GetReservationID()
        {
            return reservationID;
        }
        public string GetCustomerName()
        {
            return customerName;
        }
        public long GetContact()
        {
            return contact;
        }
        public double GetSeatFare()
        {
            return SEAT_FARE;
        }
        public double GetLuggageFarePerKG()
        {
            return LUGGAGE_FARE_PER_KG;
        }

        //setter
        public void SetReservationID(string reservationID)
        {
            this.reservationID = reservationID;
        }
        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
        public void SetContact(long contact)
        {
            this.contact = contact;
        }

    }
}
