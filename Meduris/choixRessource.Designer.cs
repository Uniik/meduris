namespace Meduris
{
    partial class ChoixRessource
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
            this.label = new System.Windows.Forms.Label();
            this.laineBtn = new System.Windows.Forms.Button();
            this.BoisBtn = new System.Windows.Forms.Button();
            this.pierreBtn = new System.Windows.Forms.Button();
            this.CuivreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(75, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(429, 24);
            this.label.TabIndex = 0;
            this.label.Text = "Choisissez la ressource à ";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laineBtn
            // 
            this.laineBtn.BackgroundImage = global::Meduris.Properties.Resources.laineICO;
            this.laineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.laineBtn.Location = new System.Drawing.Point(75, 118);
            this.laineBtn.Name = "laineBtn";
            this.laineBtn.Size = new System.Drawing.Size(100, 100);
            this.laineBtn.TabIndex = 1;
            this.laineBtn.UseVisualStyleBackColor = true;
            this.laineBtn.Click += new System.EventHandler(this.laineBtn_Click);
            // 
            // BoisBtn
            // 
            this.BoisBtn.BackgroundImage = global::Meduris.Properties.Resources.BoisICO;
            this.BoisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoisBtn.Location = new System.Drawing.Point(192, 118);
            this.BoisBtn.Name = "BoisBtn";
            this.BoisBtn.Size = new System.Drawing.Size(100, 100);
            this.BoisBtn.TabIndex = 2;
            this.BoisBtn.UseVisualStyleBackColor = true;
            this.BoisBtn.Click += new System.EventHandler(this.BoisBtn_Click);
            // 
            // pierreBtn
            // 
            this.pierreBtn.BackgroundImage = global::Meduris.Properties.Resources.PierreICO;
            this.pierreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pierreBtn.Location = new System.Drawing.Point(298, 118);
            this.pierreBtn.Name = "pierreBtn";
            this.pierreBtn.Size = new System.Drawing.Size(100, 100);
            this.pierreBtn.TabIndex = 3;
            this.pierreBtn.UseVisualStyleBackColor = true;
            this.pierreBtn.Click += new System.EventHandler(this.pierreBtn_Click);
            // 
            // CuivreBtn
            // 
            this.CuivreBtn.BackgroundImage = global::Meduris.Properties.Resources.CuivreICO;
            this.CuivreBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CuivreBtn.Location = new System.Drawing.Point(404, 118);
            this.CuivreBtn.Name = "CuivreBtn";
            this.CuivreBtn.Size = new System.Drawing.Size(100, 100);
            this.CuivreBtn.TabIndex = 4;
            this.CuivreBtn.UseVisualStyleBackColor = true;
            this.CuivreBtn.Click += new System.EventHandler(this.CuivreBtn_Click);
            // 
            // ChoixRessource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Meduris.Properties.Resources.whiteBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 288);
            this.Controls.Add(this.CuivreBtn);
            this.Controls.Add(this.pierreBtn);
            this.Controls.Add(this.BoisBtn);
            this.Controls.Add(this.laineBtn);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoixRessource";
            this.Text = "choixRessource";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button laineBtn;
        private System.Windows.Forms.Button BoisBtn;
        private System.Windows.Forms.Button pierreBtn;
        private System.Windows.Forms.Button CuivreBtn;
    }
}