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
    public partial class Error : Form
    {

        private string _message = "";
        public Error()
        {
            InitializeComponent();
        }

        public Error(string message)
        {
            InitializeComponent();
            _message = message;
        }

        public void Error_Load(object sender, EventArgs e)
        {
            var errorLabel = this.Controls.Find("errorLabel", true)[0];

            errorLabel.Text = _message;
        }
    }
}
