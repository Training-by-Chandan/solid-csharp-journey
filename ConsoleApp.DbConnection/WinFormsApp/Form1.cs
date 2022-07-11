using WinFormsApp.Data;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnReset.Click += BtnReset_Click;
            this.btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object? sender, EventArgs e)
        {
            DefaultContext db = new DefaultContext();
            var product = new Product()
            {
                Name = txtName.Text,
                Description = txtDesc.Text,
                Price = Convert.ToSingle(txtPrice.Text),
                PurchasedDate = Convert.ToDateTime(dtPurchased.Text)
            };
            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Product added successfully");
            ClearTexts();
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            ClearTexts();
        }

        private void ClearTexts()
        {
            txtName.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            dtPurchased.ResetText();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DefaultContext db = new DefaultContext();
            var product = new Product();

            product.Name = txtName.Text;
            product.Description = txtDesc.Text;
            product.Price = Convert.ToSingle(txtPrice.Text);
            product.PurchasedDate = Convert.ToDateTime(dtPurchased.Text);

            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Product added successfully");
            ClearTexts();
        }
    }
}