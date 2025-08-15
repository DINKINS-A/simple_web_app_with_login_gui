namespace PresentationLayer
{
    partial class DisplayCustomers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDisplayNumCustomers = new Button();
            textBoxNumCustomers = new TextBox();
            btn_DisplayCustomerNames = new Button();
            SuspendLayout();
            // 
            // btnDisplayNumCustomers
            // 
            btnDisplayNumCustomers.Location = new Point(32, 96);
            btnDisplayNumCustomers.Name = "btnDisplayNumCustomers";
            btnDisplayNumCustomers.Size = new Size(288, 34);
            btnDisplayNumCustomers.TabIndex = 0;
            btnDisplayNumCustomers.Text = "Display Number of Customers";
            btnDisplayNumCustomers.UseVisualStyleBackColor = true;
            btnDisplayNumCustomers.Click += btn_DisplayNumCustomers_Click;
            // 
            // textBoxNumCustomers
            // 
            textBoxNumCustomers.Location = new Point(42, 140);
            textBoxNumCustomers.Name = "textBoxNumCustomers";
            textBoxNumCustomers.Size = new Size(278, 31);
            textBoxNumCustomers.TabIndex = 1;
            textBoxNumCustomers.Text = "N/A";
            // 
            // btn_DisplayCustomerNames
            // 
            btn_DisplayCustomerNames.Location = new Point(422, 96);
            btn_DisplayCustomerNames.Name = "btn_DisplayCustomerNames";
            btn_DisplayCustomerNames.Size = new Size(294, 34);
            btn_DisplayCustomerNames.TabIndex = 2;
            btn_DisplayCustomerNames.Text = "Display Customer Names";
            btn_DisplayCustomerNames.UseVisualStyleBackColor = true;
            btn_DisplayCustomerNames.Click += btn_DisplayCustomerNames_Click;
            // 
            // DisplayCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DisplayCustomerNames);
            Controls.Add(textBoxNumCustomers);
            Controls.Add(btnDisplayNumCustomers);
            Name = "DisplayCustomers";
            Text = "Customers";
            Load += DisplayCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplayNumCustomers;
        private TextBox textBoxNumCustomers;
        private Button btn_DisplayCustomerNames;
    }
}
