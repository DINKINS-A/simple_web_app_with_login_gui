namespace PresentationLayer
{
    partial class Popup
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
            textBoxMessage = new TextBox();
            SuspendLayout();
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(219, 102);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(150, 31);
            textBoxMessage.TabIndex = 0;
            // 
            // Popup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 253);
            Controls.Add(textBoxMessage);
            Name = "Popup";
            Text = "Popup";
            Load += Popup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMessage;
    }
}