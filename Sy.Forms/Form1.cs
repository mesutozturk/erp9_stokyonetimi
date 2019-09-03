using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sy.Forms.Auth;

namespace Sy.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> sayilar = new List<int>();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();

            var result = sayilar.Where(x => x > 10);
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }
    }
}
