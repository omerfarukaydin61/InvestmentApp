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
    public partial class Validation : Form
    {
        string _username;
        Repository _repository = new Repository();
        public Validation(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void Validation_Load(object sender, EventArgs e)
        {

        }

        //private void sfbtnVerify_Click(object sender, EventArgs e)
        //{
        //    bool res = _repository.Validation(_username, tbxPassword.Text);
        //    if (res)
        //    {

        //    }
        //    DialogResult dialogResult = MessageBox.Show("Wrong password !!!");
        //}
    }
}
