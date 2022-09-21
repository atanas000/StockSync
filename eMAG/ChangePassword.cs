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
    public partial class ChangePassword : MaterialForm
    {
        public ChangePassword()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            usernameBox.Text = LogData.Username;
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            if (currPassBox.Text == LogData.Password)
            {
                if (newPassBox.Text == confPassBox.Text)
                {
                    using (MySqlConnection conn = new MySqlConnection(Data.conn))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE users SET password=@pass WHERE username=@user", conn);
                        cmd.Parameters.AddWithValue("@pass", newPassBox.Text);
                        cmd.Parameters.AddWithValue("@user", usernameBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Паролата е сменена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
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
    }
}
