using Sy.Business.Repository;
using Sy.Core.Entities;
using Sy.Forms.Auth;
using System;
using System.Windows.Forms;

namespace Sy.Forms
{
    public partial class Form1 : Form
    {
        private Repository<Product, Guid> _productRepo;
        public Form1()
        {
            InitializeComponent();
            _productRepo = new Repository<Product, Guid>();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }
    }
}
