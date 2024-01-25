namespace Message_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("یکی رو فقط انتخاب کن", "فقط بزن", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            switch(dialogResult)
            {
                case DialogResult.Yes:
                    lbl.Text = "کاربر اوکی داد";
                    break;
                case DialogResult.No:
                    lbl.Text = "کاربر اوکی نداد";
                    break;
                case DialogResult.Cancel:
                    lbl.Text = "کاربر هیچی نکرد";
                    break;
            }
        }
    }
}
