using MaterialSkin.Controls;
using MaterialSkin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envire
{
    public partial class EditProduct : MaterialForm
    {
        public EditProduct()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE products SET product_name=@title, product_type=@type, product_sku=@barcode, product_price=@wholesalePrice WHERE product_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", TempData.ProductEditID);
                cmd.Parameters.AddWithValue("@title", title.Text);
                cmd.Parameters.AddWithValue("@type", type.Text);
                cmd.Parameters.AddWithValue("@barcode", barcode.Text);
                cmd.Parameters.AddWithValue("@wholesalePrice", wholesalePrice.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Продуктът е редактиран успешно!", "Редакция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", TempData.ProductEditID);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    title.Text = dr["product_name"].ToString();
                    type.Text = dr["product_type"].ToString();
                    barcode.Text = dr["product_sku"].ToString();
                    wholesalePrice.Text = dr["product_price"].ToString();
                }
            }
        }
    }
}
