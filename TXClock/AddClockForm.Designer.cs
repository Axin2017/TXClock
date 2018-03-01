namespace TXClock
{
    partial class AddClockForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddClockTime_txt = new System.Windows.Forms.TextBox();
            this.AddClockTipText_txt = new System.Windows.Forms.TextBox();
            this.AddClockSave_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "注释";
            // 
            // AddClockTime_txt
            // 
            this.AddClockTime_txt.Location = new System.Drawing.Point(81, 31);
            this.AddClockTime_txt.Name = "AddClockTime_txt";
            this.AddClockTime_txt.Size = new System.Drawing.Size(100, 21);
            this.AddClockTime_txt.TabIndex = 2;
            // 
            // AddClockTipText_txt
            // 
            this.AddClockTipText_txt.Location = new System.Drawing.Point(81, 71);
            this.AddClockTipText_txt.Name = "AddClockTipText_txt";
            this.AddClockTipText_txt.Size = new System.Drawing.Size(100, 21);
            this.AddClockTipText_txt.TabIndex = 3;
            // 
            // AddClockSave_btn
            // 
            this.AddClockSave_btn.Location = new System.Drawing.Point(106, 121);
            this.AddClockSave_btn.Name = "AddClockSave_btn";
            this.AddClockSave_btn.Size = new System.Drawing.Size(75, 23);
            this.AddClockSave_btn.TabIndex = 4;
            this.AddClockSave_btn.Text = "保存";
            this.AddClockSave_btn.UseVisualStyleBackColor = true;
            this.AddClockSave_btn.Click += new System.EventHandler(this.AddClockSave_btn_Click);
            // 
            // AddClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 164);
            this.Controls.Add(this.AddClockSave_btn);
            this.Controls.Add(this.AddClockTipText_txt);
            this.Controls.Add(this.AddClockTime_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加闹钟";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddClockTime_txt;
        private System.Windows.Forms.TextBox AddClockTipText_txt;
        private System.Windows.Forms.Button AddClockSave_btn;
    }
}