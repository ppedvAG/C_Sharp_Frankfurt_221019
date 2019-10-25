namespace EventHandling
{
    partial class BeispielFenster
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
            this.components = new System.ComponentModel.Container();
            this.BtnKlickMich = new System.Windows.Forms.Button();
            this.LblAnweisung = new System.Windows.Forms.Label();
            this.CbxAbgehakt = new System.Windows.Forms.CheckBox();
            this.RbtEins = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.CbbAuswahl = new System.Windows.Forms.ComboBox();
            this.LbxAuswahl = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesFensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnMB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnKlickMich
            // 
            this.BtnKlickMich.Location = new System.Drawing.Point(12, 30);
            this.BtnKlickMich.Name = "BtnKlickMich";
            this.BtnKlickMich.Size = new System.Drawing.Size(113, 35);
            this.BtnKlickMich.TabIndex = 0;
            this.BtnKlickMich.Text = "Klick Mich";
            this.BtnKlickMich.UseVisualStyleBackColor = true;
            this.BtnKlickMich.Click += new System.EventHandler(this.BtnKlickMich_Click);
            // 
            // LblAnweisung
            // 
            this.LblAnweisung.AutoSize = true;
            this.LblAnweisung.Location = new System.Drawing.Point(13, 84);
            this.LblAnweisung.Name = "LblAnweisung";
            this.LblAnweisung.Size = new System.Drawing.Size(175, 13);
            this.LblAnweisung.TabIndex = 1;
            this.LblAnweisung.Text = "Ich bin ein String der angezeigt wird";
            // 
            // CbxAbgehakt
            // 
            this.CbxAbgehakt.AutoSize = true;
            this.CbxAbgehakt.Checked = true;
            this.CbxAbgehakt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxAbgehakt.Location = new System.Drawing.Point(16, 107);
            this.CbxAbgehakt.Name = "CbxAbgehakt";
            this.CbxAbgehakt.Size = new System.Drawing.Size(80, 17);
            this.CbxAbgehakt.TabIndex = 2;
            this.CbxAbgehakt.Text = "checkBox1";
            this.CbxAbgehakt.UseVisualStyleBackColor = true;
            // 
            // RbtEins
            // 
            this.RbtEins.AutoSize = true;
            this.RbtEins.Location = new System.Drawing.Point(17, 18);
            this.RbtEins.Name = "RbtEins";
            this.RbtEins.Size = new System.Drawing.Size(85, 17);
            this.RbtEins.TabIndex = 3;
            this.RbtEins.TabStop = true;
            this.RbtEins.Text = "radioButton1";
            this.RbtEins.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.RbtEins);
            this.groupBox1.Location = new System.Drawing.Point(240, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auswahl";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(402, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(402, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // TbxInput
            // 
            this.TbxInput.AcceptsReturn = true;
            this.TbxInput.AcceptsTab = true;
            this.TbxInput.Location = new System.Drawing.Point(12, 169);
            this.TbxInput.Multiline = true;
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(237, 93);
            this.TbxInput.TabIndex = 8;
            this.TbxInput.Text = "Ich bin ein eigegebener Text";
            // 
            // CbbAuswahl
            // 
            this.CbbAuswahl.FormattingEnabled = true;
            this.CbbAuswahl.Items.AddRange(new object[] {
            "Eintrag1",
            "Auswahl2",
            "Ding3"});
            this.CbbAuswahl.Location = new System.Drawing.Point(258, 133);
            this.CbbAuswahl.Name = "CbbAuswahl";
            this.CbbAuswahl.Size = new System.Drawing.Size(121, 21);
            this.CbbAuswahl.TabIndex = 9;
            // 
            // LbxAuswahl
            // 
            this.LbxAuswahl.FormattingEnabled = true;
            this.LbxAuswahl.Items.AddRange(new object[] {
            "Eintrag1",
            "Auswahl2",
            "Ding3"});
            this.LbxAuswahl.Location = new System.Drawing.Point(259, 181);
            this.LbxAuswahl.Name = "LbxAuswahl";
            this.LbxAuswahl.Size = new System.Drawing.Size(120, 95);
            this.LbxAuswahl.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesFensterToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernAlsToolStripMenuItem});
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // speichernAlsToolStripMenuItem
            // 
            this.speichernAlsToolStripMenuItem.Name = "speichernAlsToolStripMenuItem";
            this.speichernAlsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernAlsToolStripMenuItem.Text = "Speichern als";
            // 
            // neuesFensterToolStripMenuItem
            // 
            this.neuesFensterToolStripMenuItem.Name = "neuesFensterToolStripMenuItem";
            this.neuesFensterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuesFensterToolStripMenuItem.Text = "Neues Fenster";
            this.neuesFensterToolStripMenuItem.Click += new System.EventHandler(this.NeuesFensterToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnTimer
            // 
            this.BtnTimer.Location = new System.Drawing.Point(402, 103);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(75, 51);
            this.BtnTimer.TabIndex = 12;
            this.BtnTimer.Text = "Start/Stop Timer";
            this.BtnTimer.UseVisualStyleBackColor = true;
            this.BtnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            // 
            // BtnMB
            // 
            this.BtnMB.Location = new System.Drawing.Point(402, 167);
            this.BtnMB.Name = "BtnMB";
            this.BtnMB.Size = new System.Drawing.Size(75, 23);
            this.BtnMB.TabIndex = 13;
            this.BtnMB.Text = "Zeige MB";
            this.BtnMB.UseVisualStyleBackColor = true;
            this.BtnMB.Click += new System.EventHandler(this.BtnMB_Click);
            // 
            // BeispielFenster
            // 
            this.AcceptButton = this.BtnKlickMich;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.BtnMB);
            this.Controls.Add(this.BtnTimer);
            this.Controls.Add(this.LbxAuswahl);
            this.Controls.Add(this.CbbAuswahl);
            this.Controls.Add(this.TbxInput);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CbxAbgehakt);
            this.Controls.Add(this.LblAnweisung);
            this.Controls.Add(this.BtnKlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BeispielFenster";
            this.Text = "BeispielFenster";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKlickMich;
        private System.Windows.Forms.Label LblAnweisung;
        private System.Windows.Forms.CheckBox CbxAbgehakt;
        private System.Windows.Forms.RadioButton RbtEins;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.ComboBox CbbAuswahl;
        private System.Windows.Forms.ListBox LbxAuswahl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernAlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesFensterToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnMB;
    }
}