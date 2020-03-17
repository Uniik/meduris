using System.Drawing;

namespace Meduris
{
    partial class Meduris
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meduris));
            this.plateau = new System.Windows.Forms.Panel();
            this.p1Panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.J1H = new System.Windows.Forms.Label();
            this.J1T = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.J1C = new System.Windows.Forms.Label();
            this.J1P = new System.Windows.Forms.Label();
            this.J1B = new System.Windows.Forms.Label();
            this.J1L = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.J1PDV = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.Label();
            this.p2Panel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.J2H = new System.Windows.Forms.Label();
            this.J2T = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.J2C = new System.Windows.Forms.Label();
            this.J2P = new System.Windows.Forms.Label();
            this.J2B = new System.Windows.Forms.Label();
            this.J2L = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.J2PDV = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.p3Panel = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.J3H = new System.Windows.Forms.Label();
            this.J3T = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.J3C = new System.Windows.Forms.Label();
            this.J3P = new System.Windows.Forms.Label();
            this.J3B = new System.Windows.Forms.Label();
            this.J3L = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.J3PDV = new System.Windows.Forms.Label();
            this.Player3Name = new System.Windows.Forms.Label();
            this.scopePanel = new System.Windows.Forms.Panel();
            this.Logs = new System.Windows.Forms.RichTextBox();
            this.p1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.p3Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            this.SuspendLayout();
            // 
            // plateau
            // 
            this.plateau.BackgroundImage = global::Meduris.Properties.Resources.Planche_3joueurs_Large;
            resources.ApplyResources(this.plateau, "plateau");
            this.plateau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plateau.Name = "plateau";
            this.plateau.Click += new System.EventHandler(this.plateau_Click);
            this.plateau.MouseEnter += new System.EventHandler(this.Plateau_MouseEnter);
            this.plateau.MouseLeave += new System.EventHandler(this.Plateau_MouseLeave);
            // 
            // p1Panel
            // 
            this.p1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.p1Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1Panel.Controls.Add(this.label13);
            this.p1Panel.Controls.Add(this.flowLayoutPanel1);
            this.p1Panel.Controls.Add(this.J1H);
            this.p1Panel.Controls.Add(this.J1T);
            this.p1Panel.Controls.Add(this.pictureBox7);
            this.p1Panel.Controls.Add(this.pictureBox6);
            this.p1Panel.Controls.Add(this.J1C);
            this.p1Panel.Controls.Add(this.J1P);
            this.p1Panel.Controls.Add(this.J1B);
            this.p1Panel.Controls.Add(this.J1L);
            this.p1Panel.Controls.Add(this.pictureBox4);
            this.p1Panel.Controls.Add(this.pictureBox3);
            this.p1Panel.Controls.Add(this.pictureBox2);
            this.p1Panel.Controls.Add(this.pictureBox1);
            this.p1Panel.Controls.Add(this.label6);
            this.p1Panel.Controls.Add(this.J1PDV);
            this.p1Panel.Controls.Add(this.Player1Name);
            resources.ApplyResources(this.p1Panel, "p1Panel");
            this.p1Panel.Name = "p1Panel";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // J1H
            // 
            this.J1H.BackColor = System.Drawing.Color.Silver;
            this.J1H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J1H, "J1H");
            this.J1H.Name = "J1H";
            // 
            // J1T
            // 
            this.J1T.BackColor = System.Drawing.Color.Silver;
            this.J1T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J1T, "J1T");
            this.J1T.Name = "J1T";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Meduris.Properties.Resources.temple_bleu;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Meduris.Properties.Resources.hutte_bleu;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // J1C
            // 
            this.J1C.BackColor = System.Drawing.Color.Silver;
            this.J1C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J1C, "J1C");
            this.J1C.Name = "J1C";
            // 
            // J1P
            // 
            this.J1P.BackColor = System.Drawing.Color.Silver;
            this.J1P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J1P, "J1P");
            this.J1P.Name = "J1P";
            // 
            // J1B
            // 
            this.J1B.BackColor = System.Drawing.Color.Silver;
            this.J1B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J1B, "J1B");
            this.J1B.Name = "J1B";
            // 
            // J1L
            // 
            this.J1L.BackColor = System.Drawing.Color.Silver;
            this.J1L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J1L, "J1L");
            this.J1L.Name = "J1L";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Meduris.Properties.Resources.CuivreICO;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Meduris.Properties.Resources.PierreICO;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Meduris.Properties.Resources.BoisICO;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Meduris.Properties.Resources.laineICO;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Name = "label6";
            // 
            // J1PDV
            // 
            this.J1PDV.BackColor = System.Drawing.Color.Silver;
            this.J1PDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J1PDV, "J1PDV");
            this.J1PDV.Name = "J1PDV";
            // 
            // Player1Name
            // 
            resources.ApplyResources(this.Player1Name, "Player1Name");
            this.Player1Name.Name = "Player1Name";
            // 
            // p2Panel
            // 
            this.p2Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.p2Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2Panel.Controls.Add(this.label14);
            this.p2Panel.Controls.Add(this.flowLayoutPanel2);
            this.p2Panel.Controls.Add(this.J2H);
            this.p2Panel.Controls.Add(this.J2T);
            this.p2Panel.Controls.Add(this.pictureBox8);
            this.p2Panel.Controls.Add(this.pictureBox9);
            this.p2Panel.Controls.Add(this.J2C);
            this.p2Panel.Controls.Add(this.J2P);
            this.p2Panel.Controls.Add(this.J2B);
            this.p2Panel.Controls.Add(this.J2L);
            this.p2Panel.Controls.Add(this.pictureBox11);
            this.p2Panel.Controls.Add(this.pictureBox12);
            this.p2Panel.Controls.Add(this.pictureBox13);
            this.p2Panel.Controls.Add(this.pictureBox14);
            this.p2Panel.Controls.Add(this.J2PDV);
            this.p2Panel.Controls.Add(this.Player2Name);
            resources.ApplyResources(this.p2Panel, "p2Panel");
            this.p2Panel.Name = "p2Panel";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // J2H
            // 
            this.J2H.BackColor = System.Drawing.Color.Silver;
            this.J2H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J2H, "J2H");
            this.J2H.Name = "J2H";
            // 
            // J2T
            // 
            this.J2T.BackColor = System.Drawing.Color.Silver;
            this.J2T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J2T, "J2T");
            this.J2T.Name = "J2T";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Meduris.Properties.Resources.temple_rouge;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Meduris.Properties.Resources.hutte_rouge;
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // J2C
            // 
            this.J2C.BackColor = System.Drawing.Color.Silver;
            this.J2C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J2C, "J2C");
            this.J2C.Name = "J2C";
            // 
            // J2P
            // 
            this.J2P.BackColor = System.Drawing.Color.Silver;
            this.J2P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J2P, "J2P");
            this.J2P.Name = "J2P";
            // 
            // J2B
            // 
            this.J2B.BackColor = System.Drawing.Color.Silver;
            this.J2B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J2B, "J2B");
            this.J2B.Name = "J2B";
            // 
            // J2L
            // 
            this.J2L.BackColor = System.Drawing.Color.Silver;
            this.J2L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J2L, "J2L");
            this.J2L.Name = "J2L";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Meduris.Properties.Resources.CuivreICO;
            resources.ApplyResources(this.pictureBox11, "pictureBox11");
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Meduris.Properties.Resources.PierreICO;
            resources.ApplyResources(this.pictureBox12, "pictureBox12");
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Meduris.Properties.Resources.BoisICO;
            resources.ApplyResources(this.pictureBox13, "pictureBox13");
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Meduris.Properties.Resources.laineICO;
            resources.ApplyResources(this.pictureBox14, "pictureBox14");
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.TabStop = false;
            // 
            // J2PDV
            // 
            this.J2PDV.BackColor = System.Drawing.Color.Silver;
            this.J2PDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J2PDV, "J2PDV");
            this.J2PDV.Name = "J2PDV";
            // 
            // Player2Name
            // 
            resources.ApplyResources(this.Player2Name, "Player2Name");
            this.Player2Name.Name = "Player2Name";
            // 
            // p3Panel
            // 
            this.p3Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.p3Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p3Panel.Controls.Add(this.label23);
            this.p3Panel.Controls.Add(this.flowLayoutPanel3);
            this.p3Panel.Controls.Add(this.J3H);
            this.p3Panel.Controls.Add(this.J3T);
            this.p3Panel.Controls.Add(this.pictureBox15);
            this.p3Panel.Controls.Add(this.pictureBox16);
            this.p3Panel.Controls.Add(this.J3C);
            this.p3Panel.Controls.Add(this.J3P);
            this.p3Panel.Controls.Add(this.J3B);
            this.p3Panel.Controls.Add(this.J3L);
            this.p3Panel.Controls.Add(this.pictureBox18);
            this.p3Panel.Controls.Add(this.pictureBox19);
            this.p3Panel.Controls.Add(this.pictureBox20);
            this.p3Panel.Controls.Add(this.pictureBox21);
            this.p3Panel.Controls.Add(this.J3PDV);
            this.p3Panel.Controls.Add(this.Player3Name);
            resources.ApplyResources(this.p3Panel, "p3Panel");
            this.p3Panel.Name = "p3Panel";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Silver;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // J3H
            // 
            this.J3H.BackColor = System.Drawing.Color.Silver;
            this.J3H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J3H, "J3H");
            this.J3H.Name = "J3H";
            // 
            // J3T
            // 
            this.J3T.BackColor = System.Drawing.Color.Silver;
            this.J3T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J3T, "J3T");
            this.J3T.Name = "J3T";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Meduris.Properties.Resources.temple_vert;
            resources.ApplyResources(this.pictureBox15, "pictureBox15");
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Meduris.Properties.Resources.hutte_vert;
            resources.ApplyResources(this.pictureBox16, "pictureBox16");
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.TabStop = false;
            // 
            // J3C
            // 
            this.J3C.BackColor = System.Drawing.Color.Silver;
            this.J3C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J3C, "J3C");
            this.J3C.Name = "J3C";
            // 
            // J3P
            // 
            this.J3P.BackColor = System.Drawing.Color.Silver;
            this.J3P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J3P, "J3P");
            this.J3P.Name = "J3P";
            // 
            // J3B
            // 
            this.J3B.BackColor = System.Drawing.Color.Silver;
            this.J3B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J3B, "J3B");
            this.J3B.Name = "J3B";
            // 
            // J3L
            // 
            this.J3L.BackColor = System.Drawing.Color.Silver;
            this.J3L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J3L, "J3L");
            this.J3L.Name = "J3L";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Meduris.Properties.Resources.CuivreICO;
            resources.ApplyResources(this.pictureBox18, "pictureBox18");
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Meduris.Properties.Resources.PierreICO;
            resources.ApplyResources(this.pictureBox19, "pictureBox19");
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Meduris.Properties.Resources.BoisICO;
            resources.ApplyResources(this.pictureBox20, "pictureBox20");
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::Meduris.Properties.Resources.laineICO;
            resources.ApplyResources(this.pictureBox21, "pictureBox21");
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.TabStop = false;
            // 
            // J3PDV
            // 
            this.J3PDV.BackColor = System.Drawing.Color.Silver;
            this.J3PDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.J3PDV, "J3PDV");
            this.J3PDV.Name = "J3PDV";
            // 
            // Player3Name
            // 
            resources.ApplyResources(this.Player3Name, "Player3Name");
            this.Player3Name.Name = "Player3Name";
            // 
            // scopePanel
            // 
            this.scopePanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.scopePanel, "scopePanel");
            this.scopePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scopePanel.Name = "scopePanel";
            // 
            // Logs
            // 
            resources.ApplyResources(this.Logs, "Logs");
            this.Logs.Name = "Logs";
            this.Logs.ReadOnly = true;
            // 
            // Meduris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Meduris.Properties.Resources.background;
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.scopePanel);
            this.Controls.Add(this.plateau);
            this.Controls.Add(this.p3Panel);
            this.Controls.Add(this.p2Panel);
            this.Controls.Add(this.p1Panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Meduris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.p1Panel.ResumeLayout(false);
            this.p1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p2Panel.ResumeLayout(false);
            this.p2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.p3Panel.ResumeLayout(false);
            this.p3Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plateau;
        private System.Windows.Forms.Panel p1Panel;
        private System.Windows.Forms.Panel p2Panel;
        private System.Windows.Forms.Panel p3Panel;
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Label Player3Name;
        private System.Windows.Forms.Label J1PDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label J1C;
        private System.Windows.Forms.Label J1P;
        private System.Windows.Forms.Label J1B;
        private System.Windows.Forms.Label J1L;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label J1H;
        private System.Windows.Forms.Label J1T;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label J2H;
        private System.Windows.Forms.Label J2T;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label J2C;
        private System.Windows.Forms.Label J2P;
        private System.Windows.Forms.Label J2B;
        private System.Windows.Forms.Label J2L;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label J2PDV;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label J3H;
        private System.Windows.Forms.Label J3T;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label J3C;
        private System.Windows.Forms.Label J3P;
        private System.Windows.Forms.Label J3B;
        private System.Windows.Forms.Label J3L;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.Label J3PDV;
        private System.Windows.Forms.Panel scopePanel;
        private System.Windows.Forms.RichTextBox Logs;
    }
}

