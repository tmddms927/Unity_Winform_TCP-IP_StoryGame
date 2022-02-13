using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_dream_is_owner
{
    public partial class StageForm : Form
    {
        public static int data;
        public string ending_data;
        private string game;
        private MainForm mainForm;

        public StageForm()
        {
            InitializeComponent();
        }

        public StageForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public int stage(string loginId, string loginpw)
        {
            int stage = MainForm.stagedata(loginId, loginpw);
            return stage;
        }

        public void pictureboxopen(int stage)
        {
            int i, j, t;
            PictureBox pb = new PictureBox();
            PictureBox[] pictureBoxes = { pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            if (stage > 5)
            {
                for (t = 0; t <= 3; t++)
                {
                    pb = pictureBoxes[t];
                    pb.Hide();
                }
            }
            for (i = 2; i <= 5; i++)
            {
                for (j = 0; j <= i - 2; j++)
                {
                    if (stage == i)
                    {
                        pb = pictureBoxes[j];
                        pb.Hide();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = 1;
            Form1 fm = new Form1(this);
            fm.TopLevel = false;
            this.Controls.Add(fm);
            fm.Parent = this.panel1;
            panel1.Visible = true;
            game = "stage1.exe";
            fm.value1 = game;
            fm.sss();
            fm.Show();
            button_re();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data = 2;
            Form1 fm = new Form1(this);
            fm.TopLevel = false;
            this.Controls.Add(fm);
            fm.Parent = this.panel1;
            panel1.Visible = true;
            game = "stage2.exe";
            fm.value1 = game;
            fm.sss();
            fm.Show();
            button_re();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data = 3;
            Form1 fm = new Form1(this);
            fm.TopLevel = false;
            this.Controls.Add(fm);
            fm.Parent = this.panel1;
            panel1.Visible = true;
            game = "stage3.exe";
            fm.value1 = game;
            fm.sss();
            fm.Show();
            button_re();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.click_stage = 4;
            data = 4;
            Form1 fm = new Form1(this);
            fm.TopLevel = false;
            this.Controls.Add(fm);
            fm.Parent = this.panel1;
            panel1.Visible = true;
            game = "stage4.exe";
            fm.value1 = game;
            fm.sss();
            fm.Show();
            button_re();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("satageForm:" + r_data());
            ending_data = r_data();
            data = 5;
            //Form1.click_stage = 5;
            if ((String.Compare("cl", ending_data) == 0))
            {
                Form1 fm = new Form1(this);
                fm.TopLevel = false;
                this.Controls.Add(fm);
                fm.Parent = this.panel1;
                panel1.Visible = true;
                game = "stage5_h.exe";
                fm.value1 = game;
                fm.sss();
                fm.Show();
            }
            else if ((String.Compare("c2", ending_data) == 0))
            {
                Form1 fm = new Form1(this);
                fm.TopLevel = false;
                this.Controls.Add(fm);
                fm.Parent = this.panel1;
                panel1.Visible = true;
                game = "stage5_e.exe";
                fm.value1 = game;
                fm.sss();
                fm.Show();
            }
            button_re();
        }

        private void StageForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            int stagedata = stage(MainForm.loginId, MainForm.loginpw);
            if (stagedata == 0)
            {
                Form1.stage_data = 2;
                Form1 fm = new Form1(this);
                fm.TopLevel = false;
                this.Controls.Add(fm);
                fm.Parent = this.panel1;
                game = "tutorial.exe";
                fm.value1 = game;
                fm.sss();
                panel1.Visible = true;
                fm.Show();
                button_re();
            }
            pictureboxopen(stagedata);
        }

        public void Closemainform()
        {
            panel1.Visible = false;
            int stagedata = stage(MainForm.loginId, MainForm.loginpw);
            pictureboxopen(stagedata);
            button_re2();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            mainForm.Closemainform();
            this.Close();
        }

        //4스테이지 엔딩 반환
        private String r_data()
        {
            return MainForm.return_value(MainForm.loginId, MainForm.loginpw);
        }

        public void button_re()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            logout_btn.Enabled = false;
        }
        public void button_re2()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            logout_btn.Enabled = true;
        }
    }
}