namespace project
{
    partial class Modify
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
            this.drinktb = new System.Windows.Forms.TextBox();
            this.drinklist = new System.Windows.Forms.ListBox();
            this.adderbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.coldbtn = new System.Windows.Forms.Button();
            this.hotbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drinktb
            // 
            this.drinktb.Location = new System.Drawing.Point(60, 201);
            this.drinktb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drinktb.Name = "drinktb";
            this.drinktb.Size = new System.Drawing.Size(245, 25);
            this.drinktb.TabIndex = 0;
            // 
            // drinklist
            // 
            this.drinklist.FormattingEnabled = true;
            this.drinklist.ItemHeight = 15;
            this.drinklist.Location = new System.Drawing.Point(60, 253);
            this.drinklist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drinklist.Name = "drinklist";
            this.drinklist.Size = new System.Drawing.Size(245, 169);
            this.drinklist.TabIndex = 1;
            // 
            // adderbtn
            // 
            this.adderbtn.BackColor = System.Drawing.SystemColors.Window;
            this.adderbtn.Location = new System.Drawing.Point(390, 253);
            this.adderbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adderbtn.Name = "adderbtn";
            this.adderbtn.Size = new System.Drawing.Size(150, 60);
            this.adderbtn.TabIndex = 2;
            this.adderbtn.Text = "추가";
            this.adderbtn.UseVisualStyleBackColor = false;
            this.adderbtn.Click += new System.EventHandler(this.adderbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.Window;
            this.deletebtn.Location = new System.Drawing.Point(390, 362);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(150, 60);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "삭제";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // coldbtn
            // 
            this.coldbtn.Location = new System.Drawing.Point(60, 57);
            this.coldbtn.Name = "coldbtn";
            this.coldbtn.Size = new System.Drawing.Size(115, 53);
            this.coldbtn.TabIndex = 4;
            this.coldbtn.Text = "차가운 음료\r\n자판기 생성";
            this.coldbtn.UseVisualStyleBackColor = true;
            this.coldbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // hotbtn
            // 
            this.hotbtn.Location = new System.Drawing.Point(192, 57);
            this.hotbtn.Name = "hotbtn";
            this.hotbtn.Size = new System.Drawing.Size(115, 53);
            this.hotbtn.TabIndex = 5;
            this.hotbtn.Text = "뜨거운 음료\r\n자판기 생성";
            this.hotbtn.UseVisualStyleBackColor = true;
            this.hotbtn.Click += new System.EventHandler(this.hotbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(60, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "자판기 선택";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(60, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "음료 추가 및 삭제";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotbtn);
            this.Controls.Add(this.coldbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.adderbtn);
            this.Controls.Add(this.drinklist);
            this.Controls.Add(this.drinktb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Modify";
            this.Text = "자판기 수정";
            this.Load += new System.EventHandler(this.Modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox drinktb;
        private System.Windows.Forms.ListBox drinklist;
        private System.Windows.Forms.Button adderbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button coldbtn;
        private System.Windows.Forms.Button hotbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}