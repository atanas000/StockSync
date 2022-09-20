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
using MaterialSkin;
using MaterialSkin.Controls;

namespace eMAG
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username=@user AND password=@pass", conn);
                cmd.Parameters.AddWithValue("@user", userBox.Text);
                cmd.Parameters.AddWithValue("@pass", passBox.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    LogData.FirstName = dr["firstName"].ToString();
                    LogData.MiddleName = dr["middleName"].ToString();
                    LogData.LastName = dr["lastName"].ToString();
                    LogData.Position = dr["position"].ToString();

                    DashboardTechnicians dash1 = new DashboardTechnicians();
                    this.Hide();
                    dash1.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            userBox.Clear();
            passBox.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            FillSettingsFile.ReadFile();
        }
    }
}
