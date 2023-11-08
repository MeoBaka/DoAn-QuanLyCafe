using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
