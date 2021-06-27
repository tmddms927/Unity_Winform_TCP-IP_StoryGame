using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace My_dream_is_owner
{
    public partial class JoinForm : Form
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;

        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Mode=ReadWrite;";

        public JoinForm()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            int num = 0;
            String pw_enc = Encryption();
            //if (id_textBox.Text == "" || pw_textBox.Text == "" || name_textBox.Text == "")
            //{
            //    textBox1.Text = "항목을 모두 입력해주세요.";
            //    return;
            //}
            //암호화

            //1.데이터 연결
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }

            string strcom = "SELECT * FROM Member WHERE M_ID='" + id_textBox.Text + "'";

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
                textBox1.Text = "아이디가 이미 존재합니다.";
                return;
            }

            if ((ValidatePassword(pw_textBox.Text)) == false)
                return;


            string sql = "INSERT INTO Member VALUES ('" + id_textBox.Text + "', '" + pw_enc
                                             + "', '" + name_textBox.Text + "', " + num + ",'" + null + "')";

            //comm을 실행
            comm = new OleDbCommand(sql, conn);
            int x = comm.ExecuteNonQuery(); //int값을 리턴

            if (x == 1)
            {
                textBox1.Text = "회원가입을 완료하셨습니다!";
                this.Close();
            }

            conn.Close();
            conn = null;
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //비밀먼호 유효성 검사
        private bool ValidatePassword(string password)
        {
            var input = password;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                textBox1.Text = "하나 이상의 소문자를 포함해야 합니다.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                textBox1.Text = "하나 이상의 대문자를 포함해야 합니다.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                textBox1.Text = "8자 이상이어야 합니다.";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                textBox1.Text = "하나 이상의 숫자 값이 포함되어야 합니다.";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                textBox1.Text = "하나 이상의 특수 문자가 포함되어야 합니다.";
                return false;
            }
            else
            {
                return true;
            }
        }

        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            //get hash result after compute it
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        private String Encryption()
        {
            string pw = pw_textBox.Text;
            Console.WriteLine("수정 전" + pw);
            string pw_md5 = MD5Hash(pw);
            Console.WriteLine("pw_md5 수정 후" + pw_md5);

            return pw_md5;
        }
    }
}
