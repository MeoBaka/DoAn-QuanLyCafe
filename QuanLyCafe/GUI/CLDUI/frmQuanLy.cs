using QuanLyCafe.BLL;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyCafe.GUI.CLDUI
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
            OpenFromPage(new frmDoanhThu(), pnDoanhThu);
            
        }
        private Form CurrentFormPage;
        private void OpenFromPage(Form PageForm, Panel Panel)
        {
            if (CurrentFormPage != null)
            {
                CurrentFormPage.Close();
            }
            CurrentFormPage = PageForm;
            PageForm.TopLevel = false;
            PageForm.FormBorderStyle = FormBorderStyle.None;
            PageForm.Dock = DockStyle.Fill;
            Panel.Controls.Add(PageForm);
            Panel.Tag = PageForm;
            PageForm.BringToFront();
            PageForm.Show();
        }
        private void tcQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tcQuanLy.SelectedTab.Text.ToLower() == "doanh thu")
            {
                OpenFromPage(new frmDoanhThu(), pnDoanhThu);
            }
            if (tcQuanLy.SelectedTab.Text.ToLower() == "thức ăn")
            {
                OpenFromPage(new frmThucAn(), pnThucAn);
            }
        }

    }
}
