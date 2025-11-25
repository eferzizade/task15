namespace task_15
{
    public partial class Form1 : Form
    {
        bool showCVC = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCVC.Text))
            {
                MessageBox.Show("Zəhmət olmasa bütün məlumatları daxil edin!",
                                "Xəta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePicker1.Value <= DateTime.Now)
            {
                MessageBox.Show("Tarix cari vaxtdan böyük olmalıdır!",
                                "Xəta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            lblCardNumber.Text = txtCardNumber.Text;
            lblName.Text = txtName.Text;
            lblDate.Text = dateTimePicker1.Value.ToString("MM/yy");
            lblCVC.Text = "***";
        }

        private void picEye_Click(object sender, EventArgs e)
        {

        }

        private void picEye_MouseEnter(object sender, EventArgs e)
        {
            lblCVC.Text = txtCVC.Text;
        }

        private void picEye_MouseLeave(object sender, EventArgs e)
        {
            lblCVC.Text = "***";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCardNumber.Clear();
            txtName.Clear();
            txtCVC.Clear();

            dateTimePicker1.Value = DateTime.Now;

            lblCardNumber.Text = "---- ---- ---- ----";
            lblName.Text = "";
            lblDate.Text = "--/--";
            lblCVC.Text = "***";

            txtCardNumber.Focus();
        }
    }
}
