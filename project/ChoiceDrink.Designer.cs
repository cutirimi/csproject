namespace project
{
    partial class ChoiceDrink
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
            this.adddrink = new System.Windows.Forms.TextBox();
            this.drinklist = new System.Windows.Forms.ListBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adddrink
            // 
            this.adddrink.Location = new System.Drawing.Point(40, 44);
            this.adddrink.Name = "adddrink";
            this.adddrink.Size = new System.Drawing.Size(211, 25);
            this.adddrink.TabIndex = 0;
            // 
            // drinklist
            // 
            this.drinklist.FormattingEnabled = true;
            this.drinklist.ItemHeight = 15;
            this.drinklist.Location = new System.Drawing.Point(40, 89);
            this.drinklist.Name = "drinklist";
            this.drinklist.Size = new System.Drawing.Size(211, 139);
            this.drinklist.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(321, 44);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(122, 44);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "추가";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(321, 111);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(122, 44);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "삭제";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // ChoiceDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.drinklist);
            this.Controls.Add(this.adddrink);
            this.Name = "ChoiceDrink";
            this.Text = "자판기 음료수 품목 선택";
            this.Load += new System.EventHandler(this.ChoiceDrink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adddrink;
        private System.Windows.Forms.ListBox drinklist;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}