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
using System.IO;

namespace Envire
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void testConBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection($"server={ipDB.Text};port={portDB.Text};database={DB.Text};uid={usrDB.Text};pwd={passDB.Text}"))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void advancedWizard1_Finish(object sender, EventArgs e)
        {
            MessageBox.Show("Data saved successfully! The app will restart now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (StreamWriter sw = new StreamWriter("Settings.txt", true))
            {
                sw.WriteLine(ipDB.Text);
                sw.WriteLine(portDB.Text);
                sw.WriteLine(DB.Text);
                sw.WriteLine(usrDB.Text);
                sw.WriteLine(passDB.Text);
            }
            Application.Restart();
        }
    }
}
