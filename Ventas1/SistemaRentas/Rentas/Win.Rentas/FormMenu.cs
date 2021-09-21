using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void sushiToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMenu = new FormMenu();
            formMenu.MdiParent= this;
            formMenu.Show();
        }
    }
}
