namespace PresentationLayer
{
    public partial class DisplayCustomers : Form
    {

        private BusinessLayer businessLayer;

        public DisplayCustomers()
        {
            InitializeComponent();
            businessLayer = new BusinessLayer();
        }

        private void DisplayCustomers_Load(object sender, EventArgs e)
        {

        }

        private void btn_DisplayNumCustomers_Click(object sender, EventArgs e)
        {
            var numCustomers = businessLayer.GetNumCustomers();
            var textBox = this.Controls.Find("textBoxNumCustomers", true)[0];

            textBox.Text = numCustomers.ToString();
        }

        private void btn_DisplayCustomerNames_Click(object sender, EventArgs e)
        {
            List<string> customerNames = businessLayer.GetCustomerNames();
            ListView view = new();
            view.Location = new Point(422, 150);

            view.Columns.Add("First Name", 150);
            view.Columns.Add("Last Name", 150);
            view.Width = 300;
            view.Height = 500;
            view.View = View.Details;
            view.GridLines = true;

            foreach (string customerName in customerNames)
            {
                view.Items.Add(new ListViewItem(customerName.Split(' ')));
            }

            Controls.Add(view);
        }
    }
}
