using System.Windows.Forms;

namespace QuanLyCafe.Controls
{
    internal class FormChild
    {
        public Form CurrentFormPage;
        public void OpenFromPage(Form PageForm, Panel pn)
        {
            if (CurrentFormPage != null)
            {
                CurrentFormPage.Close();
            }
            CurrentFormPage = PageForm;
            PageForm.TopLevel = false;
            PageForm.FormBorderStyle = FormBorderStyle.None;
            PageForm.Dock = DockStyle.Fill;
            pn.Controls.Add(PageForm);
            pn.Tag = PageForm;
            PageForm.BringToFront();
            PageForm.Show();
        }
    }
}
