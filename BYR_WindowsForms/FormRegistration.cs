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
    public partial class FormRegistration : Form
    {
        public TransportationCenter Center;


        public FormRegistration(TransportationCenter center)
        {
            InitializeComponent();
            Center = center;
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        //buttons
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            ////Check for empty fields
            //if (textBoxEmail.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxPassword.Text == "" || textBoxRepeatEmail.Text == "" || textBoxRepeatPassword.Text == "")
            //{
            //    MessageBox.Show("Please fill in all fields!");
            //    return;
            //}
            ////Check for matching emails and passwords
            //else if (textBoxEmail.Text == textBoxRepeatEmail.Text && textBoxPassword.Text == textBoxRepeatPassword.Text)
            //{
            //    bool succesfullCreation = Center.TryRegistrate(textBoxEmail.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxPassword.Text);
            //    if (succesfullCreation == false)
            //    {
            //        MessageBox.Show("This Email address allready has an account!");
            //        return;
            //    }
            //    else if (succesfullCreation == true)
            //    {
            //        MessageBox.Show("Account created successfully!");
            //        this.Close();
            //        return;
            //}
            //else
            //{
            //    MessageBox.Show("Emails or passwords do not match!");
            //}
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
