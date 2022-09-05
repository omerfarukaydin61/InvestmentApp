using InvestmentApp.Entities;
using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.Enums;
using Syncfusion.Windows;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid.Enums;
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
    public partial class UserOperations : Form
    {
        Repository _repository = new Repository();
        public UserOperations()
        {
            InitializeComponent();
            ConfigForm.CurrentForm = this;
            this.Tag = ConfigForm.MaxIdOfOpenedForm() + 1;
        }
        private void UserOperations_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }      
        private async void LoadProducts()
        {
            sfdgUserOperations.DataSource = await _repository.GetUserTable();
            sfdgUserOperations.SelectionMode = GridSelectionMode.Single;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ConfigModel.RegisteredUser.Permission == Permissions.Admin ||
                ConfigModel.RegisteredUser.Permission == Permissions.Moderator)
            {
                var addPage = new UserOperationsPopUp(OperationTypes.add);
                addPage.Closed += (s, args) => this.LoadProducts();
                addPage.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var user = sfdgUserOperations.SelectedItem as UserDto;
            if (user == null)
                return;

            if (ConfigModel.RegisteredUser.Permission <= user.Permission)
            {
                var deletePage = new UserOperationsPopUp(OperationTypes.delete, user);
                deletePage.Closed += (s, args) => this.LoadProducts();
                deletePage.ShowDialog();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = sfdgUserOperations.SelectedItem as UserDto;
            if (user == null)
                return;

            if (ConfigModel.RegisteredUser.Permission <= user.Permission)
            {
                var updatePage = new UserOperationsPopUp(OperationTypes.update, user);
                updatePage.Closed += (s, args) => this.LoadProducts();
                updatePage.ShowDialog();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void sfdgUserOperations_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            e.Column.CellStyle.VerticalAlignment = VerticalAlignment.Center;
            e.Column.CellStyle.HorizontalAlignment = HorizontalAlignment.Center;
        }
        private void Search(string key)
        {
            sfdgUserOperations.SearchController.AllowFiltering = true;
            sfdgUserOperations.SearchController.Search(key);
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            Search(tbxSearch.Text);
        }
        private void UserOperations_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigForm.RemoveSpecificForm(this);
        }
    }
}
