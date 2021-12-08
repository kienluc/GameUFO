namespace RepelTheUFO
{
    partial class ChoosePlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.btCharacter1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCharacter2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RepelTheUFO.Properties.Resources.mainmenu3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.btCharacter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 585);
            this.panel1.TabIndex = 0;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(1201, 489);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(99, 55);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btCharacter1
            // 
            this.btCharacter1.BackColor = System.Drawing.Color.Transparent;
            this.btCharacter1.BackgroundImage = global::RepelTheUFO.Properties.Resources.btSelect;
            this.btCharacter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCharacter1.Location = new System.Drawing.Point(260, 374);
            this.btCharacter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCharacter1.Name = "btCharacter1";
            this.btCharacter1.Size = new System.Drawing.Size(190, 33);
            this.btCharacter1.TabIndex = 2;
            this.btCharacter1.Tag = "btChar1";
            this.btCharacter1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btCharacter2);
            this.panel2.Location = new System.Drawing.Point(788, 366);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 80);
            this.panel2.TabIndex = 4;
            // 
            // btCharacter2
            // 
            this.btCharacter2.BackColor = System.Drawing.Color.Transparent;
            this.btCharacter2.BackgroundImage = global::RepelTheUFO.Properties.Resources.btSelect;
            this.btCharacter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCharacter2.Location = new System.Drawing.Point(5, 2);
            this.btCharacter2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCharacter2.Name = "btCharacter2";
            this.btCharacter2.Size = new System.Drawing.Size(174, 35);
            this.btCharacter2.TabIndex = 3;
            this.btCharacter2.Tag = "btChar2";
            this.btCharacter2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::RepelTheUFO.Properties.Resources.player1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(706, 174);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 173);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RepelTheUFO.Properties.Resources.player2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(180, 174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ChoosePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 586);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoosePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoosePlayer";
            this.Load += new System.EventHandler(this.ChoosePlayer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btCharacter1;
        private System.Windows.Forms.Button btCharacter2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBack;
    }
}