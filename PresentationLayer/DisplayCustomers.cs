using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DisplayCustomers : Form
    {

        private BusinessLayer businessLayer;
        private List<List<string>> _customerTableData;


        public DisplayCustomers()
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();

            _customerTableData = businessLayer.GetCustomerData();
        }

        public DisplayCustomers(string connectionString) 
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();
            businessLayer.SetConnectionString(connectionString);

            _customerTableData = businessLayer.GetCustomerData();
        }

        private void DisplayCustomers_Load(object sender, EventArgs e)
        {
            ListView view = new()
            {
                View = View.Details,
                Dock = DockStyle.Fill,
                Height = 600,
                GridLines = true
            };

            view.Columns.Add("Customer Id", 150);
            view.Columns.Add("Company Name", 300);
            view.Columns.Add("Contact Name", 200);
            view.Columns.Add("Contact Title", 150);
            view.Columns.Add("Address", 300);
            view.Columns.Add("City", 200);
            view.Columns.Add("Region", 200);
            view.Columns.Add("Postal Code", 150);
            view.Columns.Add("Country", 200);
            view.Columns.Add("Phone", 150);
            view.Columns.Add("Fax", 150);

            foreach(List<string> customerRecord in _customerTableData)
            {
                view.Items.Add(new ListViewItem([.. customerRecord]));
            }

            Controls.Add(view);

            Popup popup = new Popup($"Record Count: {businessLayer.GetNumCustomers()}");
            popup.ShowDialog(this);
        }
    }
}
