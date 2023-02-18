using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class ProductsRec : MaterialForm
    {
        public ProductsRec()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void ProductsRec_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.AutoGenerateColumns = false;
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT products.title, products.retailPrice, products.QuantityWarehouse, products.QuantityWarehouse*products.retailPrice AS sum FROM products", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;


            }
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT products.title FROM products", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item.Items.Add(dr["title"].ToString());
                }
            }
            
        }

        private void addReceive_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE products SET QuantityWarehouse=QuantityWarehouse+@quantity WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", item.SelectedIndex+1);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Стоката е добавена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                item.SelectedIndex = -1;
                quantity.Clear();
                price.Clear();
                sum.Clear();
            }
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT products.title, products.retailPrice, products.QuantityWarehouse, products.QuantityWarehouse*products.retailPrice AS sum FROM products", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                

            }
        }

        private void item_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT products.retailPrice, products.QuantityWarehouse FROM products WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", item.SelectedIndex+1);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    price.Text = dr["retailPrice"].ToString();
                }
            }
        }

        private void quantity_Validated(object sender, EventArgs e)
        {
            double sum1 = 0;
            sum1 = double.Parse(price.Text) * double.Parse(quantity.Text);
            sum.Text = sum1.ToString();
        }
    }
}
