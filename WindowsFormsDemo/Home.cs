using System;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Main"].Show();
        }
    }
}
