namespace project
{
    partial class UserAdd
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
            this.nametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.pwcontb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hotdrinkbtn = new System.Windows.Forms.Button();
            this.colddrinkbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(75, 169);
            this.nametb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(350, 25);
            this.nametb.TabIndex = 0;
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(75, 233);
            this.passwordtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(350, 25);
            this.passwordtb.TabIndex = 1;
            // 
            // pwcontb
            // 
            this.pwcontb.Location = new System.Drawing.Point(75, 304);
            this.pwcontb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwcontb.Name = "pwcontb";
            this.pwcontb.PasswordChar = '*';
            this.pwcontb.Size = new System.Drawing.Size(350, 25);
            this.pwcontb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "비밀번호 확인";
            // 
            // uploadbtn
            // 
            this.uploadbtn.BackColor = System.Drawing.Color.Plum;
            this.uploadbtn.Location = new System.Drawing.Point(75, 437);
            this.uploadbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(350, 48);
            this.uploadbtn.TabIndex = 6;
            this.uploadbtn.Text = "등록";
            this.uploadbtn.UseVisualStyleBackColor = false;
            this.uploadbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(75, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "관리자 등록";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "자판기 선택";
            // 
            // hotdrinkbtn
            // 
            this.hotdrinkbtn.Location = new System.Drawing.Point(75, 379);
            this.hotdrinkbtn.Name = "hotdrinkbtn";
            this.hotdrinkbtn.Size = new System.Drawing.Size(165, 25);
            this.hotdrinkbtn.TabIndex = 10;
            this.hotdrinkbtn.Text = "뜨거운 음료";
            this.hotdrinkbtn.UseVisualStyleBackColor = true;
            this.hotdrinkbtn.Click += new System.EventHandler(this.hotdrinkbtn_Click);
            // 
            // colddrinkbtn
            // 
            this.colddrinkbtn.Location = new System.Drawing.Point(260, 379);
            this.colddrinkbtn.Name = "colddrinkbtn";
            this.colddrinkbtn.Size = new System.Drawing.Size(165, 25);
            this.colddrinkbtn.TabIndex = 11;
            this.colddrinkbtn.Text = "차가운 음료";
            this.colddrinkbtn.UseVisualStyleBackColor = true;
            this.colddrinkbtn.Click += new System.EventHandler(this.colddrinkbtn_Click);
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(482, 552);
            this.Controls.Add(this.colddrinkbtn);
            this.Controls.Add(this.hotdrinkbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwcontb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.nametb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserAdd";
            this.Text = "관리자등록";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox pwcontb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button hotdrinkbtn;
        private System.Windows.Forms.Button colddrinkbtn;
    }
}