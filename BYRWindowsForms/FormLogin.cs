using Core.Domain;

namespace BYRWindowsForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TransportationCenter move = new TransportationCenter("Move");
            
        }
    }
}
