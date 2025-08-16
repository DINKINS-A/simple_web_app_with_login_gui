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
    public partial class DisplayEmployees : Form
    {

        private BusinessLayer businessLayer;
        private List<List<string>> _employeeTableData;

        public DisplayEmployees()
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();

            _employeeTableData = businessLayer.GetEmployeeData();
        }

        public DisplayEmployees(string connectionString) 
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();
            businessLayer.SetConnectionString(connectionString);

            _employeeTableData = businessLayer.GetEmployeeData();
        }

        private void DisplayEmployees_Load(object sender, EventArgs e)
        {
            ListView view = new()
            {
                View = View.Details,
                Dock = DockStyle.Fill,
                Height = 600,
                GridLines = true
            };

            view.Columns.Add("Employee Id", 150);
            view.Columns.Add("Last Name", 300);
            view.Columns.Add("FirstName", 300);
            view.Columns.Add("Title", 150);
            view.Columns.Add("Title of Courtesy", 150);
            view.Columns.Add("Birth Date", 200);
            view.Columns.Add("Hire Date", 200);
            view.Columns.Add("Address", 600);
            view.Columns.Add("City", 200);
            view.Columns.Add("Region", 200);
            view.Columns.Add("Postal Code", 150);
            view.Columns.Add("Country", 200);
            view.Columns.Add("Home Phone", 200);
            view.Columns.Add("Salary", 300);
            view.Columns.Add("Extension", 150);
            view.Columns.Add("Photo", 600);
            view.Columns.Add("Notes", 300);
            view.Columns.Add("Reports To", 150);
            view.Columns.Add("Photo Path", 300);

            foreach (List<string> employeeRecord in _employeeTableData)
            {
                view.Items.Add(new ListViewItem([.. employeeRecord]));
            }

            Controls.Add(view);

            Popup popup = new Popup($"Record Count: {businessLayer.GetNumEmployees()}");
            popup.ShowDialog(this);

        }
    }
}
