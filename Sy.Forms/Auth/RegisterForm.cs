using System;
using System.Linq;
using System.Windows.Forms;
using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.Entities;
using Sy.Core.Enums;
using Sy.Core.ViewModels;

namespace Sy.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private readonly IRepository<Client, int> _clientRepository;
        public RegisterForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var model = new RegisterViewModel()
            {
                Email = txtEmail.Text,
                Name = txtAd.Text,
                Surname = txtSoyad.Text,
                Password = txtSifre.Text
            };
            //email var mı kontrol edelim...
            var kontrol = _clientRepository
                .Query(x => x.Email == model.Email).Any();
            if (kontrol)
            {
                MessageBox.Show("Bu email adresi kullanılmaktadır!");
                return;
            }
            //benzersiz email kontrolunden sonra kisiyi kaydedelim
            var musteriMi = _clientRepository.Query().Any();

            _clientRepository.Insert(new Client()
            {
                Email = model.Email,
                Surname = model.Surname,
                Password = model.Password,
                Name = model.Name,
                ApplicationRole = musteriMi ? ApplicationRole.Customer : ApplicationRole.Admin
            });
            MessageBox.Show($"Kayıt işleminiz başarılıdır.\n{model.Name} {model.Surname}");
            this.Close();
        }
    }
}
