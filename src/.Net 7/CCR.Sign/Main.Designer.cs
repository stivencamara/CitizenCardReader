namespace CCR.Sign
{
    partial class Main
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
            signMultipleDocumentsButton = new Button();
            SuspendLayout();
            // 
            // signMultipleDocumentsButton
            // 
            signMultipleDocumentsButton.Location = new Point(12, 12);
            signMultipleDocumentsButton.Name = "signMultipleDocumentsButton";
            signMultipleDocumentsButton.Size = new Size(133, 57);
            signMultipleDocumentsButton.TabIndex = 0;
            signMultipleDocumentsButton.Text = "Sign multiple documents";
            signMultipleDocumentsButton.UseVisualStyleBackColor = true;
            signMultipleDocumentsButton.Click += signMultipleDocumentsButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 80);
            Controls.Add(signMultipleDocumentsButton);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citizen Card Reader - Demo";
            ResumeLayout(false);
        }

        #endregion

        private Button signMultipleDocumentsButton;
    }
}