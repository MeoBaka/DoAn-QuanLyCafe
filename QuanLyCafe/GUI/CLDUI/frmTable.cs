using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.GUI.CLDUI
{
    public partial class frmTable : Form
    {
        public frmTable()
        {
            InitializeComponent();
            for (int i = 1; i < 100; i++)
            {
                AddTable($"Bàn {i}");
            }
        }
        void AddTable(string tableName)
        {
            Button newButton = new Button();
            newButton.Text = tableName + "\nTrống"; // Sử dụng tên bàn được truyền vào
            newButton.Size = new Size(90, 90);
            newButton.FlatStyle = FlatStyle.Flat;

            // Ví dụ: Trạng thái là "trống"
            var status = "trống";

            if (status.ToLower() == "trống")
            {
                newButton.BackColor = Color.Aqua;
            }
            else
            {
                newButton.BackColor = Color.OrangeRed;
            }

            flpTable.Controls.Add(newButton);
        }

    }
}
