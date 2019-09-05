using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

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

        private void RaporGetir()
        {
            // toplam ürün adedim
            var urunAdet = _productRepo.Query().Count();
            var toplamStokAdet = ((ProductRepo)_productRepo).GetProductList().Sum(x => x.UnitsInStock);
            var toplamMaliyet = ((ProductRepo)_productRepo).GetProductList().Sum(x => x.UnitsInStock * x.UnitPrice);

            lblBilgi.Text = $"{urunAdet} adet ürün bulunmakta\nStok adeti {toplamStokAdet}\nToplam maliyet: {toplamMaliyet:c2}";
        }

        private void ListeyiDoldur(string search = "")
        {
            lstUrunler.DataSource = ((ProductRepo)_productRepo).GetProductList(search);
            lstUrunler.DisplayMember = "Display";
            RaporGetir();
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
