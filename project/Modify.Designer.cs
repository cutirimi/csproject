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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drinktb
            // 
            this.drinktb.Location = new System.Drawing.Point(28, 72);
            this.drinktb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drinktb.Name = "drinktb";
            this.drinktb.Size = new System.Drawing.Size(245, 25);
            this.drinktb.TabIndex = 0;
            // 
            // drinklist
            // 
            this.drinklist.FormattingEnabled = true;
            this.drinklist.ItemHeight = 15;
            this.drinklist.Location = new System.Drawing.Point(28, 124);
            this.drinklist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drinklist.Name = "drinklist";
            this.drinklist.Size = new System.Drawing.Size(245, 169);
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
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
    }
}