using System;
using System.Linq;
using System.Windows.Forms;
using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.Enums;
using Sy.Core.ViewModels;

namespace Sy.Forms
{
    public partial class OrderForm : Form
    {
        private readonly IRepository<Product, Guid> _productRepo;
        private readonly IRepository<ProductStockAction, long> _productActionRepo;
        public OrderForm()
        {
            InitializeComponent();
            _productRepo = new ProductRepo();
            _productActionRepo = new Repository<ProductStockAction, long>();
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

        private ProductViewModel _seciliUrun;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            _seciliUrun = lstUrunler.SelectedItem as ProductViewModel;
            lblUrunAdi.Text = _seciliUrun?.ProductName;
            lblStokMiktari.Text = _seciliUrun?.UnitsInStock.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _productActionRepo.Insert(new ProductStockAction()
                {
                    ProductId = _seciliUrun.Id,
                    Quantity = Convert.ToInt32(nEklenecekMiktar.Value),
                    UnitPrice = nAlisFiyati.Value,
                    StockActionType = StockActionType.Incoming
                });
                MessageBox.Show("Stok ekleme işlemi başarılı");
                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
