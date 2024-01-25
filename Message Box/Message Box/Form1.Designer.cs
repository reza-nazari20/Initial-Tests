namespace Message_Box
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
            button1 = new Button();
            lbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Location = new Point(234, 204);
            button1.Name = "button1";
            button1.Size = new Size(168, 96);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.LightSalmon;
            lbl.Location = new Point(272, 48);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 20);
            lbl.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 380);
            Controls.Add(lbl);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbl;
    }
}
