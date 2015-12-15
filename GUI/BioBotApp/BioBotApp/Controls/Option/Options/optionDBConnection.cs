using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BioBotApp.Controls.Option.Options
{
    public partial class optionDBConnection : UserControl
    {
        public optionDBConnection()
        {
            InitializeComponent();
            txtConnectionString.Text = Properties.Settings.Default.BioBotLocalhostConnectionString;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

           Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
           ConnectionStringsSection connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
           ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["BioBotApp.Properties.Settings.BioBotLocalhostConnectionString"];
           //conSettings.ConnectionString = txtConnectionString.Text;
            //    = "Data Source=blah;Initial Catalog=blah;UID=blah;password=blah";
           config.Save();
           ConfigurationManager.RefreshSection("connectionStrings");
            Properties.Settings.Default.Save();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            System.Data.Odbc.OdbcConnection connection = new System.Data.Odbc.OdbcConnection(txtConnectionString.Text);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed !");
            }
            finally
            {
                if (connection.State.Equals(ConnectionState.Open))
                {
                    MessageBox.Show("Connection succeeded !");
                }
            }
        }
    }
}
