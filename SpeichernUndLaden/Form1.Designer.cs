﻿namespace SpeichernUndLaden
{
    partial class Form1
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
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxInput
            // 
            this.TbxInput.AcceptsReturn = true;
            this.TbxInput.Location = new System.Drawing.Point(12, 12);
            this.TbxInput.Multiline = true;
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(253, 291);
            this.TbxInput.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 309);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(119, 23);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(146, 309);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(119, 23);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Laden";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 350);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TbxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
    }
}

