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
    public partial class Popup : Form
    {

        private string _messgae;
        public Popup()
        {
            InitializeComponent();
            _messgae = string.Empty;
        }

        public Popup(string message)
        {
            InitializeComponent();
            _messgae = message;
        }

        private void Popup_Load(object sender, EventArgs e)
        {
            var textBox = this.Controls.Find("textBoxMessage", true)[0];

            textBox.Text = _messgae;
        }
    }
}
