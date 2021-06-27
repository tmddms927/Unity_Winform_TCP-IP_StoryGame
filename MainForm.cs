using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Media;
using System.Security.Cryptography;
using System.Diagnostics;

namespace My_dream_is_owner
{
    public partial class MainForm : Form
    {
        private SoundPlayer audio = new SoundPlayer(My_dream_is_owner.Properties.Resources.bgm);

        static OleDbConnection conn = null;
        static OleDbCommand comm = null;
        static OleDbDataReader reader = null;
        static string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Mode=ReadWrite;";
        public static string loginId;
        public static string loginpw;
        private Process process;

        public int value { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void Join_btn_Click(object sender, EventArgs e)
        {
            JoinForm frm = new JoinForm();
            frm.ShowDialog();
        }
        private void found_pw_Click_1(object sender, EventArgs e)
        {
            Found_Password fdp = new Found_Password();
            fdp.ShowDialog();
        }

        //로그인
        private void login_btn_Click_1(object sender, EventArgs e)
        {
            loginId = id_textBox.Text;
            String pw = pw_textBox.Text;
            loginpw = MD5Hash(pw);

            string strcom = "SELECT * FROM Member WHERE M_ID='" + loginId
                            + "' and  M_PW='" + loginpw + "'";

            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }

            //comm을 실행
            comm = new OleDbCommand(strcom, conn);
            comm.ExecuteNonQuery(); //int값을 리턴

            reader = comm.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                StageForm sf = new StageForm(this);
                sf.TopLevel = false;
                this.Controls.Add(sf);
                sf.Parent = this.panel1;
                panel1.Visible = true;
                sf.Show();
            }
            else if (count > 1)
                error_textbox.Text = "아이디 또는 비밀번호가 맞지 않습니다.";
            else
                error_textbox.Text = "아이디와 비밀번호가 맞지 않습니다.";

        }
        //스테이지 + 1 디비 저장
        public static void stageupdate(String id, String pw)
        {
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
            string sql = "UPDATE Member SET Stage = Stage + 1 WHERE M_ID='" + id
                        + "' and  M_PW='" + pw + "'";

            comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();

            conn.Close();
            conn = null;
        }
        //스테이지 불러오기
        public static int stagedata(String id, String pw)
        {
            int x = 0;

            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
            string sql = "SELECT Stage FROM Member WHERE M_ID='" + id
                        + "' and  M_PW='" + pw + "'";

            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                x = Convert.ToInt32(reader["Stage"] + "");
            }
            reader.Close(); //닫음
            conn.Close();
            conn = null;

            return x;
        }
        //게임 클리어 확인 함수
        internal void gameclear(int data)
        {
            int num = 0;

            num = stagedata(loginId, loginpw);

            if (num == data)
            {
                if (num < 6)
                {
                    stageupdate(loginId, loginpw);
                }
            }
            Console.WriteLine(num);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            playaudio();
            panel1.Visible = false;
        }
        private void Join_p_Click(object sender, EventArgs e)
        {
            JoinForm frm = new JoinForm();
            frm.ShowDialog();
        }

        //사운드
        private void playaudio()
        {
            audio.PlayLooping();
        }
        private void sound_on_Click_1(object sender, EventArgs e)
        {
            audio.Stop();
            sound_on.Visible = false;
            sound_off.Visible = true;
        }
        private void sound_off_Click_1(object sender, EventArgs e)
        {
            audio.PlayLooping();
            sound_on.Visible = true;
            sound_off.Visible = false;
        }

        //4스테이지 통신값 db 저장
        public static void insert_ending(String id, String pw, String end)
        {
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
            string sql = "UPDATE Member SET Ending = '" + end + "' WHERE M_ID='" + id
                        + "' and  M_PW='" + pw + "'";

            comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();

            conn.Close();
            conn = null;
        }
        //4스테이지 통신값 반환
        public static String return_value(String id, String pw)
        {
            String end_data = null;
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
            string sql = "SELECT Ending FROM Member WHERE M_ID='" + id
                        + "' and  M_PW='" + pw + "'";

            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                end_data = reader["Ending"] + "";
            }
            reader.Close(); //닫음
            conn.Close();
            conn = null;

            return end_data;
        }
        //암호화
        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public String found_psw(String id, String name)
        {
            string user_name = null;
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
            string sql = "SELECT M_PW FROM Member WHERE M_ID='" + id
                        + "' and  Name='" + name + "'";

            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }
            if (count == 1)
                reader.Close(); //닫음
            conn.Close();
            conn = null;

            if (count == 1)
                return user_name;
            else if (count > 1)
                return "none";
            else
                return "n_same";
        }

        //부모 폼 제어
        public void Closemainform()
        {
            panel1.Visible = false;
            id_textBox.Text = "";
            pw_textBox.Text = "";
        }

        public void found_reset(String id, String name, String reset_pw)
        {
            String r_data = MD5Hash(reset_pw);
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
            string sql = "UPDATE Member SET M_PW='" + r_data + "' WHERE M_ID='" + id
                        + "' and  Name='" + name + "'";

            comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();

            conn.Close();
            conn = null;
        }

        private void MainformClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                process.CloseMainWindow();
                Thread.Sleep(1000);
                while (process.HasExited == false)
                    process.Kill();
            }
            catch (Exception)
            {
            }
        }
    }
}