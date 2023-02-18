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
using System.Net.Mail;
using System.Net;

namespace Envire
{
    public partial class EditUser : MaterialForm
    {
        public EditUser()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers WHERE customer_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", TempData.UserEditID);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    firstname.Text = dr["first_name"].ToString();
                    middlename.Text = dr["middle_name"].ToString();
                    lastname.Text = dr["last_name"].ToString();
                    phone.Text = dr["phone"].ToString();
                    email.Text = dr["email"].ToString();
                    country.Text = dr["country"].ToString();
                    city.Text = dr["city"].ToString();
                    postcode.Text = dr["post_code"].ToString();
                    address.Text = dr["address"].ToString();
                    username.Text = dr["username"].ToString();
                    password.Text = dr["password"].ToString();
                    role.Text = dr["role"].ToString();
                }
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE customers SET phone=@phone, email=@email, username=@username, password=@password WHERE customer_id=@id", conn);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue ("email", email.Text);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@id", TempData.UserEditID);

                cmd.ExecuteNonQuery();

                DialogResult dr = MessageBox.Show("Потребителят е редактиран успешно! Искате ли да изпратите имейл с данни за вход?", "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("envirestores@gmail.com");
                    mail.To.Add(email.Text);
                    mail.Subject = "Account Details Changed";
                    mail.Body = $"Dear {firstname.Text} {lastname.Text},\r\n\r\nThis is a confirmation that your account details have been changed by administrator for your account.\r\n\r\nBest regards,\r\nEnvire WMS";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new NetworkCredential("envirestores@gmail.com", "toxomvkuxvdcpegm");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                this.Hide();
            }
        }
    }
}
