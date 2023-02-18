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
using System.Net.Mail;
using System.Net;

namespace Envire
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
            email.Text = LogData.Email;
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
