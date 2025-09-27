using Core.Domain;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormEmployee : Form
    {
        private TransportationCenter Center;
        private Employee CurrentEmployee;
        private Ride? SelectedRide;
        //Adding ? fixes the warning for non nullable fields
        //With ? i declare that this field can be null?

        public FormEmployee(TransportationCenter center, Employee employee)
        {
            InitializeComponent();
            Center = center;
            CurrentEmployee = employee;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome {CurrentEmployee.FirstName} {CurrentEmployee.LastName}!");
            UpdateRideListBox();
        }


        //Listboxes
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
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelRide_Click(object sender, EventArgs e)
        {

        }
        private void buttonViewPersonnel_Click(object sender, EventArgs e)
        {

        }
        private void buttonViewVehicles_Click(object sender, EventArgs e)
        {

        }


        //Methods
        private void UpdateRideListBox()
        {
            listBoxAllRides.Items.Clear();
            if (CurrentEmployee.Rides.Count == 0)
            {
                listBoxAllRides.Items.Add("There are no rides booked for you.");
                return;
            }
            else
            {
                foreach (Ride ride in CurrentEmployee.Rides)
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
            textBoxDistance.Text = $"{ride.Distance.ToString()} km";
            textBoxPrice.Text = $"€ {ride.Price.ToString()}";
        }
    }
}
