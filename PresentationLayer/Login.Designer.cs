namespace PresentationLayer
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxServerName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxDatabaseName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, -1);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 0;
            label1.Text = "Please Enter Connection Information";
            // 
            // textBoxServerName
            // 
            textBoxServerName.Location = new Point(354, 106);
            textBoxServerName.Name = "textBoxServerName";
            textBoxServerName.Size = new Size(150, 31);
            textBoxServerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 62);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 2;
            label2.Text = "Server name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 162);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 3;
            label3.Text = "Database name:";
            // 
            // textBoxDatabaseName
            // 
            textBoxDatabaseName.Location = new Point(354, 210);
            textBoxDatabaseName.Name = "textBoxDatabaseName";
            textBoxDatabaseName.Size = new Size(150, 31);
            textBoxDatabaseName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 271);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 5;
            label4.Text = "User name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 391);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 6;
            label5.Text = "Password:";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(354, 328);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(150, 31);
            textBoxUserName.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(359, 440);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 31);
            textBoxPassword.TabIndex = 8;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(381, 502);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(112, 34);
            btnEnter.TabIndex = 9;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(btnEnter);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxDatabaseName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxServerName);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxServerName;
        private Label label2;
        private Label label3;
        private TextBox textBoxDatabaseName;
        private Label label4;
        private Label label5;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button btnEnter;
    }
}