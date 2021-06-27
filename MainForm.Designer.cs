namespace My_dream_is_owner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.s_panel = new System.Windows.Forms.Panel();
            this.error_textbox = new System.Windows.Forms.TextBox();
            this.Join_p = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Join_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.pw_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sound_on = new System.Windows.Forms.Button();
            this.sound_off = new System.Windows.Forms.Button();
            this.found_pw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.s_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // s_panel
            // 
            this.s_panel.BackColor = System.Drawing.Color.White;
            this.s_panel.Controls.Add(this.found_pw);
            this.s_panel.Controls.Add(this.button1);
            this.s_panel.Controls.Add(this.login_btn);
            this.s_panel.Controls.Add(this.error_textbox);
            this.s_panel.Controls.Add(this.Join_p);
            this.s_panel.Controls.Add(this.label1);
            this.s_panel.Controls.Add(this.pictureBox2);
            this.s_panel.Controls.Add(this.Join_btn);
            this.s_panel.Controls.Add(this.pw_textBox);
            this.s_panel.Controls.Add(this.id_textBox);
            this.s_panel.Controls.Add(this.label2);
            this.s_panel.Controls.Add(this.label4);
            this.s_panel.Location = new System.Drawing.Point(0, -2);
            this.s_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s_panel.Name = "s_panel";
            this.s_panel.Size = new System.Drawing.Size(301, 908);
            this.s_panel.TabIndex = 54;
            // 
            // error_textbox
            // 
            this.error_textbox.BackColor = System.Drawing.Color.White;
            this.error_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.error_textbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.error_textbox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_textbox.ForeColor = System.Drawing.Color.Brown;
            this.error_textbox.Location = new System.Drawing.Point(55, 376);
            this.error_textbox.Multiline = true;
            this.error_textbox.Name = "error_textbox";
            this.error_textbox.Size = new System.Drawing.Size(196, 58);
            this.error_textbox.TabIndex = 56;
            // 
            // Join_p
            // 
            this.Join_p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Join_p.BackgroundImage")));
            this.Join_p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Join_p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Join_p.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Join_p.FlatAppearance.BorderSize = 0;
            this.Join_p.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Join_p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Join_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Join_p.ForeColor = System.Drawing.Color.Black;
            this.Join_p.Location = new System.Drawing.Point(92, 635);
            this.Join_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Join_p.Name = "Join_p";
            this.Join_p.Size = new System.Drawing.Size(45, 33);
            this.Join_p.TabIndex = 42;
            this.Join_p.UseVisualStyleBackColor = true;
            this.Join_p.Click += new System.EventHandler(this.Join_p_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 41;
            this.label1.Text = "Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(28, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 92);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Join_btn
            // 
            this.Join_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Join_btn.BackColor = System.Drawing.Color.Transparent;
            this.Join_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Join_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Join_btn.FlatAppearance.BorderSize = 0;
            this.Join_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Join_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Join_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Join_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join_btn.ForeColor = System.Drawing.Color.Black;
            this.Join_btn.Location = new System.Drawing.Point(143, 635);
            this.Join_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Join_btn.Name = "Join_btn";
            this.Join_btn.Size = new System.Drawing.Size(63, 33);
            this.Join_btn.TabIndex = 4;
            this.Join_btn.Text = "Join";
            this.Join_btn.UseVisualStyleBackColor = false;
            this.Join_btn.Click += new System.EventHandler(this.Join_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.login_btn.Location = new System.Drawing.Point(55, 455);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(192, 43);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click_1);
            // 
            // pw_textBox
            // 
            this.pw_textBox.Font = new System.Drawing.Font("굴림", 16F);
            this.pw_textBox.Location = new System.Drawing.Point(54, 321);
            this.pw_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_textBox.Name = "pw_textBox";
            this.pw_textBox.Size = new System.Drawing.Size(197, 32);
            this.pw_textBox.TabIndex = 2;
            this.pw_textBox.UseSystemPasswordChar = true;
            // 
            // id_textBox
            // 
            this.id_textBox.Font = new System.Drawing.Font("굴림", 16F);
            this.id_textBox.Location = new System.Drawing.Point(52, 247);
            this.id_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(197, 32);
            this.id_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(52, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "PW";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 770);
            this.panel1.TabIndex = 55;
            // 
            // sound_on
            // 
            this.sound_on.BackColor = System.Drawing.Color.Transparent;
            this.sound_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound_on.BackgroundImage")));
            this.sound_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound_on.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sound_on.FlatAppearance.BorderSize = 0;
            this.sound_on.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sound_on.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sound_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound_on.Location = new System.Drawing.Point(923, 12);
            this.sound_on.Name = "sound_on";
            this.sound_on.Size = new System.Drawing.Size(75, 59);
            this.sound_on.TabIndex = 56;
            this.sound_on.UseVisualStyleBackColor = false;
            this.sound_on.Click += new System.EventHandler(this.sound_on_Click_1);
            // 
            // sound_off
            // 
            this.sound_off.BackColor = System.Drawing.Color.Transparent;
            this.sound_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound_off.BackgroundImage")));
            this.sound_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound_off.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sound_off.FlatAppearance.BorderSize = 0;
            this.sound_off.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sound_off.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sound_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound_off.Location = new System.Drawing.Point(923, 12);
            this.sound_off.Name = "sound_off";
            this.sound_off.Size = new System.Drawing.Size(75, 59);
            this.sound_off.TabIndex = 58;
            this.sound_off.UseVisualStyleBackColor = false;
            this.sound_off.Click += new System.EventHandler(this.sound_off_Click_1);
            // 
            // found_pw
            // 
            this.found_pw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.found_pw.BackColor = System.Drawing.Color.Transparent;
            this.found_pw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.found_pw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.found_pw.FlatAppearance.BorderSize = 0;
            this.found_pw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.found_pw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.found_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.found_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.found_pw.ForeColor = System.Drawing.Color.Black;
            this.found_pw.Location = new System.Drawing.Point(120, 689);
            this.found_pw.Margin = new System.Windows.Forms.Padding(2);
            this.found_pw.Name = "found_pw";
            this.found_pw.Size = new System.Drawing.Size(117, 33);
            this.found_pw.TabIndex = 60;
            this.found_pw.Text = "PW Find";
            this.found_pw.UseVisualStyleBackColor = false;
            this.found_pw.Click += new System.EventHandler(this.found_pw_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(80, 689);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 770);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sound_on);
            this.Controls.Add(this.s_panel);
            this.Controls.Add(this.sound_off);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My dream is owner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainformClosed);
            this.s_panel.ResumeLayout(false);
            this.s_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel s_panel;
        private System.Windows.Forms.Button Join_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Join_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox pw_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox error_textbox;
        private System.Windows.Forms.Button sound_on;
        private System.Windows.Forms.Button sound_off;
        private System.Windows.Forms.Button found_pw;
        private System.Windows.Forms.Button button1;
    }
}
