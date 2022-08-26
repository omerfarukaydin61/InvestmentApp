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
    public partial class Home : Form
    {
        Repository _repository = new Repository();
        public Home()
        {
            InitializeComponent();
        }

        private  void Home_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private async void LoadProducts()
        {
            sfdgHome.DataSource = await _repository.GetLogTable();
            sfdgHome.Columns[0].Visible = false;
            sfdgHome.Columns[1].Width = 60;
            sfdgHome.Columns[2].Width = 60;
            sfdgHome.Columns[3].Width = 120;
            sfdgHome.Columns[4].Width = 75;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnUserOperations_Click(object sender, EventArgs e)
        {
            var userOperations = new UserOperations();
            userOperations.Closed += (s, args) => this.LoadProducts();
            userOperations.ShowDialog();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string message = USD"{ConfigModel.RegisteredUser.Name} logged out.";
            //Logger.Log(LogAction.logout, message, ConfigModel.RegisteredUser.ID);
        }

        private void btnInvest_Click(object sender, EventArgs e)
        {
            var invest = new Invest();
            invest.Closed += (s, args) => this.LoadProducts();
            invest.ShowDialog();
        }

        private void sfdgHome_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            e.Column.CellStyle.VerticalAlignment = VerticalAlignment.Center;
            e.Column.CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
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
    }
}
