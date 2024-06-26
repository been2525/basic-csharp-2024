﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRentalShopApp
{
    public partial class FrmMember : MetroForm
    {
        private bool isNew = false; // UPDATE(false), INSERT(true)
        
        public FrmMember()
        {
            InitializeComponent();
        }

        private void FrmLoginUser_Load(object sender, EventArgs e)
        {
            RefreshData(); // bookstbl에서 데이터를 가져오는 부분
            // 콤보박스에 들어가는 데이터를 초기화
            initInputData(); // 콤보박스, 날짜,NumericUpDown 컨트롤 데이터, 초기화
        }

        private void initInputData()
        {
            // divtbl에서 가져오던걸 A~D 텍스트 처리로 변경
            var temp = new Dictionary<string, string>();
            temp.Add("A", "A");
            temp.Add("B", "B");
            temp.Add("C", "C");
            temp.Add("D", "D");

            CboLevels.DataSource = new BindingSource(temp, null);
            CboLevels.DisplayMember = "Value";
            CboLevels.ValueMember = "Key";
            CboLevels.SelectedIndex = -1;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            TxtMemberIdx.Text = TxtNames.Text = string.Empty;
            TxtMemberIdx.Focus(); // 순번은 자동증가하기 때문에 입력불가
            CboLevels.SelectedIndex = -1;
            TxtAddr.Text = TxtEmail.Text = string.Empty;
            RefreshData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var md5Hash = MD5.Create(); //MD5 암호화용 객체 생성

            // 입력검증(Validation Check), 순번, 이름, 패스워드를 안넣으면
            if (string.IsNullOrEmpty(TxtNames.Text))
            {
                MessageBox.Show("회원명을 입력하세요.");
                return;
            }

            // 콤보박스는 SelectedIndex가 -1이 되면 안됨
            if (CboLevels.SelectedIndex < 0)
            {
                MessageBox.Show("등급명을 선택하세요.");
                return;
            }

            if(string.IsNullOrEmpty(TxtAddr.Text))
            {
                MessageBox.Show("주소을 입력하세요.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew) // INSERT이면
                    {
                        query = @"INSERT INTO [dbo].[membertbl]
                                                   ([Names]
                                                   ,[Levels]
                                                   ,[Addr]
                                                   ,[Mobile]
                                                   ,[Email])
                                             VALUES
                                                   (@Names
                                                   ,@Levels
                                                   ,@Addr
                                                   ,@Mobile
                                                   ,@Email)";
                    }
                    else // UPDATE
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                               SET [Names] = @Names
                                                  ,[Levels] = @Levels
                                                  ,[Addr] = @Addr
                                                  ,[Mobile] = @Mobile
                                                  ,[Email] = @Email
                                             WHERE memberIdx = @memberIdx";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    // 복붙후 쿼리가 바뀌면 늘 파라미터는 변경해야함!!
                    SqlParameter prmNames = new SqlParameter("@Names", TxtNames.Text);
                    cmd.Parameters.Add(prmNames);
                    SqlParameter prmLevels = new SqlParameter("@Levels", CboLevels.SelectedValue);
                    cmd.Parameters.Add(prmLevels);
                    SqlParameter prmAddr = new SqlParameter("@Addr", TxtNames.Text);
                    cmd.Parameters.Add(prmAddr);
                    SqlParameter prmMobile = new SqlParameter("@Mobile", TxtMobile.Text);
                    cmd.Parameters.Add(prmMobile);
                    SqlParameter prmEmail = new SqlParameter("@Email", TxtEmail.Text);
                    cmd.Parameters.Add(prmEmail);

                    if (isNew != true)
                    {
                        SqlParameter prmmemberIdx = new SqlParameter("@memberIdx", TxtMemberIdx.Text);
                        cmd.Parameters.Add(prmmemberIdx);
                    }

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메시지박스의 부모창이 누구냐, FrmLoginUser
                        MetroMessageBox.Show(this, "저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장실패!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            TxtMemberIdx.Text  = TxtNames.Text = string.Empty; // 입력, 수정, 삭제 이후에는 모든 입력값을 지워줘야함
            CboLevels.SelectedIndex = -1;
            TxtAddr.Text = TxtEmail.Text = string.Empty;
            RefreshData();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMemberIdx.Text)) // 구분코드가 없으면
            {
                MetroMessageBox.Show(this, "삭제할 회원을 선택하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM membertbl WHERE memberIdx = @memberIdx";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmMemberIDx = new SqlParameter("@memberIdx", TxtMemberIdx.Text);
                cmd.Parameters.Add(prmMemberIDx);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제성공!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroMessageBox.Show(this, "삭제실패!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            TxtMemberIdx.Text = TxtNames.Text = string.Empty; // 입력, 수정, 삭제 이후에는 모든 입력값을 지워줘야함
            CboLevels.SelectedIndex = -1;
            TxtAddr.Text = TxtEmail.Text = string.Empty;
            RefreshData (); // 데이터그리드 재조회
        }

        // 데이터 그리뷰데 데이터 새로부르기
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                var query = @"SELECT [memberIdx]
                                    ,[Names]
                                    ,[Levels]
                                    ,[Addr]
                                    ,[Mobile]
                                    ,[Email]
                                FROM [membertbl]"; // 화면에 필요한 테이블 쿼리 변경
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "memberstbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true; // 수정불가
                // 컬럼이름 변경
                DgvResult.Columns[0].HeaderText = "회원순번";
                DgvResult.Columns[1].HeaderText = "회원명";
                DgvResult.Columns[2].HeaderText = "등급";
                DgvResult.Columns[3].HeaderText = "주소";
                DgvResult.Columns[4].HeaderText = "전화번호";
                DgvResult.Columns[5].HeaderText = "이메일";
                // 컬럼의 넓이 지정
                DgvResult.Columns[0].Width = 80;
                DgvResult.Columns[1].Width = 80;
                DgvResult.Columns[2].Width = 50;
                DgvResult.Columns[4].Width = 100;
                //DgvResult.Columns[5].Width = 73;
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex]; // 내가 선택한 인덱스값
                TxtMemberIdx.Text = selData.Cells[0].Value.ToString(); // 회원순번
                TxtNames.Text = selData.Cells[1].Value.ToString(); // 회원명
                CboLevels.SelectedValue = selData.Cells[2].Value.ToString(); // 구분코드로 선택
                TxtAddr.Text = selData.Cells[3].Value.ToString();
                TxtMobile.Text = selData.Cells[4].Value.ToString();
                TxtEmail.Text = selData.Cells[5].Value.ToString();
                isNew = false; //UPDATE
            }
        }

    }
}
