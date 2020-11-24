using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarShip
{
    public partial class menu : Form
        
    {
        public static menu m;
        public menu()
        {
            InitializeComponent();
            m = this;
        }

        private void Mode_Click(object sender, EventArgs e)
        {
            Mode formmode = new Mode();
            this.Hide();
            formmode.Show();
        }

        private void Author_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     War... War never changed..." + "\n" + "Developer : Pargachev Alexey" + "\n" + "Все права защищены     2020");
        }

        private void butExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
