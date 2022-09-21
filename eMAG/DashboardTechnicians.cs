using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System.IO;

namespace eMAG
{
    public partial class DashboardTechnicians : MaterialForm
    {
        public DashboardTechnicians()
        {
            InitializeComponent();

            DashboardTechnicians.ActiveForm.Text = "eMAG International" + " | " + LogData.FirstName;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;


        private void DashboardTechnicians_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.AutoGenerateColumns = false;

            using (StreamReader sr = new StreamReader("theme.txt"))
            {
                FillSettingsFile.UIThemeStr = sr.ReadLine();
            }
            if (FillSettingsFile.UIThemeStr == "Dark")
            {
                darkThemeSwitch.Checked = true;
            }
            else
            {
                darkThemeSwitch.Checked = false;
            }

            using (StreamWriter sw = new StreamWriter("data.txt", false))
            {
                sw.WriteLine(FillSettingsFile.server);
                sw.WriteLine(FillSettingsFile.db);
                sw.WriteLine(FillSettingsFile.username);
                sw.WriteLine(FillSettingsFile.password);
            }

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(DISTINCT OrderNumber) FROM orders ",conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    numOrders.Text = dr[0].ToString();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(id) FROM customers ", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    customersNum.Text = dr[0].ToString();
                }
            }

        }

        private void userLoged_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to log out?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            orderIDBox.Clear();
            phoneBox.Clear();
            emailBox.Clear();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT customers.address, customers.city, customers.country, customers.firstName, customers.lastName, customers.middleName, customers.phone, orders.OrderNumber, orders.OrderDate, orders.ShipmentDate, orders.OrderStatus, products.title, products.retailPrice, order_detail.Quantity, order_detail.Quantity*products.retailPrice AS Expr1 FROM products INNER JOIN((customers INNER JOIN orders ON customers.id = orders.CustomerID) INNER JOIN order_detail ON orders.id = order_detail.OrderID) ON products.id = order_detail.ProductID WHERE customers.phone=@phone OR customers.email=@email OR order_detail.OrderID=@orderID AND((orders.OrderDate)Between @date1 And @date2)", conn);
                cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@orderID", orderIDBox.Text);
                cmd.Parameters.AddWithValue("@date1", guna2DateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@date2", guna2DateTimePicker2.Value.Date);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    searchResult.Visible = true;
                    nameClient.Text = $"{dr["firstName"].ToString()} {dr["middleName"].ToString()} {dr["lastName"].ToString()}";
                    phoneClient.Text = dr["phone"].ToString();
                    addressClient.Text = dr["address"].ToString();
                    cityClient.Text = dr["city"].ToString();
                    countryClient.Text = dr["country"].ToString();
                    orderNumber.Text = dr["OrderNumber"].ToString();
                    OrderDate.Text = dr["OrderDate"].ToString();
                    OrderStatus.Text = dr["OrderStatus"].ToString();
                    ShipmentDate.Text = dr["ShipmentDate"].ToString();
                }
                else
                {
                    MessageBox.Show("Въвели сте грешни данни!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT customers.firstName, customers.lastName, customers.phone, orders.OrderNumber, orders.OrderDate, orders.OrderStatus, products.title, products.retailPrice, order_detail.Quantity, order_detail.Quantity*products.retailPrice AS Expr1 FROM products INNER JOIN((customers INNER JOIN orders ON customers.id = orders.CustomerID) INNER JOIN order_detail ON orders.ID = order_detail.OrderID) ON products.id = order_detail.ProductID WHERE(((customers.phone) = @phone))", conn);
                cmd.Parameters.AddWithValue("@phone", phoneClient.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword();
            c.Show();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Наистина ли искате да излезете?", "Изход от профил", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Наистина ли искате да излезете?", "Изход от профил", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            searchResult.Visible = false;
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT OrderStatus FROM orders WHERE OrderNumber=@orderNumber", conn);
                cmd.Parameters.AddWithValue("@orderNumber", orderNumber.Text);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["OrderStatus"].ToString() == "Cancelled")
                    {
                        MessageBox.Show("Поръчката вече е отменена!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        orderNumberCancel.Text = orderNumber.Text;
                        cancelOrderPanel.Visible = true;
                    }
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            cancelOrderPanel.Visible = false;
        }

        private void saveStatus_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE orders SET OrderStatus=@status WHERE OrderNumber=@orderNumber", conn);
                cmd.Parameters.AddWithValue("@orderNumber", orderNumber.Text);
                cmd.Parameters.AddWithValue("@status", "Cancelled");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Поръчката е отменена успешно!", "Отменена поръчка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cancelOrderPanel.Visible = false;
            }
        }

        private void darkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (darkThemeSwitch.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK;
                using (StreamWriter sw = new StreamWriter("theme.txt", false))
                {
                    sw.WriteLine("Dark");
                }
            }
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
                using (StreamWriter sw = new StreamWriter("theme.txt", false))
                {
                    sw.WriteLine("Light");
                }
            }
        }
    }
}
