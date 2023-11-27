namespace project
{
    partial class MachineSelect
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
            this.coldMachinecb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hotMachinecb = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // coldMachinecb
            // 
            this.coldMachinecb.FormattingEnabled = true;
            this.coldMachinecb.Location = new System.Drawing.Point(208, 126);
            this.coldMachinecb.Name = "coldMachinecb";
            this.coldMachinecb.Size = new System.Drawing.Size(121, 20);
            this.coldMachinecb.TabIndex = 0;
            this.coldMachinecb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "이용할 자판기를 선택해주세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "차가운 음료 자판기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "뜨거운 음료 자판기";
            // 
            // hotMachinecb
            // 
            this.hotMachinecb.FormattingEnabled = true;
            this.hotMachinecb.Location = new System.Drawing.Point(218, 187);
            this.hotMachinecb.Name = "hotMachinecb";
            this.hotMachinecb.Size = new System.Drawing.Size(121, 20);
            this.hotMachinecb.TabIndex = 6;
            this.hotMachinecb.SelectedIndexChanged += new System.EventHandler(this.hotMachinecb_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Lavender;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "dd",
            "dda",
            "\\wer",
            "dzcv",
            "ee"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 442);
            this.listBox1.TabIndex = 8;
            // 
            // MachineSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(422, 442);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hotMachinecb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coldMachinecb);
            this.Name = "MachineSelect";
            this.Text = "자판기 선택";
            this.Load += new System.EventHandler(this.MachineSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coldMachinecb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hotMachinecb;
        private System.Windows.Forms.ListBox listBox1;
    }
}