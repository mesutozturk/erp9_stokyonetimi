using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.ViewModels;

namespace Sy.Forms
{
    public partial class CustomerOrderForm : Form
    {
        private readonly IRepository<Product, Guid> _productRepo;
        private readonly IRepository<Order, long> _orderRepo;
        private List<SepetViewModel> _sepet = new List<SepetViewModel>();
        public CustomerOrderForm()
        {
            InitializeComponent();
            _productRepo = new ProductRepo();
            _orderRepo = new OrderRepo();
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

        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as ProductViewModel;
            SepeteEkle(seciliUrun);
        }

        private void SepeteEkle(ProductViewModel seciliUrun)
        {
            if (_sepet.Any(x => x.ProductId == seciliUrun.Id))
            {
                var sepetUrun = _sepet.First(x => x.ProductId == seciliUrun.Id);
                if (seciliUrun.UnitsInStock > sepetUrun.Quantity)
                    sepetUrun.Quantity++;
                else
                    MessageBox.Show("Bu üründen maksimum sepet adetine ulaştınız!");
            }
            else
                _sepet.Add(new SepetViewModel()
                {
                    ProductId = seciliUrun.Id,
                    Quantity = 1,
                    UnitPrice = seciliUrun.UnitPrice,
                    ProductName = seciliUrun.ProductName
                });
            SepetGuncelle();
        }

        private void SepetGuncelle()
        {
            lstSepet.DataSource = null;
            lstSepet.DataSource = _sepet;
            lstSepet.DisplayMember = "Display";
            lblTutar.Text = $"Sepet Toplamı: {_sepet.Sum(x => x.SubTotal):c2}";
        }

        private void BtnSepettenCikart_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;
            var secili = lstSepet.SelectedItem as SepetViewModel;
            if (secili.Quantity > 1)
                secili.Quantity--;
            else
                _sepet.Remove(secili);
            SepetGuncelle();
        }

        private void BtnSiparisOnay_Click(object sender, EventArgs e)
        {
            if (!_sepet.Any())
            {
                MessageBox.Show("Önce sepete ürün ekleyiniz");
                return;
            }

            var orderId = ((OrderRepo)_orderRepo).MakeOrder(_sepet, dtpIstenenTarih.Value);
            if (orderId == 0)
                MessageBox.Show("Siparişiniz oluşmamıştır");
            else
            {
                MessageBox.Show($"Siparişiniz oluşmuştur: {orderId}");
                _sepet = new List<SepetViewModel>();
                SepetGuncelle();
                ListeyiDoldur();
            }
        }
    }
}
