namespace Meduris
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.tbj1 = new System.Windows.Forms.TextBox();
            this.tbj3 = new System.Windows.Forms.TextBox();
            this.tbj2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 752);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Moccasin;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(680, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(197, 60);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Commencer";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tbj1
            // 
            this.tbj1.BackColor = System.Drawing.Color.Moccasin;
            this.tbj1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbj1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbj1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbj1.Location = new System.Drawing.Point(614, 91);
            this.tbj1.Name = "tbj1";
            this.tbj1.Size = new System.Drawing.Size(274, 48);
            this.tbj1.TabIndex = 2;
            this.tbj1.Text = "Joueur 1";
            this.tbj1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbj3
            // 
            this.tbj3.BackColor = System.Drawing.Color.Moccasin;
            this.tbj3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbj3.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbj3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbj3.Location = new System.Drawing.Point(614, 282);
            this.tbj3.Name = "tbj3";
            this.tbj3.Size = new System.Drawing.Size(274, 48);
            this.tbj3.TabIndex = 3;
            this.tbj3.Text = "Joueur 3";
            this.tbj3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbj2
            // 
            this.tbj2.BackColor = System.Drawing.Color.Moccasin;
            this.tbj2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbj2.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbj2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbj2.Location = new System.Drawing.Point(614, 183);
            this.tbj2.Name = "tbj2";
            this.tbj2.Size = new System.Drawing.Size(274, 48);
            this.tbj2.TabIndex = 4;
            this.tbj2.Text = "Joueur 2";
            this.tbj2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Meduris.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1009, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbj2);
            this.Controls.Add(this.tbj3);
            this.Controls.Add(this.tbj1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox tbj1;
        private System.Windows.Forms.TextBox tbj3;
        private System.Windows.Forms.TextBox tbj2;
        private System.Windows.Forms.Button button2;
    }
}