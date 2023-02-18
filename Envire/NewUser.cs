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
using System.Net.Http;
using Newtonsoft.Json;

namespace Envire
{
    public partial class NewUser : MaterialForm
    {
        public NewUser()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            bool check = false;
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers WHERE username=@user", conn);
                cmd.Parameters.AddWithValue("@user", username.Text);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    check = true;
                }
            }

            if (check)
            {
                MessageBox.Show("Акаунт с това потребителско име вече съществува!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(Data.conn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO customers (first_name, middle_name, last_name, phone, email, country, city, post_code, address, username, password, role) VALUES (@first_name, @middle_name, @last_name, @phone, @email, @country, @city, @post_code, @address, @username, @password, @role)", conn);
                    cmd.Parameters.AddWithValue("@first_name", firstname.Text);
                    cmd.Parameters.AddWithValue("@middle_name", middlename.Text);
                    cmd.Parameters.AddWithValue("@last_name", lastname.Text);
                    cmd.Parameters.AddWithValue("@phone", phone.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@country", country.Text);
                    cmd.Parameters.AddWithValue("@city", city.Text);
                    cmd.Parameters.AddWithValue("@post_code", postcode.Text);
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    cmd.Parameters.AddWithValue("@role", role.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Потребителят е добавен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("envirestores@gmail.com");
                mail.To.Add(email.Text);
                mail.Subject = "Welcome to Envire WMS";
                mail.Body = $"Dear {firstname.Text} {lastname.Text},\r\n\r\nThank you for registering with Envire WMS! We are excited to have you as a part of our community.\r\n\r\nAs a registered member, you now have access to all of our services. To log in to your account, please use the following details:\r\n\r\nUsername: {username.Text}\r\nPassword: {password.Text}\r\n\r\nWe recommend that you change your password once you log in for the first time to ensure the security of your account.\r\n\r\nWe are always here to assist you with any questions or concerns you may have. Please don't hesitate to reach out to our customer support team for assistance.\r\n\r\nThank you again for joining Envire WMS and we look forward to working with you.\r\n\r\nBest regards,\r\nAtanas Iliev\r\nEnvire WMS Team";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("envirestores@gmail.com", "toxomvkuxvdcpegm");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                this.Hide();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            firstname.Clear();
            middlename.Clear();
            lastname.Clear();
            phone.Clear();
            email.Clear();
            country.Clear();
            city.Clear();
            address.Clear();
            postcode.Clear();
            username.Clear();
            password.Clear();
            role.SelectedIndex = 0;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            role.SelectedIndex = 0;
        }
    }
}
