namespace WinFormsApp2
{
    partial class Form1
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
            lbllMessage = new Button();
            SuspendLayout();
            // 
            // lbllMessage
            // 
            lbllMessage.Location = new Point(310, 167);
            lbllMessage.Name = "lbllMessage";
            lbllMessage.Size = new Size(164, 70);
            lbllMessage.TabIndex = 0;
            lbllMessage.Text = "Click - Me";
            lbllMessage.UseVisualStyleBackColor = true;
            lbllMessage.Click += lbllMessage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbllMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button lbllMessage;
    }
}
