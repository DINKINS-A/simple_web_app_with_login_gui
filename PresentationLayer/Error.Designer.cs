namespace PresentationLayer
{
    partial class Error
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
            errorLabel = new Label();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(24, 68);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(68, 25);
            errorLabel.TabIndex = 0;
            errorLabel.Text = "ERROR";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 160);
            Controls.Add(errorLabel);
            Name = "Error";
            Text = "Error";
            Load += Error_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
    }
}