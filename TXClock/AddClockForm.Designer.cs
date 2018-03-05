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
            this.AddClockTipText_txt = new System.Windows.Forms.TextBox();
            this.AddClockSave_btn = new System.Windows.Forms.Button();
            this.cbo_hour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_minute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
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
            // AddClockTipText_txt
            // 
            this.AddClockTipText_txt.Location = new System.Drawing.Point(72, 71);
            this.AddClockTipText_txt.Name = "AddClockTipText_txt";
            this.AddClockTipText_txt.Size = new System.Drawing.Size(109, 21);
            this.AddClockTipText_txt.TabIndex = 3;
            // 
            // AddClockSave_btn
            // 
            this.AddClockSave_btn.Location = new System.Drawing.Point(106, 115);
            this.AddClockSave_btn.Name = "AddClockSave_btn";
            this.AddClockSave_btn.Size = new System.Drawing.Size(75, 23);
            this.AddClockSave_btn.TabIndex = 4;
            this.AddClockSave_btn.Text = "保存";
            this.AddClockSave_btn.UseVisualStyleBackColor = true;
            this.AddClockSave_btn.Click += new System.EventHandler(this.AddClockSave_btn_Click);
            // 
            // cbo_hour
            // 
            this.cbo_hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_hour.FormattingEnabled = true;
            this.cbo_hour.Location = new System.Drawing.Point(73, 29);
            this.cbo_hour.Name = "cbo_hour";
            this.cbo_hour.Size = new System.Drawing.Size(37, 20);
            this.cbo_hour.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "时";
            // 
            // cbo_minute
            // 
            this.cbo_minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_minute.FormattingEnabled = true;
            this.cbo_minute.Location = new System.Drawing.Point(132, 29);
            this.cbo_minute.Name = "cbo_minute";
            this.cbo_minute.Size = new System.Drawing.Size(37, 20);
            this.cbo_minute.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "分";
            // 
            // AddClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 161);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_minute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_hour);
            this.Controls.Add(this.AddClockSave_btn);
            this.Controls.Add(this.AddClockTipText_txt);
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
        private System.Windows.Forms.TextBox AddClockTipText_txt;
        private System.Windows.Forms.Button AddClockSave_btn;
        private System.Windows.Forms.ComboBox cbo_hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_minute;
        private System.Windows.Forms.Label label4;
    }
}