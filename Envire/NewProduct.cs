using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Envire
{
    public partial class NewProduct : MaterialForm
    {
        public NewProduct()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO products (product_name, product_type, product_price, product_quantity, product_sku, product_location) VALUES (@title, @type, @wholesalePrice, @QuantityWarehouse, @Barcode, @product_location)", conn);
                cmd.Parameters.AddWithValue("@title", title.Text);
                cmd.Parameters.AddWithValue("@type", type.Text);
                cmd.Parameters.AddWithValue("@wholesalePrice", wholesalePrice.Text);
                cmd.Parameters.AddWithValue("@QuantityWarehouse", 0);
                cmd.Parameters.AddWithValue("@barcode", barcode.Text);
                cmd.Parameters.AddWithValue("@product_location", product_location.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Продуктът е добавен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                title.Clear();
                type.Text = "";
                barcode.Clear();
                wholesalePrice.Clear();

            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            title.Clear();
            type.Text = "";
            barcode.Clear();
            wholesalePrice.Clear();
        }
    }
}
