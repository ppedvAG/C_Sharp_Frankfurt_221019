using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMovement
{
    public partial class Form1 : Form
    {
        int btnLeftStart, btnRightStart;
        public Form1()
        {
            InitializeComponent();

            btnLeftStart = BtnLeft.Left;
            btnRightStart = BtnRight.Left;

            BtnStart.Click += BtnLeft_Click;
            BtnStart.Click += BtnRight_Click;
            BtnStart.Click += BtnStart_Click;
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            BtnLeft.Left += 10;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            BtnRight.Left -= 10;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(BtnLeft.Right >= BtnRight.Left)
                if(MessageBox.Show("Die Buttons berühren sich!\nZurücksetzen?", "Berührung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    BtnLeft.Left = btnLeftStart;
                    BtnRight.Left = btnRightStart;
                }
        }
    }
}
