using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envire
{
    public partial class CancelOrder : MaterialForm
    {
        public CancelOrder()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = FillSettingsFile.UITheme;
            materialSkinManager.ColorScheme = FillSettingsFile.UIColorScheme;
        }

        private void saveStatus_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Data.conn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE orders SET order_status=@status WHERE order_id=@orderNumber", conn);
                cmd.Parameters.AddWithValue("@orderNumber", orderNumberCancel.Text);
                cmd.Parameters.AddWithValue("@status", "cancelled");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Поръчката е отменена успешно!", "Отменена поръчка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CancelOrder_Load(object sender, EventArgs e)
        {
            orderNumberCancel.Text = TempData.CancelOrderNumber;
        }
    }
}
