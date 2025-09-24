using Core.Domain;

namespace BYR_WindowsForms
{
    public partial class FormLogin : Form
    {
        public TransportationCenter Center;
        internal bool isEmployee;

        public FormLogin()
        {
            InitializeComponent();
            Center = new TransportationCenter("Move");
            //Center = new TransportationCenter();//Testing without hardcoded data
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration(Center);
            formRegistration.Show();
        }



        private void buttonLogin_click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i =0; i < Center.Employees.Count; i++)
                {
                    if(textBoxEmail.Text == Center.Employees[i].Email && textBoxPassword.Text == Center.Employees[i].Password)
                    {
                        MessageBox.Show("Login successful!");
                        //FormEmployee formEmployee = new FormEmployee(Center);
                        //formEmployee.Show();
                        //this.Hide();
                        return;
                    }
                }
            }
            else if (checkBox1.Checked == false)
            {
                for (int i = 0; i < Center.Customers.Count; i++)
                {
                    if (textBoxEmail.Text == Center.Customers[i].Email && textBoxPassword.Text == Center.Customers[i].Password)
                    {
                        MessageBox.Show("Login successful!");
                        //FormCustomer formCustomer = new FormCustomer(Center, Center.Customers[i]);
                        //formCustomer.Show();
                        //this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Email or password is incorrect");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                isEmployee = true;
                return;
            }
            else if (checkBox1.Checked == false)
            {
                isEmployee = false;
            }
        }
    }
}
