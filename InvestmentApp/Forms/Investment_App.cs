using InvestmentApp.Entities;
using InvestmentApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentApp.Forms
{
    public partial class Investment_App : Form, IMessageFilter
    {
        Login login = new Login();
        public static Investment_App _mother;
        private const int WM_XBUTTONDOWN = 0x020B;
        private const int MK_XBUTTON1 = 0x0020;
        private const int MK_XBUTTON2 = 0x0040;

        public Investment_App()
        {
            Application.AddMessageFilter(this);
            this.FormClosed += (s, e) => Application.RemoveMessageFilter(this);
            InitializeComponent();
            _mother = this;
        }
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_XBUTTONDOWN)
            {
                int lowWord = (m.WParam.ToInt32() << 16) >> 16;
                switch (lowWord)
                {
                    case MK_XBUTTON1:
                        // navigate backward
                        tsbtnBack_Click(null, null);
                        break;
                    case MK_XBUTTON2:
                        // navigate forward
                        tsbtnForward_Click(null, null);
                        break;
                }
            }
            return false; // dispatch further
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            
            login.TopLevel = false;
            _mother.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            login.Show();
        }
        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            ConfigForm.GoBackPreviousForm();
        }
        private void tsbtnForward_Click(object sender, EventArgs e)
        {
            ConfigForm.GoToNextForm();
        }
        private async void Investment_App_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ConfigModel.RegisteredUser != null)
                {
                    string message = $"{ConfigModel.RegisteredUser.Name} logged out.";
                    await Logger.Log(LogAction.logout, message, ConfigModel.RegisteredUser.ID);
                }
            }
            catch (Exception) { }
        }
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            if (ConfigForm.CurrentForm.PageType == Pages.Login)
            {
                return;
            }
            ConfigForm.OpenedForms.Clear();
            ConfigForm.CloseAllOpenedForms();
            ConfigForm._currentForm.Close();

            login.TopLevel = false;
            _mother.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            login.BringToFront();
            ConfigForm.CurrentForm = login;
        }
        private void tsbtnHome_Click(object sender, EventArgs e)
        {
            if (ConfigForm.CurrentForm.PageType == Pages.Login)
            {
                return;
            }
            if (ConfigForm.OpenedForms.Any(x => x.Text == "Home"))
            {
                var xxx = ConfigForm.OpenedForms.FirstOrDefault(x => x.Text == "Home");
                xxx.BringToFront();
            }
        }
    }
}
