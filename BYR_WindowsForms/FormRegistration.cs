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
    }
}
