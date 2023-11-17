namespace PRN211_HE171691_FOODSHOP_WINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();//temporary hide form login
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}