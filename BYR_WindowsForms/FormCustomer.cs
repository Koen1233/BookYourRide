using Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BYR_WindowsForms
{
    public partial class FormCustomer : Form
    {
        public TransportationCenter Center;
        public Customer CurrentCustomer;
        private Ride? SelectedRide;

        public FormCustomer(TransportationCenter center, Customer customer)
        {
            InitializeComponent();
            Center = center;
            CurrentCustomer = customer;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome {CurrentCustomer.FirstName} {CurrentCustomer.LastName}!");
            UpdateRideListBox();
        }


        private void listBoxAllRides_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedRide = listBoxAllRides.SelectedItem as Ride;

            if (SelectedRide == null)
            {
                ClearTextBoxes();
                buttonCancelRide.Enabled = false;
            }
            else
            {
                UpdateTextBoxes(SelectedRide);
                buttonCancelRide.Enabled = true;
            }
        }

        private void listBoxAllRides_MouseDown(object sender, MouseEventArgs e)
        {
            //solution from other project for deselecting items in a listbox

            int index = listBoxAllRides.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
            {
                listBoxAllRides.ClearSelected();
                SelectedRide = null;
            }
        }




        //buttons
        private void buttonBookaRide_Click(object sender, EventArgs e)
        {
            CurrentCustomer.BookRide(Center);
        }

        private void buttonCancelRide_Click(object sender, EventArgs e)
        {

        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        //Methods
        private void UpdateRideListBox()
        {
            listBoxAllRides.Items.Clear();
            if(CurrentCustomer.Rides.Count == 0)
            {
                listBoxAllRides.Items.Add("No rides booked yet.");
                return;
            }
            else
            {
                foreach (Ride ride in CurrentCustomer.Rides)
                {
                    listBoxAllRides.Items.Add(ride);
                }
            } 
        }

        private void ClearTextBoxes()
        {
            textBoxDistance.Clear();
            textBoxPrice.Clear();
        }
        private void UpdateTextBoxes(Ride ride)
        {
            textBoxDistance.Text = ride.Distance.ToString();
            textBoxPrice.Text = ride.Price.ToString();
        }

       
    }
}
