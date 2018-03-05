namespace TXClock
{
    partial class CountClockAddForm
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
            this.txt_tag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_hour = new System.Windows.Forms.ComboBox();
            this.cbo_minute = new System.Windows.Forms.ComboBox();
            this.cbo_second = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标签";
            // 
            // txt_tag
            // 
            this.txt_tag.Location = new System.Drawing.Point(101, 34);
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Size = new System.Drawing.Size(147, 21);
            this.txt_tag.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "时长";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(166, 158);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(101, 119);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(147, 21);
            this.txt_note.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "注释";
            // 
            // cbo_hour
            // 
            this.cbo_hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_hour.FormattingEnabled = true;
            this.cbo_hour.Location = new System.Drawing.Point(95, 78);
            this.cbo_hour.Name = "cbo_hour";
            this.cbo_hour.Size = new System.Drawing.Size(37, 20);
            this.cbo_hour.TabIndex = 7;
            // 
            // cbo_minute
            // 
            this.cbo_minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_minute.FormattingEnabled = true;
            this.cbo_minute.Location = new System.Drawing.Point(151, 78);
            this.cbo_minute.Name = "cbo_minute";
            this.cbo_minute.Size = new System.Drawing.Size(37, 20);
            this.cbo_minute.TabIndex = 8;
            // 
            // cbo_second
            // 
            this.cbo_second.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_second.FormattingEnabled = true;
            this.cbo_second.Location = new System.Drawing.Point(204, 78);
            this.cbo_second.Name = "cbo_second";
            this.cbo_second.Size = new System.Drawing.Size(37, 20);
            this.cbo_second.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "秒";
            // 
            // CountClockAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 188);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_second);
            this.Controls.Add(this.cbo_minute);
            this.Controls.Add(this.cbo_hour);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tag);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountClockAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加倒计时";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_hour;
        private System.Windows.Forms.ComboBox cbo_minute;
        private System.Windows.Forms.ComboBox cbo_second;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}