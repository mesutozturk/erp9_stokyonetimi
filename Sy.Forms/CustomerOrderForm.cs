using System;
using System.Windows.Forms;
using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;

namespace Sy.Forms
{
    public partial class CustomerOrderForm : Form
    {
        private readonly IRepository<Product, Guid> _productRepo;
        private readonly IRepository<OrderDetail, long> _repository;
        public CustomerOrderForm()
        {
            InitializeComponent();
            _productRepo = new ProductRepo();
            ListeyiDoldur();
        }

        private void ListeyiDoldur(string search = "")
        {
            lstUrunler.DataSource = ((ProductRepo)_productRepo).GetProductList(search);
            lstUrunler.DisplayMember = "Display";
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            ListeyiDoldur(txtAra.Text);
        }
    }
}
