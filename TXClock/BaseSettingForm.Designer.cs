namespace TXClock
{
    partial class BaseSettingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbk_startWithWds = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_message = new System.Windows.Forms.RadioButton();
            this.rbt_dialog = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbk_startWithWds);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开机启动";
            // 
            // cbk_startWithWds
            // 
            this.cbk_startWithWds.AutoSize = true;
            this.cbk_startWithWds.Location = new System.Drawing.Point(31, 20);
            this.cbk_startWithWds.Name = "cbk_startWithWds";
            this.cbk_startWithWds.Size = new System.Drawing.Size(72, 16);
            this.cbk_startWithWds.TabIndex = 0;
            this.cbk_startWithWds.Text = "开机启动";
            this.cbk_startWithWds.UseVisualStyleBackColor = true;
            this.cbk_startWithWds.CheckedChanged += new System.EventHandler(this.cbk_startWithWds_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_dialog);
            this.groupBox2.Controls.Add(this.rbt_message);
            this.groupBox2.Location = new System.Drawing.Point(13, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "提醒方式";
            // 
            // rbt_message
            // 
            this.rbt_message.AutoSize = true;
            this.rbt_message.Location = new System.Drawing.Point(30, 32);
            this.rbt_message.Name = "rbt_message";
            this.rbt_message.Size = new System.Drawing.Size(47, 16);
            this.rbt_message.TabIndex = 6;
            this.rbt_message.TabStop = true;
            this.rbt_message.Text = "气泡";
            this.rbt_message.UseVisualStyleBackColor = true;
            this.rbt_message.CheckedChanged += new System.EventHandler(this.rbt_message_CheckedChanged);
            // 
            // rbt_dialog
            // 
            this.rbt_dialog.AutoSize = true;
            this.rbt_dialog.Location = new System.Drawing.Point(154, 32);
            this.rbt_dialog.Name = "rbt_dialog";
            this.rbt_dialog.Size = new System.Drawing.Size(47, 16);
            this.rbt_dialog.TabIndex = 7;
            this.rbt_dialog.TabStop = true;
            this.rbt_dialog.Text = "弹窗";
            this.rbt_dialog.UseVisualStyleBackColor = true;
            this.rbt_dialog.CheckedChanged += new System.EventHandler(this.rbt_dialog_CheckedChanged);
            // 
            // BaseSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BaseSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbk_startWithWds;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbt_dialog;
        private System.Windows.Forms.RadioButton rbt_message;
    }
}