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
    }
}
