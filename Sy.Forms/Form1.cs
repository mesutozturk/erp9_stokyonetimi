using Sy.Business.Repository;
using Sy.Core.Entities;
using Sy.Forms.Auth;
using System;
using System.Windows.Forms;
using Sy.Core.ComplexTypes;

namespace Sy.Forms
{
    public partial class Form1 : Form
    {
        private Repository<Product, Guid> _productRepo;
        public Form1()
        {
            InitializeComponent();
            _productRepo = new Repository<Product, Guid>();
            groupBox1.Visible = true;
            lblGirisBilgi.Visible = false;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            if (StockSettings.UserInfo == null)
            {
                groupBox1.Visible = true;
                lblGirisBilgi.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                lblGirisBilgi.Visible = true;
                lblGirisBilgi.Text = StockSettings.UserInfo.Display;
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }
    }
}
