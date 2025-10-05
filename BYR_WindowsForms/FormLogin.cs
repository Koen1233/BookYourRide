using Core.Domain;

namespace BYR_WindowsForms
{
    public partial class FormLogin : Form
    {
        public TransportationCenter Center;
        

        public FormLogin()
        {
            InitializeComponent();
            Center = new TransportationCenter("Move");
            //Center = new TransportationCenter();//For testing without loading hardcoded data
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }


        //button and link clicks
        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration(Center);
            this.Hide();
            formRegistration.ShowDialog();
            this.Show();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
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
                        FormEmployee formEmployee = new FormEmployee(Center, Center.Employees[i]);
                        this.Hide();
                        formEmployee.ShowDialog();
                        this.Show();
                        textBoxEmail.Clear();
                        textBoxPassword.Clear();
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
                        FormCustomer formCustomer = new FormCustomer(Center, Center.Customers[i]);
                        this.Hide();
                        formCustomer.ShowDialog();
                        this.Show();
                        textBoxEmail.Clear();
                        textBoxPassword.Clear();
                        return;
                    }
                }
            }
            MessageBox.Show("Email or password is incorrect");
        }
    }
}
