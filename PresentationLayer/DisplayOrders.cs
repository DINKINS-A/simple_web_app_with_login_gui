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
    public partial class DisplayOrders : Form
    {

        private BusinessLayer businessLayer;
        private List<List<string>> _orderTableData;

        public DisplayOrders()
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();

            _orderTableData = businessLayer.GetOrderData();

        }

        public DisplayOrders(string connectionString)
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();
            businessLayer.SetConnectionString(connectionString);

            _orderTableData = businessLayer.GetOrderData();
        }

        private void DisplayOrders_Load(object sender, EventArgs e)
        {
            ListView view = new()
            {
                View = View.Details,
                Dock = DockStyle.Fill,
                Height = 600,
                GridLines = true
            };

            view.Columns.Add("Order Id", 10);
            view.Columns.Add("Customer Id", 150);
            view.Columns.Add("Employee Id", 150);
            view.Columns.Add("Order Date", 200);
            view.Columns.Add("Required Date", 200);
            view.Columns.Add("Shipped Date", 200);
            view.Columns.Add("Ship via", 200);
            view.Columns.Add("Freight", 200);
            view.Columns.Add("Ship Name", 300);
            view.Columns.Add("Ship Address", 600);
            view.Columns.Add("Ship City", 200);
            view.Columns.Add("Ship Region", 200);
            view.Columns.Add("Ship Postal Code", 150);
            view.Columns.Add("Ship Country", 200);

            foreach (List<string> record in _orderTableData) 
            {
                view.Items.Add(new ListViewItem([.. record]));
            }

            Controls.Add(view);

            Popup popup = new Popup($"Record Count: {businessLayer.GetNumOrders()}");
            popup.ShowDialog(this);
        }

        
    }
}
