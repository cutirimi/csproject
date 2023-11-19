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
            this.itemtb = new System.Windows.Forms.TextBox();
            this.drinklist = new System.Windows.Forms.ListBox();
            this.adderbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cnttb = new System.Windows.Forms.TextBox();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemtb
            // 
            this.itemtb.Location = new System.Drawing.Point(103, 72);
            this.itemtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemtb.Name = "itemtb";
            this.itemtb.Size = new System.Drawing.Size(170, 25);
            this.itemtb.TabIndex = 0;
            // 
            // drinklist
            // 
            this.drinklist.FormattingEnabled = true;
            this.drinklist.ItemHeight = 15;
            this.drinklist.Location = new System.Drawing.Point(28, 203);
            this.drinklist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drinklist.Name = "drinklist";
            this.drinklist.Size = new System.Drawing.Size(245, 124);
            this.drinklist.TabIndex = 1;
            // 
            // adderbtn
            // 
            this.adderbtn.BackColor = System.Drawing.SystemColors.Window;
            this.adderbtn.Location = new System.Drawing.Point(310, 124);
            this.adderbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adderbtn.Name = "adderbtn";
            this.adderbtn.Size = new System.Drawing.Size(130, 50);
            this.adderbtn.TabIndex = 2;
            this.adderbtn.Text = "추가";
            this.adderbtn.UseVisualStyleBackColor = false;
            this.adderbtn.Click += new System.EventHandler(this.adderbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.Window;
            this.deletebtn.Location = new System.Drawing.Point(310, 208);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(130, 50);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "삭제";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "음료 추가 및 삭제";
            // 
            // cnttb
            // 
            this.cnttb.Location = new System.Drawing.Point(103, 152);
            this.cnttb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnttb.Name = "cnttb";
            this.cnttb.Size = new System.Drawing.Size(170, 25);
            this.cnttb.TabIndex = 10;
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(103, 112);
            this.pricetb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(170, 25);
            this.pricetb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "음료명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "수량";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(482, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnttb);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.adderbtn);
            this.Controls.Add(this.drinklist);
            this.Controls.Add(this.itemtb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Modify";
            this.Text = "자판기 수정";
            this.Load += new System.EventHandler(this.Modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemtb;
        private System.Windows.Forms.ListBox drinklist;
        private System.Windows.Forms.Button adderbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cnttb;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}