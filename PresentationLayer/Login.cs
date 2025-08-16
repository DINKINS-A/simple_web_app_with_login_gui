using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PresentationLayer
{
    public partial class Login : Form
    {

        private BusinessLayer businessLayer;

        public Login()
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var textBoxServerName = this.Controls.Find("textBoxServerName", true)[0];
            var textBoxDatabaseName = this.Controls.Find("textBoxDatabaseName", true)[0];
            var textBoxUserName = this.Controls.Find("textBoxUserName", true)[0];
            var textBoxPassword = this.Controls.Find("textBoxPassword", true)[0];

            string connectionString = $"Server={textBoxServerName.Text};Database={textBoxDatabaseName.Text};User Id={textBoxUserName.Text};Password={textBoxPassword.Text};TrustServerCertificate=true;";

            bool isValidConnection = businessLayer.ValidateConnectionString(connectionString);

            if (isValidConnection)
            {
                businessLayer.SetConnectionString(connectionString);
                DisplayTables displayTables = new(connectionString);
                Hide();
                displayTables.ShowDialog(this);
                Show();
            }
            else
            {
                Error loginError = new("Invalid Connection Attempt");
                loginError.ShowDialog(this);
            }
        }
    }
}
