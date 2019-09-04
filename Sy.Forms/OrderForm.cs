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
            _productRepo = new Repository<Product, Guid>();
            _productActionRepo = new Repository<ProductStockAction, long>();
            ListeyiDoldur();
        }
        private void ListeyiDoldur(string search = "")
        {
            var data = _productRepo.Query(x => x.ProductName.Contains(search))
                .Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    UnitPrice = x.UnitPrice,
                    CriticStock = x.CriticStock,
                    ProductName = x.ProductName,
                }).ToList();
            foreach (var item in data)
            {
                var actionList = _productActionRepo.Query(x => x.ProductId == item.Id).ToList();
                if (!actionList.Any()) continue;

                var girenAdet = actionList.Where(x => x.StockActionType == StockActionType.Incoming)
                    .Sum(x => x.Quantity);
                var cikanAdet = actionList.Where(x => x.StockActionType == StockActionType.Outgoing)
                    .Sum(x => x.Quantity);
                item.UnitsInStock = girenAdet - cikanAdet;
            }
            lstUrunler.DataSource = data;
            lstUrunler.DisplayMember = "Display";
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            ListeyiDoldur(txtAra.Text);
        }

        private ProductViewModel seciliUrun;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            seciliUrun = lstUrunler.SelectedItem as ProductViewModel;
            lblUrunAdi.Text = seciliUrun.ProductName;
            lblStokMiktari.Text = seciliUrun.UnitsInStock.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _productActionRepo.Insert(new ProductStockAction()
                {
                    ProductId = seciliUrun.Id,
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
