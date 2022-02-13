namespace My_dream_is_owner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectablePanel = new My_dream_is_owner.SelectablePanel();
            this.SuspendLayout();
            // 
            // selectablePanel
            // 
            this.selectablePanel.BackColor = System.Drawing.SystemColors.Control;
            this.selectablePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectablePanel.BackgroundImage")));
            this.selectablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectablePanel.Location = new System.Drawing.Point(0, 0);
            this.selectablePanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.selectablePanel.Name = "selectablePanel";
            this.selectablePanel.Size = new System.Drawing.Size(1011, 771);
            this.selectablePanel.TabIndex = 0;
            this.selectablePanel.TabStop = true;
            this.selectablePanel.Resize += new System.EventHandler(this.selectablePanel1_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1011, 771);
            this.Controls.Add(this.selectablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SelectablePanel selectablePanel;
    }
}