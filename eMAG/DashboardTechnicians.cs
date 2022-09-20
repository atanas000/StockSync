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

        private void DashboardTechnicians_Load(object sender, EventArgs e)
        {
            this.Text = "eMAG International" + " | " + LogData.Position;
            //userLoged.Text = LogData.FirstName + " " + LogData.LastName;
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers INNER JOIN orders ON customers.id=orders.OrderID WHERE customers.phone=@phone OR customers.email=@email OR orders.OrderID=@orderID", conn);
                cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@orderID", orderIDBox.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    searchResult.Visible = true;
                    nameClient.Text = $"{dr["firstName"].ToString()} {dr["middleName"].ToString()} {dr["lastName"].ToString()}";
                    phoneClient.Text = dr["phone"].ToString();
                    addressClient.Text = dr["address"].ToString();
                    cityClient.Text = dr["city"].ToString();
                    countryClient.Text = dr["country"].ToString();
                }
                else
                {
                    MessageBox.Show("Въвели сте грешни данни!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            searchResult.Visible = false;
        }
    }
}
