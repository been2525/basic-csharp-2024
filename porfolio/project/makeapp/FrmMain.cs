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
            MessageBox.Show("�����Ǿ����ϴ�.");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��ҵǾ����ϴ�.");
        }
    }
}
