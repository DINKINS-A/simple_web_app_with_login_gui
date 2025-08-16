namespace PresentationLayer
{
    partial class DisplayTables
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
            btnDisplayCustomers = new Button();
            btnDisplayEmployees = new Button();
            btnDisplayOrders = new Button();
            SuspendLayout();
            // 
            // btnDisplayCustomers
            // 
            btnDisplayCustomers.Location = new Point(22, 21);
            btnDisplayCustomers.Name = "btnDisplayCustomers";
            btnDisplayCustomers.Size = new Size(220, 34);
            btnDisplayCustomers.TabIndex = 0;
            btnDisplayCustomers.Text = "Display Customer Table";
            btnDisplayCustomers.UseVisualStyleBackColor = true;
            btnDisplayCustomers.Click += btnDisplayCustomers_Click;
            // 
            // btnDisplayEmployees
            // 
            btnDisplayEmployees.Location = new Point(300, 21);
            btnDisplayEmployees.Name = "btnDisplayEmployees";
            btnDisplayEmployees.Size = new Size(210, 34);
            btnDisplayEmployees.TabIndex = 2;
            btnDisplayEmployees.Text = "Display Employee Table";
            btnDisplayEmployees.UseVisualStyleBackColor = true;
            btnDisplayEmployees.Click += btnDisplayEmployees_Click;
            // 
            // btnDisplayOrders
            // 
            btnDisplayOrders.Location = new Point(569, 21);
            btnDisplayOrders.Name = "btnDisplayOrders";
            btnDisplayOrders.Size = new Size(176, 34);
            btnDisplayOrders.TabIndex = 3;
            btnDisplayOrders.Text = "Display Order Table";
            btnDisplayOrders.UseVisualStyleBackColor = true;
            btnDisplayOrders.Click += btnDisplayOrders_Click;
            // 
            // DisplayTables
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisplayOrders);
            Controls.Add(btnDisplayEmployees);
            Controls.Add(btnDisplayCustomers);
            Name = "DisplayTables";
            Text = "Customers";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplayCustomers;
        private TextBox textBoxNumCustomers;
        private Button btnDisplayEmployees;
        private Button btnDisplayOrders;
    }
}
