namespace ComboBox_and_more
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string message = "", name, lastname, fullname, city, specialty, insurance;

            name = textBox1.Text;
            lastname = textBox2.Text;

            fullname = name + lastname;

            message +=   fullname + Environment.NewLine;

            city = comboBox1.SelectedItem.ToString();

            message += city + Environment.NewLine;

            specialty = listBox1.SelectedItem.ToString();

            message += specialty + Environment.NewLine;

            insurance = checkBox1.Checked.ToString();

            message += insurance + Environment.NewLine;

            MessageBox.Show(message);
        }
    }
}
