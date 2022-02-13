using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_dream_is_owner
{
    public partial class Found_Password : Form
    {
        public Found_Password()
        {
            InitializeComponent();
        }

        private void find_Click_1(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            String id = id_textBox.Text;
            String name = name_textBox.Text;
            String data = mf.found_psw(id, name);

            if ((String.Compare("", id) == 0) || (String.Compare("", name) == 0)) error_textBox.Text = "항목을 모두 입력해주세요.";
            if ((String.Compare("none", data) == 0) || (String.Compare("n_same", data) == 0))
                error_textBox.Text = "아이디 또는 이름이 없습니다.";
            else
            {
                if (ValidatePassword(reset_Box.Text) == true)
                {
                    mf.found_reset(id, name, reset_Box.Text);
                    MessageBox.Show("비밀번호가 변경되었습니다.");
                    this.Close();
                }
            }
        }
        
        //유효성 검사
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
                error_textBox.Text = "하나 이상의 소문자를 포함해야 합니다.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                error_textBox.Text = "하나 이상의 대문자를 포함해야 합니다.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                error_textBox.Text = "8자 이상이어야 합니다.";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                error_textBox.Text = "하나 이상의 숫자 값이 포함되어야 합니다.";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                error_textBox.Text = "하나 이상의 특수 문자가 포함되어야 합니다.";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}