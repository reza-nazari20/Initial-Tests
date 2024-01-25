namespace ComboBox_and_more
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
            btnOK = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            listBox1 = new ListBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Chartreuse;
            btnOK.Location = new Point(182, 505);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(109, 47);
            btnOK.TabIndex = 0;
            btnOK.Text = "تایید";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 15);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 3;
            label1.Text = "نام :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 70);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 4;
            label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 147);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "شهر :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "همدان", "اصفهان", "نهاوند", "آبدر", "دهریز", "ملایر", "تویسرکان", "شوشاب" });
            comboBox1.Location = new Point(168, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 239);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 7;
            label4.Text = "تخصص :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "طراح سایت", "برنامه نویس دسکتاپ", "وردپرس", "سئوکار", "دیزاینر" });
            listBox1.Location = new Point(167, 219);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 386);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 9;
            label5.Text = "وضعیت بیمه :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(190, 385);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "بیمه دارم";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 620);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnOK);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "به نام خدا";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ListBox listBox1;
        private Label label5;
        private CheckBox checkBox1;
    }
}
