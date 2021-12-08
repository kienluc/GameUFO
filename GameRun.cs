using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Linq.Expressions;
using System.Reflection;
using System.Diagnostics.Contracts;
using System.Media;
using System.Runtime.CompilerServices;

namespace RepelTheUFO
{
    public partial class GameRun : Form
    {
        int recovSpeed = 15;
        int playerSpeed = 10;
        int ufoSpeed = 3;
        int bulletSpeed = 15;
        int ufoBulletSpeed = 5;
        int index;
        int count = 0;
        int playerLife = 3;
        
        Random random = new Random();
        System.Media.SoundPlayer playerShot = new System.Media.SoundPlayer(@"C:\Users\DELL\Desktop\RepelTheUFO\bin\Debug\shot.wav");
        System.Media.SoundPlayer explodeSound = new System.Media.SoundPlayer(@"C:\Users\DELL\Desktop\RepelTheUFO\bin\Debug\Explode.wav");
        bool playerMoveUp;
        bool playerMoveDown;
        bool playerMoveLeft;
        bool playerMoveRight;
        bool shot;
        public GameRun()
        {
            InitializeComponent();
        }

        private void GameRun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                playerMoveUp = true;
            if (e.KeyCode == Keys.Down)
                playerMoveDown = true;
            if (e.KeyCode == Keys.Left)
                playerMoveLeft = true;
            if (e.KeyCode == Keys.Right)
                playerMoveRight = true;
            if (e.KeyCode == Keys.Space && shot == false)
            {
                createBullet(ChooseCharacter.index);
                shot = true;
                
            }
        }

        private void GameRun_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                playerMoveUp = false;
            if (e.KeyCode == Keys.Down)
                playerMoveDown = false;
            if (e.KeyCode == Keys.Left)
                playerMoveLeft = false;
            if (e.KeyCode == Keys.Right)
                playerMoveRight = false;
            if (e.KeyCode == Keys.Space)
                shot = false;
        }
       

        private void timerGameRun_Tick(object sender, EventArgs e)
        {
            // di chuyển Player
            if (playerMoveUp && player.Top >= 10)
                player.Top -= playerSpeed;
            if (playerMoveDown && player.Bottom < ClientRectangle.Height - 10)
                player.Top += playerSpeed;
            if (playerMoveLeft && player.Left >= 10)
                player.Left -= playerSpeed;
            if (playerMoveRight && player.Right <= ClientRectangle.Width - 10)
                player.Left += playerSpeed;
            if (count % 5 == 0)
            {
                levelUp();
            }

            foreach (Control x in this.Controls)
            {
                //di chuyển recovery
                if(x is PictureBox && x.Tag == "recov")
                {
                    x.Left -= recovSpeed;
                    if(x.Left <=0)
                    {
                        delete((PictureBox)x);
                    }
                    foreach (Control y in this.Controls)
                    {
                        if(y is PictureBox && y.Tag == "players")
                        {
                            if(y.Bounds.IntersectsWith(x.Bounds))
                            {
                                delete((PictureBox)x);
                                switch(playerLife)
                                {
                                    case 2:
                                        {
                                            pictureBox3.Visible = true;
                                            playerLife++;
                                            break;
                                        }
                                    case 1:
                                        {
                                            pictureBox2.Visible = true;
                                            playerLife++;
                                            break;
                                        }
                                }
                            }    
                        }    
                    }    
                }
               
                // di chuyển UFO
                if (x is PictureBox && x.Tag == "ufo")
                {
                    x.Left -= ufoSpeed;
                    if (x.Left <= 0)
                    {
                        delete((PictureBox)x);
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                       
                    }
                }
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Left += bulletSpeed;
                    if (x.Left >= ClientRectangle.Width)
                    {
                        delete((PictureBox)x);
                    }
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && y.Tag == "ufo")
                        {
                            if (x.Bounds.IntersectsWith(y.Bounds))
                            {  
                                Explode((PictureBox)y);
                                
                                count++;
                                score.Text = count.ToString();
                                delete((PictureBox)y);
                                delete((PictureBox)x);
                            }
                        }
                    }

                }
                
                if (x is PictureBox && x.Tag == "bullet_ufo")
                {
                    x.Left -= ufoBulletSpeed;
                    if (x.Left <= 0)
                    {
                        delete((PictureBox)x);
                    }
                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        playerLife--;
                        
                        switch (playerLife)
                        {
                            case 2:
                                pictureBox3.Visible = false;
                                break;
                            case 1:
                                pictureBox2.Visible = false;
                                break;
                            case 0:
                                pictureBox1.Visible = false;
                                break;
                        }    
                        delete((PictureBox)x);
                    }
                }   
                if (playerLife == 0)
                {
                    explodeSound.Play();
                    Explode(player);
                    gameOver();
                }
                
            }
        }
        private void createBullet(int i)
        {
            i = ChooseCharacter.index;
            playerShot.Play();
            PictureBox bullet = new PictureBox();
            bullet.Tag = "bullet";
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.BackColor = TransparencyKey;
            switch(i)
            {
                case 1:
                    bullet.Image = Properties.Resources.bullet2;
                    break;
                case 2:
                    bullet.Image = Properties.Resources.bullet1;
                    break;
            }
            bullet.Height = 7;
            bullet.Width = 15;
            bullet.Left = player.Left + player.Width;
            bullet.Top = (player.Top + player.Height / 2) + 6;
            this.Controls.Add(bullet);
        }
        private void createBullet_ufo(PictureBox x)
        {
            PictureBox bullet = new PictureBox();
            bullet.Tag = "bullet_ufo";
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.BackColor = Color.DarkRed;
            bullet.Height = 2;
            bullet.Width = 15;
            bullet.Location = new Point(x.Left, x.Top + x.Height / 2);
            this.Controls.Add(bullet);
        }
        private void createUFO()
        {
            timerUFObullet.Enabled = true;
            PictureBox ufo = new PictureBox();
            ufo.Tag = "ufo";
            ufo.Height = 50;
            ufo.Width = 70;
            ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo.BackColor = TransparencyKey;
            index = random.Next(1, 4);
            ufo.Left = ClientRectangle.Width + 2;
            ufo.Top = random.Next(10, 400);
            
            switch (index)
            {
                case 1:
                    ufo.Image = Properties.Resources.ufo1;
                    break;
                case 2:
                    ufo.Image = Properties.Resources.ufo2;
                    break;
                case 3:
                    ufo.Image = Properties.Resources.ufo3;
                    break;
            }

            this.Controls.Add(ufo);

        }
        private void createRecover()
        { 
            PictureBox recov = new PictureBox();
            recov.Image = Properties.Resources.heart2;
            recov.Tag = "recov";
            recov.Height = 20;
            recov.Width = 30;
            recov.SizeMode = PictureBoxSizeMode.StretchImage;
            recov.BackColor = TransparencyKey;
            recov.Left = ClientRectangle.Width + 3;
            recov.Top = random.Next(10, 450);
            this.Controls.Add(recov);
           
        }
        private void Explode(PictureBox y)
        {
           
            PictureBox explode = new PictureBox();
            explode.Height = 40;
            explode.Width = 60;
            explode.Image = Properties.Resources.boom;
            explode.Tag = "explode";
            explode.Location = y.Location;
            explode.SizeMode = PictureBoxSizeMode.StretchImage;
            explode.BackColor = Color.Transparent;
            this.Controls.Add(explode);
            timerExplode.Enabled = true;
        }
        private void delete(PictureBox x)
        {
            this.Controls.Remove(x);
            x.Dispose();
        }
        private void levelUp()
        {
            timerUFO.Interval = 2000;
            ufoSpeed = 5;
            ufoBulletSpeed = 8;
        }

        private void gameOver()
        {
            this.Controls.Remove(player);
            timerGameRun.Stop();
            timerUFObullet.Stop();
        }
        private void timerUFO_Tick(object sender, EventArgs e)
        {
            createUFO();
        }

        private void timerExplode_Tick(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "explode")
                {
                    delete((PictureBox)x);
                }
            }
        }

        private void timerUFObullet_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ufo")
                {
                    createBullet_ufo((PictureBox)x);
                }
            }    
        }

        private void GameRun_Load(object sender, EventArgs e)
        {
            setImagePlayer();
        }

        private void setImagePlayer()
        {
            switch(ChooseCharacter.index)
            {
                case 1:
                    player.Image = Properties.Resources.player2;
                    
                    break;
                case 2:
                    player.Image = Properties.Resources.player1;
                   
                    break;
            }
        }

        private void timerRecover_Tick(object sender, EventArgs e)
        {
            createRecover();
        }

        
    }
}
