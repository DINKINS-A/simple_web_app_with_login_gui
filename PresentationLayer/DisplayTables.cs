namespace PresentationLayer
{
    public partial class DisplayTables : Form
    {

        private BusinessLayer businessLayer;

        public DisplayTables()
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();
        }

        public DisplayTables(string connectionString)
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();
            businessLayer.SetConnectionString(connectionString);
        }

        private void btnDisplayOrders_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayOrders displayOrders = new (businessLayer.GetConnectionString());
                displayOrders.ShowDialog(this);
            } catch (Exception exception)
            {
                Error error = new(exception.Message);
                error.ShowDialog(this);
            }

        }

        private void btnDisplayEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayEmployees displayEmployees = new(businessLayer.GetConnectionString());
                displayEmployees.ShowDialog(this);
            }
            catch (Exception exception)
            {
                Error error = new(exception.Message);
                error.ShowDialog(this);
            }
        }

        private void btnDisplayCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayCustomers displayCustomers = new(businessLayer.GetConnectionString());
                displayCustomers.ShowDialog(this);
            }
            catch (Exception exception)
            {
                Error error = new(exception.Message);
                error.ShowDialog(this);
            }
        }
    }
}
