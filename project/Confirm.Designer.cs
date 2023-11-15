namespace project
{
    partial class Confirm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adddrink = new System.Windows.Forms.TextBox();
            this.drinklist = new System.Windows.Forms.ListView();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 98);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 131);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "품목명";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "가격";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "재고수량";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "상태";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(138, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "님 페이지";
            // 
            // adddrink
            // 
            this.adddrink.Location = new System.Drawing.Point(38, 265);
            this.adddrink.Name = "adddrink";
            this.adddrink.Size = new System.Drawing.Size(192, 21);
            this.adddrink.TabIndex = 6;
            // 
            // drinklist
            // 
            this.drinklist.HideSelection = false;
            this.drinklist.Location = new System.Drawing.Point(38, 308);
            this.drinklist.Name = "drinklist";
            this.drinklist.Size = new System.Drawing.Size(191, 77);
            this.drinklist.TabIndex = 7;
            this.drinklist.UseCompatibleStateImageBehavior = false;
            this.drinklist.View = System.Windows.Forms.View.Details;
            this.drinklist.SelectedIndexChanged += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(286, 265);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(102, 50);
            this.addbtn.TabIndex = 8;
            this.addbtn.Text = "추가";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(286, 335);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(102, 50);
            this.deletebtn.TabIndex = 9;
            this.deletebtn.Text = "삭제";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(422, 442);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.drinklist);
            this.Controls.Add(this.adddrink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adddrink;
        private System.Windows.Forms.ListView drinklist;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}