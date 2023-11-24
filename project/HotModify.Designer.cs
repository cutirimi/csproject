namespace project
{
    partial class HotModify
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
            this.machinenametb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stocktb = new System.Windows.Forms.TextBox();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.adderbtn = new System.Windows.Forms.Button();
            this.itemtb = new System.Windows.Forms.TextBox();
            this.movebtn = new System.Windows.Forms.Button();
            this.drinklist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // machinenametb
            // 
            this.machinenametb.AutoSize = true;
            this.machinenametb.Location = new System.Drawing.Point(193, 25);
            this.machinenametb.Name = "machinenametb";
            this.machinenametb.Size = new System.Drawing.Size(109, 12);
            this.machinenametb.TabIndex = 25;
            this.machinenametb.Text = "뜨거운 음료 자판기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "수량";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "가격";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "음료명";
            // 
            // stocktb
            // 
            this.stocktb.Location = new System.Drawing.Point(96, 121);
            this.stocktb.Name = "stocktb";
            this.stocktb.Size = new System.Drawing.Size(149, 21);
            this.stocktb.TabIndex = 21;
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(96, 89);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(149, 21);
            this.pricetb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(31, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "음료 추가 및 삭제";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.Window;
            this.deletebtn.Location = new System.Drawing.Point(277, 109);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(114, 32);
            this.deletebtn.TabIndex = 18;
            this.deletebtn.Text = "삭제";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // adderbtn
            // 
            this.adderbtn.BackColor = System.Drawing.SystemColors.Window;
            this.adderbtn.Location = new System.Drawing.Point(277, 57);
            this.adderbtn.Name = "adderbtn";
            this.adderbtn.Size = new System.Drawing.Size(114, 32);
            this.adderbtn.TabIndex = 17;
            this.adderbtn.Text = "추가";
            this.adderbtn.UseVisualStyleBackColor = false;
            this.adderbtn.Click += new System.EventHandler(this.adderbtn_Click);
            // 
            // itemtb
            // 
            this.itemtb.Location = new System.Drawing.Point(96, 57);
            this.itemtb.Name = "itemtb";
            this.itemtb.Size = new System.Drawing.Size(149, 21);
            this.itemtb.TabIndex = 15;
            // 
            // movebtn
            // 
            this.movebtn.BackColor = System.Drawing.SystemColors.Window;
            this.movebtn.Location = new System.Drawing.Point(277, 229);
            this.movebtn.Name = "movebtn";
            this.movebtn.Size = new System.Drawing.Size(114, 32);
            this.movebtn.TabIndex = 26;
            this.movebtn.Text = "내 페이지";
            this.movebtn.UseVisualStyleBackColor = false;
            this.movebtn.Click += new System.EventHandler(this.movebtn_Click);
            // 
            // drinklist
            // 
            this.drinklist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.drinklist.GridLines = true;
            this.drinklist.HideSelection = false;
            this.drinklist.Location = new System.Drawing.Point(34, 163);
            this.drinklist.Name = "drinklist";
            this.drinklist.Size = new System.Drawing.Size(211, 98);
            this.drinklist.TabIndex = 27;
            this.drinklist.UseCompatibleStateImageBehavior = false;
            this.drinklist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "음료명";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "가격";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "수량";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HotModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(422, 282);
            this.Controls.Add(this.drinklist);
            this.Controls.Add(this.movebtn);
            this.Controls.Add(this.machinenametb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stocktb);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.adderbtn);
            this.Controls.Add(this.itemtb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HotModify";
            this.Text = "HotModify";
            this.Load += new System.EventHandler(this.HotModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label machinenametb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stocktb;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button adderbtn;
        private System.Windows.Forms.TextBox itemtb;
        private System.Windows.Forms.Button movebtn;
        private System.Windows.Forms.ListView drinklist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}