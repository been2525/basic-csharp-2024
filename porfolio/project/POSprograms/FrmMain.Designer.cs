namespace POSprograms
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnPay = new MetroFramework.Controls.MetroButton();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LbPrice3 = new System.Windows.Forms.Label();
            this.LbPrice4 = new System.Windows.Forms.Label();
            this.LbPrice8 = new System.Windows.Forms.Label();
            this.LbPrice9 = new System.Windows.Forms.Label();
            this.LbPrice7 = new System.Windows.Forms.Label();
            this.LbPrice5 = new System.Windows.Forms.Label();
            this.LbPrice6 = new System.Windows.Forms.Label();
            this.LbPrice2 = new System.Windows.Forms.Label();
            this.LbPrice1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LbOrder = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPay
            // 
            this.BtnPay.Location = new System.Drawing.Point(3, 309);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(143, 55);
            this.BtnPay.TabIndex = 0;
            this.BtnPay.Text = "결제";
            this.BtnPay.UseSelectable = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(148, 309);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 55);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(20, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice3);
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice4);
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice8);
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice9);
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice7);
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice5);
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice6);
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice2);
            this.splitContainer1.Panel1.Controls.Add(this.LbPrice1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox5);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox9);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox6);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox8);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox7);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.LbOrder);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.BtnPay);
            this.splitContainer1.Size = new System.Drawing.Size(760, 371);
            this.splitContainer1.SplitterDistance = 530;
            this.splitContainer1.TabIndex = 0;
            // 
            // LbPrice3
            // 
            this.LbPrice3.AutoSize = true;
            this.LbPrice3.Location = new System.Drawing.Point(410, 102);
            this.LbPrice3.Name = "LbPrice3";
            this.LbPrice3.Size = new System.Drawing.Size(41, 12);
            this.LbPrice3.TabIndex = 1;
            this.LbPrice3.Text = "1500원";
            // 
            // LbPrice4
            // 
            this.LbPrice4.AutoSize = true;
            this.LbPrice4.Location = new System.Drawing.Point(65, 227);
            this.LbPrice4.Name = "LbPrice4";
            this.LbPrice4.Size = new System.Drawing.Size(47, 12);
            this.LbPrice4.TabIndex = 1;
            this.LbPrice4.Text = "18000원";
            // 
            // LbPrice8
            // 
            this.LbPrice8.AutoSize = true;
            this.LbPrice8.Location = new System.Drawing.Point(244, 345);
            this.LbPrice8.Name = "LbPrice8";
            this.LbPrice8.Size = new System.Drawing.Size(35, 12);
            this.LbPrice8.TabIndex = 1;
            this.LbPrice8.Text = "500원";
            // 
            // LbPrice9
            // 
            this.LbPrice9.AutoSize = true;
            this.LbPrice9.Location = new System.Drawing.Point(410, 345);
            this.LbPrice9.Name = "LbPrice9";
            this.LbPrice9.Size = new System.Drawing.Size(41, 12);
            this.LbPrice9.TabIndex = 1;
            this.LbPrice9.Text = "2000원";
            // 
            // LbPrice7
            // 
            this.LbPrice7.AutoSize = true;
            this.LbPrice7.Location = new System.Drawing.Point(65, 347);
            this.LbPrice7.Name = "LbPrice7";
            this.LbPrice7.Size = new System.Drawing.Size(41, 12);
            this.LbPrice7.TabIndex = 1;
            this.LbPrice7.Text = "1500원";
            // 
            // LbPrice5
            // 
            this.LbPrice5.AutoSize = true;
            this.LbPrice5.Location = new System.Drawing.Point(239, 227);
            this.LbPrice5.Name = "LbPrice5";
            this.LbPrice5.Size = new System.Drawing.Size(47, 12);
            this.LbPrice5.TabIndex = 1;
            this.LbPrice5.Text = "21000원";
            // 
            // LbPrice6
            // 
            this.LbPrice6.AutoSize = true;
            this.LbPrice6.Location = new System.Drawing.Point(410, 227);
            this.LbPrice6.Name = "LbPrice6";
            this.LbPrice6.Size = new System.Drawing.Size(41, 12);
            this.LbPrice6.TabIndex = 1;
            this.LbPrice6.Text = "8000원";
            // 
            // LbPrice2
            // 
            this.LbPrice2.AutoSize = true;
            this.LbPrice2.Location = new System.Drawing.Point(239, 102);
            this.LbPrice2.Name = "LbPrice2";
            this.LbPrice2.Size = new System.Drawing.Size(41, 12);
            this.LbPrice2.TabIndex = 1;
            this.LbPrice2.Text = "8000원";
            // 
            // LbPrice1
            // 
            this.LbPrice1.AutoSize = true;
            this.LbPrice1.Location = new System.Drawing.Point(65, 102);
            this.LbPrice1.Name = "LbPrice1";
            this.LbPrice1.Size = new System.Drawing.Size(41, 12);
            this.LbPrice1.TabIndex = 1;
            this.LbPrice1.Text = "7000원";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::POSprograms.Properties.Resources.pasta;
            this.pictureBox5.Location = new System.Drawing.Point(365, 132);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(137, 86);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::POSprograms.Properties.Resources.fried;
            this.pictureBox9.Location = new System.Drawing.Point(365, 249);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(137, 87);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POSprograms.Properties.Resources.icecream;
            this.pictureBox3.Location = new System.Drawing.Point(365, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 83);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::POSprograms.Properties.Resources.chicken;
            this.pictureBox4.Location = new System.Drawing.Point(25, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 86);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::POSprograms.Properties.Resources.pizza;
            this.pictureBox6.Location = new System.Drawing.Point(197, 132);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(134, 86);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::POSprograms.Properties.Resources.source;
            this.pictureBox8.Location = new System.Drawing.Point(197, 249);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(131, 87);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POSprograms.Properties.Resources.pasta2;
            this.pictureBox2.Location = new System.Drawing.Point(197, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 83);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::POSprograms.Properties.Resources.juice1;
            this.pictureBox7.Location = new System.Drawing.Point(25, 249);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(127, 87);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSprograms.Properties.Resources.hamburger2;
            this.pictureBox1.Location = new System.Drawing.Point(25, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(5, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(217, 256);
            this.dataGridView1.TabIndex = 4;
            // 
            // LbOrder
            // 
            this.LbOrder.AutoSize = true;
            this.LbOrder.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbOrder.Location = new System.Drawing.Point(10, 9);
            this.LbOrder.Name = "LbOrder";
            this.LbOrder.Size = new System.Drawing.Size(60, 21);
            this.LbOrder.TabIndex = 3;
            this.LbOrder.Text = "Order";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "음식";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "가격";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "개수";
            this.Column3.Name = "Column3";
            this.Column3.Width = 40;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Restaurant management";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnPay;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbPrice3;
        private System.Windows.Forms.Label LbPrice4;
        private System.Windows.Forms.Label LbPrice8;
        private System.Windows.Forms.Label LbPrice9;
        private System.Windows.Forms.Label LbPrice7;
        private System.Windows.Forms.Label LbPrice5;
        private System.Windows.Forms.Label LbPrice6;
        private System.Windows.Forms.Label LbPrice2;
        private System.Windows.Forms.Label LbPrice1;
        private System.Windows.Forms.Label LbOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
    }
}

