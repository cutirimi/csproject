namespace project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.자판기1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.자판기2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자명단ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자판기1ToolStripMenuItem,
            this.로그인ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 자판기1ToolStripMenuItem
            // 
            this.자판기1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.자판기2ToolStripMenuItem1});
            this.자판기1ToolStripMenuItem.Name = "자판기1ToolStripMenuItem";
            this.자판기1ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.자판기1ToolStripMenuItem.Text = "자판기";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.ToolStripMenuItem1.Text = "자판기1";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.자판기1ToolStripMenuItem1_Click);
            // 
            // 자판기2ToolStripMenuItem1
            // 
            this.자판기2ToolStripMenuItem1.Name = "자판기2ToolStripMenuItem1";
            this.자판기2ToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.자판기2ToolStripMenuItem1.Text = "자판기2";
            this.자판기2ToolStripMenuItem1.Click += new System.EventHandler(this.자판기2ToolStripMenuItem1_Click);
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자명단ToolStripMenuItem});
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // 관리자명단ToolStripMenuItem
            // 
            this.관리자명단ToolStripMenuItem.Name = "관리자명단ToolStripMenuItem";
            this.관리자명단ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.관리자명단ToolStripMenuItem.Text = "관리자명단";
            this.관리자명단ToolStripMenuItem.Click += new System.EventHandler(this.확인ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("굴림", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "음료 자판기 프로그램";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 150);
            this.label2.TabIndex = 21;
            this.label2.Text = "자판기를 관리할 수 있도록 제작된 프로그램입니다.\r\n\r\n\r\n>> 주요 기능\r\n\r\n1. 가상 자판기\r\n\r\n2. 로그인 및 사용자 등록\r\n\r\n3. 품" +
    "목과 누적액 확인";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "컴퓨터공학과 20222967학번 정예림";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(422, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "자판기 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 자판기1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 자판기2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리자명단ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}