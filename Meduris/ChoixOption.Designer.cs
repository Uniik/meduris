namespace Meduris
{
    partial class ChoixOption
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
            this.GrandeExploitation = new System.Windows.Forms.Button();
            this.ConstruireHutte = new System.Windows.Forms.Button();
            this.ConstruireTemple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(71, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(436, 23);
            this.label.TabIndex = 0;
            this.label.Text = ", Choisissez l\'action à faire";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrandeExploitation
            // 
            this.GrandeExploitation.BackgroundImage = global::Meduris.Properties.Resources.grande_exploitation;
            this.GrandeExploitation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GrandeExploitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandeExploitation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GrandeExploitation.Location = new System.Drawing.Point(12, 82);
            this.GrandeExploitation.Name = "GrandeExploitation";
            this.GrandeExploitation.Size = new System.Drawing.Size(167, 176);
            this.GrandeExploitation.TabIndex = 1;
            this.GrandeExploitation.Text = "Grande exploitation";
            this.GrandeExploitation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GrandeExploitation.UseVisualStyleBackColor = true;
            this.GrandeExploitation.Click += new System.EventHandler(this.GrandeExploitation_Click);
            // 
            // ConstruireHutte
            // 
            this.ConstruireHutte.BackgroundImage = global::Meduris.Properties.Resources.construire__hutte;
            this.ConstruireHutte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConstruireHutte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstruireHutte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConstruireHutte.Location = new System.Drawing.Point(205, 82);
            this.ConstruireHutte.Name = "ConstruireHutte";
            this.ConstruireHutte.Size = new System.Drawing.Size(167, 176);
            this.ConstruireHutte.TabIndex = 2;
            this.ConstruireHutte.Text = "Construire une hutte";
            this.ConstruireHutte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConstruireHutte.UseVisualStyleBackColor = true;
            this.ConstruireHutte.Click += new System.EventHandler(this.ConstruireHutte_Click);
            // 
            // ConstruireTemple
            // 
            this.ConstruireTemple.BackgroundImage = global::Meduris.Properties.Resources.construire__temple;
            this.ConstruireTemple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConstruireTemple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstruireTemple.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConstruireTemple.Location = new System.Drawing.Point(395, 82);
            this.ConstruireTemple.Name = "ConstruireTemple";
            this.ConstruireTemple.Size = new System.Drawing.Size(167, 176);
            this.ConstruireTemple.TabIndex = 3;
            this.ConstruireTemple.Text = "Construire un temple";
            this.ConstruireTemple.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConstruireTemple.UseVisualStyleBackColor = true;
            // 
            // ChoixOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Meduris.Properties.Resources.whiteBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 288);
            this.Controls.Add(this.ConstruireTemple);
            this.Controls.Add(this.ConstruireHutte);
            this.Controls.Add(this.GrandeExploitation);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoixOption";
            this.Text = "ChoixOption";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button GrandeExploitation;
        private System.Windows.Forms.Button ConstruireHutte;
        private System.Windows.Forms.Button ConstruireTemple;
    }
}