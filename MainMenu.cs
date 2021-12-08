using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepelTheUFO
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void btStart_Click(object sender, EventArgs e)
        {
            ChoosePlayer choice = new ChoosePlayer();
            choice.ShowDialog();
            this.Close();
            
            
        }

        private void btTutorial_Click(object sender, EventArgs e)
        {
            Tutorial tut = new Tutorial();
            tut.ShowDialog();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Are you sure to quit?", "Quit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        

    }
}
