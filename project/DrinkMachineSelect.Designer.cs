namespace project
{
    partial class DrinkMachineSelect
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
            this.hotbtn = new System.Windows.Forms.Button();
            this.coldbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hotbtn
            // 
            this.hotbtn.Location = new System.Drawing.Point(40, 103);
            this.hotbtn.Name = "hotbtn";
            this.hotbtn.Size = new System.Drawing.Size(168, 95);
            this.hotbtn.TabIndex = 0;
            this.hotbtn.Text = "뜨거운 음료\r\n자판기 생성";
            this.hotbtn.UseVisualStyleBackColor = true;
            this.hotbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // coldbtn
            // 
            this.coldbtn.Location = new System.Drawing.Point(271, 103);
            this.coldbtn.Name = "coldbtn";
            this.coldbtn.Size = new System.Drawing.Size(168, 95);
            this.coldbtn.TabIndex = 1;
            this.coldbtn.Text = "차가운 음료\r\n자판기 생성";
            this.coldbtn.UseVisualStyleBackColor = true;
            this.coldbtn.Click += new System.EventHandler(this.coldbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "생성할 자판기 선택";
            // 
            // DrinkMachineSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coldbtn);
            this.Controls.Add(this.hotbtn);
            this.Name = "DrinkMachineSelect";
            this.Text = "자판기 선택";
            this.Load += new System.EventHandler(this.DrinkMachineSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hotbtn;
        private System.Windows.Forms.Button coldbtn;
        private System.Windows.Forms.Label label1;
    }
}