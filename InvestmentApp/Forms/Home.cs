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
using System.Windows.Forms.VisualStyles;

namespace InvestmentApp.Forms
{
    public partial class Home : BGYForm
    {
        Repository _repository = new Repository();
        public Home()
        {
            InitializeComponent();
            PageType = Pages.Home;
            ConfigForm.CurrentForm = this;
        }
        private  void Home_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private async void LoadProducts()
        {
            sfdgHome.DataSource = await _repository.GetLogTable();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void btnUserOperations_Click(object sender, EventArgs e)
        {
            if (ConfigForm.OpenedForms.Any(x => x.Text == "UserOperations"))
            {
                ConfigForm.OpenedForms.FirstOrDefault(x => x.Text == "UserOperations").BringToFront();
            }
            else
            {
                UserOperations userOperations = new UserOperations();
                userOperations.TopLevel = false;
                Investment_App._mother.Controls.Add(userOperations);
                userOperations.BringToFront();
                userOperations.Dock = DockStyle.Fill;
                userOperations.Show();
            } 
        }
        private void btnInvest_Click(object sender, EventArgs e)
        {
            if (ConfigForm.OpenedForms.Any(x => x.Text == "Invest"))
            {
                ConfigForm.OpenedForms.FirstOrDefault(x => x.Text == "Invest").BringToFront();
            }
            else
            {
                Invest invest = new Invest();
                invest.TopLevel = false;
                Investment_App._mother.Controls.Add(invest);
                invest.BringToFront();
                invest.Dock = DockStyle.Fill;
                invest.Show();
            }
        }
        private void Search(string key)
        {
            sfdgHome.SearchController.AllowFiltering = true;
            sfdgHome.SearchController.Search(key);
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(tbxSearch.Text);
        }
        private async void Home_FormClosing(object sender, FormClosingEventArgs e)
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
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigForm.RemoveSpecificForm(this);
        }
    }
}
