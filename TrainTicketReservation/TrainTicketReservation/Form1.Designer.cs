namespace TrainTicketReservation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.grpBxTicketInformation = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.txtNumberOfSeat = new System.Windows.Forms.TextBox();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblLuggageFarePerKG = new System.Windows.Forms.Label();
            this.lblNumberOfSeat = new System.Windows.Forms.Label();
            this.lblSeatFare = new System.Windows.Forms.Label();
            this.grpBxCustomerInformation.SuspendLayout();
            this.grpBxTicketInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Train Ticket Reservation";
            // 
            // grpBxCustomerInformation
            // 
            this.grpBxCustomerInformation.Controls.Add(this.btnNext);
            this.grpBxCustomerInformation.Controls.Add(this.txtContact);
            this.grpBxCustomerInformation.Controls.Add(this.txtCustomerName);
            this.grpBxCustomerInformation.Controls.Add(this.txtReservationID);
            this.grpBxCustomerInformation.Controls.Add(this.lblContact);
            this.grpBxCustomerInformation.Controls.Add(this.lblCustomerName);
            this.grpBxCustomerInformation.Controls.Add(this.lblReservationID);
            this.grpBxCustomerInformation.Location = new System.Drawing.Point(12, 80);
            this.grpBxCustomerInformation.Name = "grpBxCustomerInformation";
            this.grpBxCustomerInformation.Size = new System.Drawing.Size(394, 231);
            this.grpBxCustomerInformation.TabIndex = 0;
            this.grpBxCustomerInformation.TabStop = false;
            this.grpBxCustomerInformation.Text = "Customer Information";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(166, 174);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(166, 115);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(188, 22);
            this.txtContact.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(166, 78);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(188, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(166, 40);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(188, 22);
            this.txtReservationID.TabIndex = 0;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(37, 115);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(122, 17);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact Number : ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(38, 78);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(121, 17);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name : ";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Location = new System.Drawing.Point(46, 40);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(113, 17);
            this.lblReservationID.TabIndex = 0;
            this.lblReservationID.Text = "Reservation ID : ";
            // 
            // grpBxTicketInformation
            // 
            this.grpBxTicketInformation.Controls.Add(this.btnSubmit);
            this.grpBxTicketInformation.Controls.Add(this.label7);
            this.grpBxTicketInformation.Controls.Add(this.label6);
            this.grpBxTicketInformation.Controls.Add(this.txtTotalWeight);
            this.grpBxTicketInformation.Controls.Add(this.txtNumberOfSeat);
            this.grpBxTicketInformation.Controls.Add(this.lblTotalWeight);
            this.grpBxTicketInformation.Controls.Add(this.lblLuggageFarePerKG);
            this.grpBxTicketInformation.Controls.Add(this.lblNumberOfSeat);
            this.grpBxTicketInformation.Controls.Add(this.lblSeatFare);
            this.grpBxTicketInformation.Location = new System.Drawing.Point(447, 80);
            this.grpBxTicketInformation.Name = "grpBxTicketInformation";
            this.grpBxTicketInformation.Size = new System.Drawing.Size(326, 231);
            this.grpBxTicketInformation.TabIndex = 1;
            this.grpBxTicketInformation.TabStop = false;
            this.grpBxTicketInformation.Text = "Ticket Information";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(102, 199);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Luggage Fare Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seat Fare informaton";
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Location = new System.Drawing.Point(170, 171);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(149, 22);
            this.txtTotalWeight.TabIndex = 1;
            // 
            // txtNumberOfSeat
            // 
            this.txtNumberOfSeat.Location = new System.Drawing.Point(170, 80);
            this.txtNumberOfSeat.Name = "txtNumberOfSeat";
            this.txtNumberOfSeat.Size = new System.Drawing.Size(149, 22);
            this.txtNumberOfSeat.TabIndex = 0;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Location = new System.Drawing.Point(64, 174);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(100, 17);
            this.lblTotalWeight.TabIndex = 3;
            this.lblTotalWeight.Text = "Total Weight : ";
            // 
            // lblLuggageFarePerKG
            // 
            this.lblLuggageFarePerKG.AutoSize = true;
            this.lblLuggageFarePerKG.Location = new System.Drawing.Point(6, 141);
            this.lblLuggageFarePerKG.Name = "lblLuggageFarePerKG";
            this.lblLuggageFarePerKG.Size = new System.Drawing.Size(158, 17);
            this.lblLuggageFarePerKG.TabIndex = 2;
            this.lblLuggageFarePerKG.Text = "Luggage Fare per KG : ";
            // 
            // lblNumberOfSeat
            // 
            this.lblNumberOfSeat.AutoSize = true;
            this.lblNumberOfSeat.Location = new System.Drawing.Point(45, 83);
            this.lblNumberOfSeat.Name = "lblNumberOfSeat";
            this.lblNumberOfSeat.Size = new System.Drawing.Size(119, 17);
            this.lblNumberOfSeat.TabIndex = 1;
            this.lblNumberOfSeat.Text = "Number of Seat : ";
            // 
            // lblSeatFare
            // 
            this.lblSeatFare.AutoSize = true;
            this.lblSeatFare.Location = new System.Drawing.Point(57, 56);
            this.lblSeatFare.Name = "lblSeatFare";
            this.lblSeatFare.Size = new System.Drawing.Size(107, 17);
            this.lblSeatFare.TabIndex = 0;
            this.lblSeatFare.Text = "Fare per Seat : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBxTicketInformation);
            this.Controls.Add(this.grpBxCustomerInformation);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Train";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxCustomerInformation.ResumeLayout(false);
            this.grpBxCustomerInformation.PerformLayout();
            this.grpBxTicketInformation.ResumeLayout(false);
            this.grpBxTicketInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxCustomerInformation;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grpBxTicketInformation;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblLuggageFarePerKG;
        private System.Windows.Forms.Label lblNumberOfSeat;
        private System.Windows.Forms.Label lblSeatFare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.TextBox txtNumberOfSeat;
        private System.Windows.Forms.Button btnSubmit;
    }
}

