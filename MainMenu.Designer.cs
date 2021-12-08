namespace RepelTheUFO
{
    partial class MainMenu
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
            this.btQuit = new System.Windows.Forms.Button();
            this.btTutorial = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::RepelTheUFO.Properties.Resources.mainmenu3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btQuit);
            this.panel1.Controls.Add(this.btTutorial);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 578);
            this.panel1.TabIndex = 2;
            
            // 
            // btQuit
            // 
            this.btQuit.BackgroundImage = global::RepelTheUFO.Properties.Resources.btQuit;
            this.btQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btQuit.Location = new System.Drawing.Point(466, 499);
            this.btQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(291, 52);
            this.btQuit.TabIndex = 2;
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btTutorial
            // 
            this.btTutorial.BackgroundImage = global::RepelTheUFO.Properties.Resources.btTutorial;
            this.btTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTutorial.Location = new System.Drawing.Point(466, 415);
            this.btTutorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTutorial.Name = "btTutorial";
            this.btTutorial.Size = new System.Drawing.Size(291, 52);
            this.btTutorial.TabIndex = 1;
            this.btTutorial.UseVisualStyleBackColor = true;
            this.btTutorial.Click += new System.EventHandler(this.btTutorial_Click);
            // 
            // btStart
            // 
            this.btStart.BackgroundImage = global::RepelTheUFO.Properties.Resources.btnStart;
            this.btStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btStart.Location = new System.Drawing.Point(466, 334);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(291, 52);
            this.btStart.TabIndex = 0;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 578);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btTutorial;
    }
}