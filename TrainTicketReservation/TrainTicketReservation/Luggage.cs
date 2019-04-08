using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketReservation
{
    class Luggage : Train
    {
        private double totalWeight;
        private double totalLuggagePrice;

        //getter
        public double GetTotalWeight()
        {
            return totalWeight;
        }
        public double GetTotalLuggagePrice()
        {
            return totalLuggagePrice;
        }
        
        //setter
        public void SetTotalWeight(double totalWeight)
        {
            this.totalWeight = totalWeight;
        }
        public void SetTotalLuggagePrice()
        {
            this.totalLuggagePrice = totalWeight * LUGGAGE_FARE_PER_KG;
        }
    }
}
