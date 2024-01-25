namespace Radio_Button
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rdbkhan = new RadioButton();
            rdbnakhan = new RadioButton();
            rdbkaraj = new RadioButton();
            rdblak = new RadioButton();
            lblkh = new Label();
            lblogh = new Label();
            btnOK = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbnakhan);
            groupBox1.Controls.Add(rdbkhan);
            groupBox1.Location = new Point(412, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جنسیت";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdblak);
            groupBox2.Controls.Add(rdbkaraj);
            groupBox2.Location = new Point(37, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "عقاب بودن با نبودن";
            // 
            // rdbkhan
            // 
            rdbkhan.AutoSize = true;
            rdbkhan.Location = new Point(88, 36);
            rdbkhan.Name = "rdbkhan";
            rdbkhan.Size = new Size(53, 24);
            rdbkhan.TabIndex = 0;
            rdbkhan.TabStop = true;
            rdbkhan.Text = "خان";
            rdbkhan.UseVisualStyleBackColor = true;
            // 
            // rdbnakhan
            // 
            rdbnakhan.AutoSize = true;
            rdbnakhan.Location = new Point(88, 80);
            rdbnakhan.Name = "rdbnakhan";
            rdbnakhan.Size = new Size(62, 24);
            rdbnakhan.TabIndex = 1;
            rdbnakhan.TabStop = true;
            rdbnakhan.Text = "ناخان";
            rdbnakhan.UseVisualStyleBackColor = true;
            // 
            // rdbkaraj
            // 
            rdbkaraj.AutoSize = true;
            rdbkaraj.Location = new Point(62, 36);
            rdbkaraj.Name = "rdbkaraj";
            rdbkaraj.Size = new Size(66, 24);
            rdbkaraj.TabIndex = 0;
            rdbkaraj.TabStop = true;
            rdbkaraj.Text = "کرجی";
            rdbkaraj.UseVisualStyleBackColor = true;
            // 
            // rdblak
            // 
            rdblak.AutoSize = true;
            rdblak.Location = new Point(62, 80);
            rdblak.Name = "rdblak";
            rdblak.Size = new Size(49, 24);
            rdblak.TabIndex = 1;
            rdblak.TabStop = true;
            rdblak.Text = "لک";
            rdblak.UseVisualStyleBackColor = true;
            // 
            // lblkh
            // 
            lblkh.AutoSize = true;
            lblkh.Location = new Point(503, 214);
            lblkh.Name = "lblkh";
            lblkh.Size = new Size(0, 20);
            lblkh.TabIndex = 2;
            // 
            // lblogh
            // 
            lblogh.AutoSize = true;
            lblogh.Location = new Point(111, 214);
            lblogh.Name = "lblogh";
            lblogh.Size = new Size(0, 20);
            lblogh.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.IndianRed;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(298, 295);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(114, 68);
            btnOK.TabIndex = 4;
            btnOK.Text = "تایید";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 432);
            Controls.Add(btnOK);
            Controls.Add(lblogh);
            Controls.Add(lblkh);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbnakhan;
        private RadioButton rdbkhan;
        private GroupBox groupBox2;
        private RadioButton rdblak;
        private RadioButton rdbkaraj;
        private Label lblkh;
        private Label lblogh;
        private Button btnOK;
    }
}
