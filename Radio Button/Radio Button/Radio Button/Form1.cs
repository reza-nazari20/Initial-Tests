namespace Radio_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbkhan.Checked == true)
            {
                lblkh.Text = ":) تو یک خانی";
            }
            else if (rdbnakhan.Checked == true)
            {
                lblkh.Text = ":| تو یک ناخانی";
            }

            if (rdbkaraj.Checked == true)
            {
                lblogh.Text = ":( تو عقاب نیستی";
            }
            else if (rdblak.Checked == true)
            {
                lblogh.Text = ":)))) تو یه عقاااب تو فلکییی";
            }
        }
    }
}
