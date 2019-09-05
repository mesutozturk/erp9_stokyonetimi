using System;
using System.Linq;
using System.Windows.Forms;
using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.ViewModels;

namespace Sy.Forms
{
    public partial class ProductForm : Form
    {
        private readonly IRepository<Product, Guid> _productRepo;
        public ProductForm()
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _productRepo.Insert(new Product()
                {
                    ProductName = txtUrunAdi.Text,
                    UnitPrice = nFiyat.Value,
                    CriticStock = Convert.ToInt32(nKritikStok.Value)
                });
                MessageBox.Show("Ürün ekleme işlemi başarılı");
                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            ListeyiDoldur(txtAra.Text);
        }
    }
}
