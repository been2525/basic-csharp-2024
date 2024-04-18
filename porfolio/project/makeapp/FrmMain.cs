namespace makeapp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제되었습니다.");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소되었습니다.");
        }
    }
}
