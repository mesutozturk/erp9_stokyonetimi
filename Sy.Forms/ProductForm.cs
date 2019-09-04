using System;
using System.Windows.Forms;
using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;

namespace Sy.Forms
{
    public partial class ProductForm : Form
    {
        private readonly IRepository<Product, Guid> _productRepo;
        public ProductForm()
        {
            InitializeComponent();
            _productRepo = new Repository<Product, Guid>();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _productRepo.Insert(new Product()
            {
                ProductName = txtUrunAdi.Text,
                UnitPrice = nFiyat.Value,
                CriticStock = Convert.ToInt32(nKritikStok.Value)
            });
            MessageBox.Show("Ürün ekleme işlemi başarılı");
        }
    }
}
