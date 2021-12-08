using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepelTheUFO
{
    public partial class ChoosePlayer : Form
    {
        public ChoosePlayer()
        {
            InitializeComponent();
        }
        
        
        private void bt_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch(btn.Tag)
            {
                case "btChar1":
                    ChooseCharacter.index = 1;
                    break;
                case "btChar2":
                    ChooseCharacter.index = 2;
                    break;
            }
            GameRun game = new GameRun();
            game.ShowDialog();
        }

        private void ChoosePlayer_Load(object sender, EventArgs e)
        {
            btCharacter1.Click += bt_Click;
            btCharacter2.Click += bt_Click;
            
        }

        private void btCharacter2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
        }

        private void btCharacter2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
       
    }
}
