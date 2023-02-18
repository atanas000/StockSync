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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net;
using Bunifu.UI.WinForms;

namespace Envire
{
    public partial class WMS : MaterialForm
    {
        public string CustomerPromoCode;
        public string CustomerID;
        public string CustomerAddress;
        public string CustomerCity;
        public string CustomerPostalCode;
        public WMS()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;


        private void DashboardTechnicians_Load(object sender, EventArgs e)
        {

            usernameBox.Text = LogData.Username;
            email.Text = LogData.Email;

            //Delivery Tab
            bunifuDataGridView3.AutoGenerateColumns = false;
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT products.product_name, products.product_price, products.product_quantity, products.product_quantity*products.product_price AS sum FROM products", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuDataGridView3.DataSource = dt;


            }
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT products.product_name FROM products", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item.Items.Add(dr["product_name"].ToString());
                }
            }
            //End of Delivery Tab

            bunifuDataGridView1.AutoGenerateColumns = false;
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT products.product_id, products.product_name, products.product_type, products.product_sku, products.product_quantity, products.product_price, products.product_location FROM products", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuDataGridView1.DataSource = dt;
            }

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
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(DISTINCT order_id) FROM orders ",conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    numOrders.Text = dr[0].ToString();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(customer_id) FROM customers ", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    customersNum.Text = dr[0].ToString();
                }
            }

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT SUM(order_total) FROM orders ", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    totalSales.Text = dr[0].ToString() + " лв.";
                }
            }

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                usersDataGridView.AutoGenerateColumns = false;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers ", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                usersDataGridView.DataSource = dt;
            }

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT order_id FROM orders ORDER BY order_id DESC LIMIT 1", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lastOrder = int.Parse(dr[0].ToString());
                }
            }
            materialTextBox4.Text = (lastOrder + 1).ToString();

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
            bunifuDataGridView2.AutoGenerateColumns = false;
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT customers.address, customers.city, customers.country, customers.first_name, customers.last_name, customers.middle_name, customers.phone, orders.order_id, orders.order_date, orders.order_status, products.product_name, products.product_price, order_items.item_quantity, order_items.item_quantity*products.product_price AS Expr1 FROM products INNER JOIN((customers INNER JOIN orders ON customers.customer_id = orders.customer_id) INNER JOIN order_items ON orders.order_id = order_items.order_id) ON products.product_id = order_items.product_id WHERE customers.first_name=@c_name OR customers.phone=@phone OR customers.email=@email OR order_items.order_id=@orderID AND((orders.order_date)Between @date1 And @date2)", conn);
                cmd.Parameters.AddWithValue("@c_name", materialTextBox2.Text);
                cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@orderID", orderIDBox.Text);
                cmd.Parameters.AddWithValue("@date1", guna2DateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@date2", guna2DateTimePicker2.Value.Date);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    searchResult.Visible = true;
                    nameClient.Text = $"{dr["first_name"].ToString()} {dr["middle_name"].ToString()} {dr["last_name"].ToString()}";
                    TempData.CancelOrderNumber = dr["order_id"].ToString();
                    orderNumber.Text = dr["order_id"].ToString();
                    phoneClient.Text = dr["phone"].ToString();
                    addressClient.Text = dr["address"].ToString() + ", " + dr["city"].ToString() + ", " + dr["country"].ToString();
                    orderNumber.Text = dr["order_id"].ToString();
                    OrderDate.Text = dr["order_date"].ToString();
                    OrderStatus.Text = dr["order_status"].ToString();
                }
                else
                {
                    MessageBox.Show("Въвели сте грешни данни!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT products.product_name, order_items.item_quantity, products.product_price, order_items.item_price FROM products INNER JOIN ((customers INNER JOIN orders ON customers.customer_id = orders.customer_id) INNER JOIN order_items ON orders.order_id = order_items.order_id) ON products.product_id = order_items.product_id WHERE order_items.order_id=@order_id", conn);
                cmd.Parameters.AddWithValue("@order_id", orderNumber.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuDataGridView2.DataSource = dt;
            }
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            searchResult.Visible = false;
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            if (OrderStatus.Text == "cancelled")
            {
                MessageBox.Show("Поръчката вече е отменена!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CancelOrder c = new CancelOrder();
                c.Show();
            }
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            ProductsRec p = new ProductsRec();
            p.Show();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            NewUser n = new NewUser();
            n.Show();
        }

        private void resendLoginDetails_Click(object sender, EventArgs e)
        {
            ResendLoginDetails r = new ResendLoginDetails();
            r.Show();
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            TempData.UserEditID = usersDataGridView.CurrentRow.Cells["id"].Value.ToString();
            EditUser d = new EditUser();
            d.Show();
        }

        private void delUser_Click(object sender, EventArgs e)
        {
            string selected_id = usersDataGridView.CurrentRow.Cells["id"].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM customers WHERE customer_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", selected_id);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Потребителят е изтрит успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = bunifuDataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(String.Format("Наистина ли искате да изтриете записа?", row.Cells["Column2"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(Data.conn))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM products WHERE product_id=@id", conn);
                        cmd.Parameters.AddWithValue("@id", row.Cells["Column2"].Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void materialButton17_Click(object sender, EventArgs e)
        {
            NewProduct n = new NewProduct();
            n.Show();
        }

        private void materialButton18_Click(object sender, EventArgs e)
        {
            TempData.ProductEditID = bunifuDataGridView1.CurrentRow.Cells["id_col"].Value.ToString();
            EditProduct d = new EditProduct();
            d.Show();
        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            string selected_id = bunifuDataGridView1.CurrentRow.Cells["id_col"].Value.ToString();

            DialogResult dr = MessageBox.Show("Наистина ли искате да изтриете продукта?", "Изтриване", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(Data.conn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM products WHERE product_id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", selected_id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Продуктът е изтрит успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bunifuDataGridView1.DataSource = null;
                bunifuDataGridView1.Rows.Clear();
                bunifuDataGridView1.AutoGenerateColumns = false;


                using (MySqlConnection conn = new MySqlConnection(Data.conn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT products.product_id, products.product_name, products.product_type, products.product_sku, products.product_quantity, products.product_price, products.product_location FROM products WHERE products.product_name LIKE '%" + titleTxt.Text + "%' OR products.product_sku LIKE '%" + barcodeTxt.Text + "%'", conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);


                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bunifuDataGridView1.DataSource = dt;
                }
            }
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = null;
            bunifuDataGridView1.Rows.Clear();
            bunifuDataGridView1.AutoGenerateColumns = false;


            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT products.product_id, products.product_name, products.product_type, products.product_sku, products.product_quantity, products.product_price, products.product_location FROM products WHERE products.product_name LIKE '" + titleTxt.Text + "%'", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);


                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuDataGridView1.DataSource = dt;
            }
        }

        private void materialButton15_Click(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = null;
            bunifuDataGridView1.Rows.Clear();
            bunifuDataGridView1.AutoGenerateColumns = false;


            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT products.product_id, products.product_name, products.product_type, products.product_sku, products.product_quantity, products.product_price, products.product_location FROM products WHERE products.product_name LIKE '%" + titleTxt.Text + "%' OR products.product_sku LIKE '%" + barcodeTxt.Text + "%'", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);


                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuDataGridView1.DataSource = dt;
            }
        }

        int lastOrder = 0;
                            //
        private void materialButton19_Click(object sender, EventArgs e)
        {
            addtocart.Visible = true;
        }

        private void cart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in cart.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDouble(row.Cells["dataGridViewTextBoxColumn2"].Value) * Convert.ToDouble(row.Cells["product_price"].Value);
            }

            double total = cart.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDouble(t.Cells[4].Value));
            totalWithVAT.Text = total.ToString();

            double totalWithoutVATD = double.Parse(totalWithVAT.Text) - (0.2 * double.Parse(totalWithVAT.Text));
        }

        private void productSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cart.AutoGenerateColumns = false;
                using (MySqlConnection conn = new MySqlConnection(Data.conn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM products WHERE product_id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", productSearch.Text);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int iNewRowIndex = cart.Rows.Add();
                        cart.Rows[iNewRowIndex].Cells["product_id"].Value = dr["product_id"].ToString();
                        cart.Rows[iNewRowIndex].Cells["product_name"].Value = dr["product_name"].ToString();
                        cart.Rows[iNewRowIndex].Cells["dataGridViewTextBoxColumn2"].Value = 1;
                        cart.Rows[iNewRowIndex].Cells["product_price"].Value = dr["product_price"].ToString();
                        //cart.Rows[iNewRowIndex].Cells["wholesalePrice"].Value = Convert.ToDouble(cart.Rows[iNewRowIndex].Cells["retailPrice"].Value) - (0.2 * Convert.ToDouble(cart.Rows[iNewRowIndex].Cells["retailPrice"].Value));
                    }
                }
                addtocart.Visible = false;
            }
        }

        private void clientPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                using (MySqlConnection conn = new MySqlConnection(Data.conn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers WHERE phone=@phone", conn);
                    cmd.Parameters.AddWithValue("@phone", clientPhone.Text);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CustomerPromoCode = dr["promo_code"].ToString();
                        clientName.Text = dr["first_name"].ToString() + " " + dr["middle_name"].ToString() + " " + dr["last_name"].ToString();
                        clientAddress.Text = dr["address"].ToString() + ", " + dr["city"].ToString() + ", " + dr["country"].ToString();
                        clientPhoneBox.Text = dr["phone"].ToString();
                        clientEmail.Text = dr["email"].ToString();

                        CustomerID = dr["customer_id"].ToString();
                        CustomerAddress = dr["address"].ToString();
                        CustomerCity = dr["city"].ToString();
                        CustomerPostalCode = dr["post_code"].ToString();
                    }
                }
            }
        }

        

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked == true)
            {
                materialTextBox8.Text = clientName.Text;
                materialTextBox7.Text = CustomerAddress;
                materialTextBox6.Text = CustomerCity;
                materialTextBox5.Text = CustomerPostalCode;
            }
            else
            {
                materialTextBox8.Clear();
                materialTextBox7.Clear();
                materialTextBox6.Clear();
                materialTextBox5.Clear();
            }
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            int OrderID = 0;
            string order_date = "";

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO orders (customer_id, order_date, order_status) VALUES (@CustomerID, @OrderDate, @OrderStatus)", conn);
                //cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@CustomerID", int.Parse(CustomerID));
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@OrderStatus", "pending");
                cmd.ExecuteNonQuery();

                order_date = DateTime.Now.ToString();
            }
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM orders ORDER BY order_id DESC LIMIT 1", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    OrderID = int.Parse(dr["order_id"].ToString());
                }
            }
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                for (int i = 0; i < cart.Rows.Count - 1; i++)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO order_items (order_id, product_id, item_quantity, item_price) VALUES (@OrderID, @ProductID, @Quantity, @Total)", conn);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@ProductID", cart.Rows[i].Cells["product_id"].Value);
                    cmd.Parameters.AddWithValue("@Quantity", cart.Rows[i].Cells["dataGridViewTextBoxColumn2"].Value);
                    cmd.Parameters.AddWithValue("@Total", cart.Rows[i].Cells["Total"].Value);
                    cmd.ExecuteNonQuery();
                }
            }
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                for (int i = 0; i < cart.Rows.Count - 1; i++)
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE orders SET order_total=@order_total WHERE order_id=@OrderID", conn);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@order_total", totalWithVAT.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Поръчката е направена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string customer_name = "";
            string customer_email = "";
            

            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers WHERE customer_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", CustomerID);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    customer_name = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                    customer_email = dr["email"].ToString();
                }
            }
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("envirestores@gmail.com");
                mail.To.Add(customer_email);
                mail.Subject = "Order Registration Confirmation";
                mail.Body = $"Dear {customer_name},\r\n\r\nWe are writing to confirm the successful registration of your order. We would like to thank you for choosing Envire Stores for your purchase. Your order has been received and is now being processed.\r\n\r\nHere are the details of your order:\r\n\r\nOrder Number: {OrderID}\r\nOrder Date: {order_date}\r\nOrder Total: {totalWithVAT.Text}\r\n\r\nPlease note that you will receive an email with the shipping information once your order has been dispatched. You can also track your order by logging into your account on our website.\r\n\r\nIf you have any questions or concerns about your order, please feel free to contact us. We are always happy to help.\r\n\r\nThank you for your business.\r\n\r\nSincerely,\r\n\r\nAtanas Iliev\r\nEnvire WMS";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("envirestores@gmail.com", "toxomvkuxvdcpegm");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void vaucherCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (CustomerPromoCode == vaucherCode.Text)
                {
                    double TotalWithVaucher = double.Parse(totalWithVAT.Text) - (0.1 * double.Parse(totalWithVAT.Text));
                    totalWithVAT.Text = TotalWithVaucher.ToString();
                }
            }
        }

        private void materialExpansionPanel2_SaveClick(object sender, EventArgs e)
        {
            if (currPassBox.Text == LogData.Password)
            {
                if (newPassBox.Text == confPassBox.Text)
                {
                    using (MySqlConnection conn = new MySqlConnection(Data.conn))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE customers SET password=@pass WHERE username=@user", conn);
                        cmd.Parameters.AddWithValue("@pass", newPassBox.Text);
                        cmd.Parameters.AddWithValue("@user", usernameBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Паролата е сменена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("envirestores@gmail.com");
                    mail.To.Add(email.Text);
                    mail.Subject = "Password change confirmation";
                    mail.Body = $"Dear {LogData.FirstName},\r\n\r\nThis is a confirmation that the password for your account has been successfully changed.\r\n\r\nWe have received a request to change the password for the account associated with this email address. If you made this request, then you can disregard this message as it was completed successfully.\r\n\r\nHowever, if you did not initiate this password change, we advise you to immediately reset your password and contact our support team for further assistance.\r\n\r\nPlease do not reply to this message as it was sent from an unmonitored email address.\r\n\r\nBest regards,\r\nEnvire WMS Support Team.";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new NetworkCredential("envirestores@gmail.com", "toxomvkuxvdcpegm");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);

                    materialExpansionPanel2.Collapse = true;
                    currPassBox.Clear();
                    newPassBox.Clear();
                    confPassBox.Clear();
                }
                else
                {
                    MessageBox.Show("Паролите не съвпадат!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Грешна парола!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addReceive_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE products SET product_quantity=product_quantity+@quantity WHERE product_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", item.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Стоката е добавена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                item.SelectedIndex = -1;
                quantity.Clear();
                priceRec.Clear();
            }
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT products.product_name, products.product_price, products.product_quantity, products.product_quantity*products.product_price AS sum FROM products", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bunifuDataGridView3.DataSource = dt;


            }
        }
    }
}
