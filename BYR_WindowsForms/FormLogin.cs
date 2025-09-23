using Core.Domain;

namespace BYR_WindowsForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TransportationCenter move = new TransportationCenter("Move");
        }
    }
}
