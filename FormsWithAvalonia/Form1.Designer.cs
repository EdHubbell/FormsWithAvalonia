
namespace FormsWithAvalonia
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
            pnlAvControl = new Panel();
            btnNewWindow = new Button();
            SuspendLayout();
            // 
            // pnlAvControl
            // 
            pnlAvControl.BackColor = Color.FromArgb(255, 192, 192);
            pnlAvControl.Location = new Point(12, 12);
            pnlAvControl.Name = "pnlAvControl";
            pnlAvControl.Size = new Size(300, 400);
            pnlAvControl.TabIndex = 0;
            // 
            // btnNewWindow
            // 
            btnNewWindow.Location = new Point(660, 389);
            btnNewWindow.Name = "btnNewWindow";
            btnNewWindow.Size = new Size(128, 23);
            btnNewWindow.TabIndex = 1;
            btnNewWindow.Text = "New Window";
            btnNewWindow.UseVisualStyleBackColor = true;
            btnNewWindow.Click += btnNewWindow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewWindow);
            Controls.Add(pnlAvControl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAvControl;
        private Button btnNewWindow;
    }
}