using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRepository.AppForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.WindowState = FormWindowState.Maximized;
            main.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPass.ResetText();
            txtUser.ResetText();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DBContext dB = new DBContext();
        }
    }
}
