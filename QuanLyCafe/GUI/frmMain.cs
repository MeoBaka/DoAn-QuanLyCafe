using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.GUI
{
    public partial class frmMain : Form
    {
        private const int SW_MINIMIZE = 6;

        private const int SW_MAXIMIZE = 3;
        private const int SW_RESTORE = 9;

        private const int SWP_SHOWWINDOW = 0x0040;
        private const int SWP_FRAMECHANGED = 0x0020;
        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_DRAWFRAME = 0x0020;
        private const int SWP_DEFERERASE = 0x2000;
        private const int HWND_TOPMOST = -2;

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);


        public frmMain()
        {
            InitializeComponent();
            OpenFromPage(new CLDUI.frmPageMain());
            this.ControlBox = false;
            this.Text = $"Hệ Thống Quản Lý";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Close();
            frmLogin.Show();
        }

        private void btn_MaxSize_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            if (WindowState == FormWindowState.Maximized)
            {
                // If form is maximized, restore it to normal state
                ShowWindow(handle, SW_RESTORE);
            }
            else
            {
                // If form is not maximized, maximize it and adjust position and size to account for taskbar
                ShowWindow(handle, SW_MAXIMIZE);

                // Get screen and taskbar rectangles
                Rectangle screenRect = Screen.FromHandle(handle).Bounds;
                Rectangle taskbarRect = Screen.FromHandle(handle).WorkingArea;

                // Calculate the size and position of the form with taskbar accounted for
                int x = 0;
                int y = taskbarRect.Top;
                int width = screenRect.Width;
                int height = taskbarRect.Height;

                // Set the position and size of the form
                SetWindowPos(handle, new IntPtr(HWND_TOPMOST), x, y, width, height, SWP_SHOWWINDOW | SWP_FRAMECHANGED);
            }
        }

        private void btn_MinSize_Click(object sender, EventArgs e)
        {
            IntPtr handle = Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow(handle, SW_MINIMIZE);
        }

        private Form CurrentFormPage;
        private void OpenFromPage(Form PageForm)
        {
            if (CurrentFormPage != null)
            {
                CurrentFormPage.Close();
            }
            CurrentFormPage = PageForm;
            PageForm.TopLevel = false;
            PageForm.FormBorderStyle = FormBorderStyle.None;
            PageForm.Dock = DockStyle.Fill;
            pnTakeForm.Controls.Add(PageForm);
            pnTakeForm.Tag = PageForm;
            PageForm.BringToFront();
            PageForm.Show();
        }
        private string BtnStatus = null;
        private void btnTable_Click(object sender, EventArgs e)
        {
            BtnStatus = btnTable.Text;
            btn_CloseButton.Visible = true;
            OpenFromPage(new CLDUI.frmTable());
        }

        private void btn_CloseButton_Click(object sender, EventArgs e)
        {
            OpenFromPage(new CLDUI.frmPageMain());
            btn_CloseButton.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            BtnStatus = btnTable.Text;
            btn_CloseButton.Visible = true;
            OpenFromPage(new CLDUI.frmQuanLy());
        }
    }
}
