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
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonLogin_click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration(Center);
            formRegistration.Show();
        }
    }
}
