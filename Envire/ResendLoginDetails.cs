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
using MaterialSkin;
using System.Net.Mail;
using System.Net;
using System.ServiceModel.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Envire
{
    public partial class ResendLoginDetails : MaterialForm
    {
        string name = "";
        string email = "";
        string username = "";
        string password = "";
        public ResendLoginDetails()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void ResendLoginDetails_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    users.Items.Add(dr["username"]);
                }
            }
        }
        
        private void addUser_Click(object sender, EventArgs e)
        {
            int selectedItem = users.SelectedIndex + 1;
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customers WHERE customer_id=@id", conn);
                cmd.Parameters.AddWithValue("id", selectedItem);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    name = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                    email = dr["email"].ToString();
                    username = dr["username"].ToString();
                    password = dr["password"].ToString();
                }
            }

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("envirestores@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Welcome to Envire WMS";
            mail.Body = $"Dear {name},\r\n\r\nThank you for registering with Envire WMS! We are excited to have you as a part of our community.\r\n\r\nAs a registered member, you now have access to all of our services. To log in to your account, please use the following details:\r\n\r\nUsername: {username}\r\nPassword: {password}\r\n\r\nWe recommend that you change your password once you log in for the first time to ensure the security of your account.\r\n\r\nWe are always here to assist you with any questions or concerns you may have. Please don't hesitate to reach out to our customer support team for assistance.\r\n\r\nThank you again for joining Envire WMS and we look forward to working with you.\r\n\r\nBest regards,\r\nAtanas Iliev\r\nEnvire WMS Team";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential("envirestores@gmail.com", "toxomvkuxvdcpegm");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            MessageBox.Show("Имейлът е изпратен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
