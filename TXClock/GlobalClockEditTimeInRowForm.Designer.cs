namespace TXClock
{
    partial class GlobalClockEditTimeInRowForm
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_minute = new System.Windows.Forms.ComboBox();
            this.cbo_hour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(101, 68);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "时";
            // 
            // cbo_minute
            // 
            this.cbo_minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_minute.FormattingEnabled = true;
            this.cbo_minute.Location = new System.Drawing.Point(139, 20);
            this.cbo_minute.Name = "cbo_minute";
            this.cbo_minute.Size = new System.Drawing.Size(37, 20);
            this.cbo_minute.TabIndex = 23;
            // 
            // cbo_hour
            // 
            this.cbo_hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_hour.FormattingEnabled = true;
            this.cbo_hour.Location = new System.Drawing.Point(83, 20);
            this.cbo_hour.Name = "cbo_hour";
            this.cbo_hour.Size = new System.Drawing.Size(37, 20);
            this.cbo_hour.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "时间";
            // 
            // GlobalClockEditTimeInRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 116);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_minute);
            this.Controls.Add(this.cbo_hour);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlobalClockEditTimeInRowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑时间";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_minute;
        private System.Windows.Forms.ComboBox cbo_hour;
        private System.Windows.Forms.Label label2;
    }
}