using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTicketReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            grpBxTicketInformation.Hide();
        }

        Train train;
        Fare fare;
        Luggage luggage;

        private void btnNext_Click(object sender, EventArgs e)
        {
            train = new Train();

            string reservationId = txtReservationID.Text;
            string customerName = txtCustomerName.Text;
            long contact = Convert.ToInt64(txtContact.Text);

            train.SetReservationID(reservationId);
            train.SetCustomerName(customerName);
            train.SetContact(contact);

            btnNext.Hide();
            grpBxCustomerInformation.Enabled = false;
            grpBxTicketInformation.Show();

            lblSeatFare.Text = "Fare per Seat : " + train.GetSeatFare().ToString("c");
            lblLuggageFarePerKG.Text = "Luggage Fare per KG : " + train.GetLuggageFarePerKG().ToString("c");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string reservationID = train.GetReservationID();
            fare = new Fare();
            fare.SetReservationID(reservationID);
            int numberOfSeat = Convert.ToInt32(txtNumberOfSeat.Text);
            fare.SetNumberOfseats(numberOfSeat);
            fare.SetTotalSeatFare();

            luggage = new Luggage();
            luggage.SetReservationID(reservationID);
            double totalWeight = Convert.ToDouble(txtTotalWeight.Text);
            luggage.SetTotalWeight(totalWeight);
            luggage.SetTotalLuggagePrice();

            double totalFare = fare.GetTotalSeatFare() + luggage.GetTotalLuggagePrice();

            string output = "Reservation ID: " + train.GetReservationID() + "\n"+
                            "Customer Name: " + train.GetCustomerName() + "\n" +
                            "Contact Number: " + train.GetContact() + "\n" + "\n" +
                            "Seat Fare: " + fare.GetSeatFare().ToString("c") + "\n" +
                            "Number of Seats: " + fare.GetNumberOfSeats() + "\n" +
                            "Total Seat Fare: " + fare.GetTotalSeatFare().ToString("c") + "\n" + "\n" +
                            "Luggage Fare(per KG): " + luggage.GetLuggageFarePerKG().ToString("c") + "\n" +
                            "Total Luggage Weight: " + luggage.GetTotalWeight()+ " Kg" + "\n" +
                            "Total Luggage Price: " + luggage.GetTotalLuggagePrice().ToString("c") + "\n" + "\n" +
                            "Total Fare: " + totalFare.ToString("c");

            DialogResult result = MessageBox.Show(output, "Train Ticket Reservation",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                resetForm();
            }
        }

        private void resetForm()
        {
            txtContact.Text = "";
            txtCustomerName.Text = "";
            txtNumberOfSeat.Text = "";
            txtReservationID.Text = "";
            txtTotalWeight.Text = "";

            grpBxTicketInformation.Hide();
            grpBxCustomerInformation.Enabled = true;
            btnNext.Show();

        }
    }
}
