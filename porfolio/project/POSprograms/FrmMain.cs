using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace POSprograms
{
    public partial class FrmMain : MetroForm
    {

        public FrmMain()
        {
            InitializeComponent();
            //this.dataGridView1.CellClick += MultiHeaderGrid_CellClick
            Column3.Items.Add("1");
            Column3.Items.Add("2");
            Column3.Items.Add("3");
            Column3.Items.Add("4");
            Column3.Items.Add("5");
            Column3.Items.Add("6");
            Column3.Items.Add("7");
            Column3.Items.Add("8");
            Column3.Items.Add("9");
            //int sum = (int)(Column2.Index) * (int)(Column3.Index);
            
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 되었습니다.");
            Application.Exit();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소하였습니다.");
            dataGridView1.Rows.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("햄버거", "7000원");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("크림파스타", "8000원");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("아이스크림", "1500원");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("치킨", "18000원");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("피자", "21000원");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("토마토파스타", "8000원");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("콜라", "1500원");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("치킨소스", "500원");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("감자튀김", "2000원");
        }
    }
}
