using System.Linq;
using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using System.Windows.Forms;
using Sy.Core.Enums;
using Sy.Core.ViewModels;

namespace Sy.Forms
{
    public partial class OrderDetailForm : Form
    {
        private readonly IRepository<Client, int> _clientRepo;
        private readonly IRepository<Order, long> _orderRepo;
        private readonly IRepository<OrderDetail, long> _orderDetailRepo;
        public OrderDetailForm()
        {
            InitializeComponent();
            _clientRepo = new Repository<Client, int>();
            _orderRepo = new Repository<Order, long>();
            _orderDetailRepo = new Repository<OrderDetail, long>();
        }

        private void OrderDetailForm_Load(object sender, System.EventArgs e)
        {
            cmbMusteriler.DataSource = _clientRepo.Query(x => x.ApplicationRole != ApplicationRole.Admin)
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Surname)
                .ToList();
        }

        private void CmbMusteriler_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbMusteriler.SelectedItem == null) return;

            var seciliMusteri = cmbMusteriler.SelectedItem as Client;
            var musterininSiparisleri = _orderRepo.Query(x => x.CreatedUser == seciliMusteri.Email)
                .Select(x => new OrderViewModel()
                {
                    Id = x.Id,
                    ClientName = seciliMusteri.Name,
                    ClientSurname = seciliMusteri.Surname,
                    OrderDate = x.CreatedDate,
                    DeliveredDate = x.DeliveredDate,
                    TotalPrice = x.OrderDetails.Sum(y => y.Quantity * y.UnitPrice)
                })
                .ToList();
            lstSiparisler.DataSource = musterininSiparisleri;
            lstSiparisler.DisplayMember = "Display";
            lblToplam.Text = $"{musterininSiparisleri.Sum(x => x.TotalPrice):c2}";
        }

        private void LstSiparisler_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstSiparisler.SelectedItem == null) return;
            var seciliSiparis = lstSiparisler.SelectedItem as OrderViewModel;
            var siparisDetaylari = _orderDetailRepo.Query(x => x.Id == seciliSiparis.Id)
                .Select(x => new OrderDetailViewModel()
                {
                    Quantity = x.Quantity,
                    UnitPrice = x.UnitPrice,
                    ProductName = x.Product.ProductName
                }).ToList();
            dgvDetay.DataSource = siparisDetaylari;
        }
    }
}
