namespace TXClock
{
    partial class GlobalClockAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GlobalClockAddAdd_btn = new System.Windows.Forms.Button();
            this.GlobalClockAddSave_btn = new System.Windows.Forms.Button();
            this.GlobalClockAdd_grv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.GlobalClockAddTag_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GlobalClockAddAdd_rb1 = new System.Windows.Forms.RadioButton();
            this.GlobalClockAddAdd_rb2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GlobalClockAddAdd_cb6 = new System.Windows.Forms.CheckBox();
            this.GlobalClockAddAdd_cb5 = new System.Windows.Forms.CheckBox();
            this.GlobalClockAddAdd_cb4 = new System.Windows.Forms.CheckBox();
            this.GlobalClockAddAdd_cb3 = new System.Windows.Forms.CheckBox();
            this.GlobalClockAddAdd_cb2 = new System.Windows.Forms.CheckBox();
            this.GlobalClockAddAdd_cb1 = new System.Windows.Forms.CheckBox();
            this.GlobalClockAddAdd_cb0 = new System.Windows.Forms.CheckBox();
            this.GlobalClockAddAdd_rb3 = new System.Windows.Forms.RadioButton();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalClockAdd_grv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalClockAddAdd_btn
            // 
            this.GlobalClockAddAdd_btn.Location = new System.Drawing.Point(211, 62);
            this.GlobalClockAddAdd_btn.Name = "GlobalClockAddAdd_btn";
            this.GlobalClockAddAdd_btn.Size = new System.Drawing.Size(75, 23);
            this.GlobalClockAddAdd_btn.TabIndex = 11;
            this.GlobalClockAddAdd_btn.Text = "添加";
            this.GlobalClockAddAdd_btn.UseVisualStyleBackColor = true;
            this.GlobalClockAddAdd_btn.Click += new System.EventHandler(this.GlobalClockAddAdd_btn_Click);
            // 
            // GlobalClockAddSave_btn
            // 
            this.GlobalClockAddSave_btn.Location = new System.Drawing.Point(211, 375);
            this.GlobalClockAddSave_btn.Name = "GlobalClockAddSave_btn";
            this.GlobalClockAddSave_btn.Size = new System.Drawing.Size(75, 23);
            this.GlobalClockAddSave_btn.TabIndex = 10;
            this.GlobalClockAddSave_btn.Text = "保存";
            this.GlobalClockAddSave_btn.UseVisualStyleBackColor = true;
            this.GlobalClockAddSave_btn.Click += new System.EventHandler(this.GlobalClockAddSave_btn_Click);
            // 
            // GlobalClockAdd_grv
            // 
            this.GlobalClockAdd_grv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GlobalClockAdd_grv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GlobalClockAdd_grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GlobalClockAdd_grv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.tag,
            this.delete});
            this.GlobalClockAdd_grv.Location = new System.Drawing.Point(21, 99);
            this.GlobalClockAdd_grv.Name = "GlobalClockAdd_grv";
            this.GlobalClockAdd_grv.ReadOnly = true;
            this.GlobalClockAdd_grv.RowHeadersVisible = false;
            this.GlobalClockAdd_grv.RowTemplate.Height = 23;
            this.GlobalClockAdd_grv.Size = new System.Drawing.Size(293, 170);
            this.GlobalClockAdd_grv.TabIndex = 9;
            this.GlobalClockAdd_grv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GlobalClockAdd_grv_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "闹钟时间：";
            // 
            // GlobalClockAddTag_txt
            // 
            this.GlobalClockAddTag_txt.Location = new System.Drawing.Point(90, 22);
            this.GlobalClockAddTag_txt.Name = "GlobalClockAddTag_txt";
            this.GlobalClockAddTag_txt.Size = new System.Drawing.Size(217, 21);
            this.GlobalClockAddTag_txt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "闹钟标签：";
            // 
            // GlobalClockAddAdd_rb1
            // 
            this.GlobalClockAddAdd_rb1.AutoSize = true;
            this.GlobalClockAddAdd_rb1.Location = new System.Drawing.Point(210, 287);
            this.GlobalClockAddAdd_rb1.Name = "GlobalClockAddAdd_rb1";
            this.GlobalClockAddAdd_rb1.Size = new System.Drawing.Size(47, 16);
            this.GlobalClockAddAdd_rb1.TabIndex = 12;
            this.GlobalClockAddAdd_rb1.Text = "每天";
            this.GlobalClockAddAdd_rb1.UseVisualStyleBackColor = true;
            this.GlobalClockAddAdd_rb1.CheckedChanged += new System.EventHandler(this.GlobalClockAddAdd_rb1_CheckedChanged);
            // 
            // GlobalClockAddAdd_rb2
            // 
            this.GlobalClockAddAdd_rb2.AutoSize = true;
            this.GlobalClockAddAdd_rb2.Location = new System.Drawing.Point(136, 287);
            this.GlobalClockAddAdd_rb2.Name = "GlobalClockAddAdd_rb2";
            this.GlobalClockAddAdd_rb2.Size = new System.Drawing.Size(59, 16);
            this.GlobalClockAddAdd_rb2.TabIndex = 13;
            this.GlobalClockAddAdd_rb2.Text = "自定义";
            this.GlobalClockAddAdd_rb2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GlobalClockAddAdd_cb6);
            this.groupBox1.Controls.Add(this.GlobalClockAddAdd_cb5);
            this.groupBox1.Controls.Add(this.GlobalClockAddAdd_cb4);
            this.groupBox1.Controls.Add(this.GlobalClockAddAdd_cb3);
            this.groupBox1.Controls.Add(this.GlobalClockAddAdd_cb2);
            this.groupBox1.Controls.Add(this.GlobalClockAddAdd_cb1);
            this.groupBox1.Controls.Add(this.GlobalClockAddAdd_cb0);
            this.groupBox1.Location = new System.Drawing.Point(37, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自定义选择(星期)";
            // 
            // GlobalClockAddAdd_cb6
            // 
            this.GlobalClockAddAdd_cb6.AutoSize = true;
            this.GlobalClockAddAdd_cb6.Location = new System.Drawing.Point(233, 21);
            this.GlobalClockAddAdd_cb6.Name = "GlobalClockAddAdd_cb6";
            this.GlobalClockAddAdd_cb6.Size = new System.Drawing.Size(36, 16);
            this.GlobalClockAddAdd_cb6.TabIndex = 6;
            this.GlobalClockAddAdd_cb6.Text = "六";
            this.GlobalClockAddAdd_cb6.UseVisualStyleBackColor = true;
            // 
            // GlobalClockAddAdd_cb5
            // 
            this.GlobalClockAddAdd_cb5.AutoSize = true;
            this.GlobalClockAddAdd_cb5.Location = new System.Drawing.Point(196, 21);
            this.GlobalClockAddAdd_cb5.Name = "GlobalClockAddAdd_cb5";
            this.GlobalClockAddAdd_cb5.Size = new System.Drawing.Size(36, 16);
            this.GlobalClockAddAdd_cb5.TabIndex = 5;
            this.GlobalClockAddAdd_cb5.Text = "五";
            this.GlobalClockAddAdd_cb5.UseVisualStyleBackColor = true;
            // 
            // GlobalClockAddAdd_cb4
            // 
            this.GlobalClockAddAdd_cb4.AutoSize = true;
            this.GlobalClockAddAdd_cb4.Location = new System.Drawing.Point(159, 21);
            this.GlobalClockAddAdd_cb4.Name = "GlobalClockAddAdd_cb4";
            this.GlobalClockAddAdd_cb4.Size = new System.Drawing.Size(36, 16);
            this.GlobalClockAddAdd_cb4.TabIndex = 4;
            this.GlobalClockAddAdd_cb4.Text = "四";
            this.GlobalClockAddAdd_cb4.UseVisualStyleBackColor = true;
            // 
            // GlobalClockAddAdd_cb3
            // 
            this.GlobalClockAddAdd_cb3.AutoSize = true;
            this.GlobalClockAddAdd_cb3.Location = new System.Drawing.Point(122, 21);
            this.GlobalClockAddAdd_cb3.Name = "GlobalClockAddAdd_cb3";
            this.GlobalClockAddAdd_cb3.Size = new System.Drawing.Size(36, 16);
            this.GlobalClockAddAdd_cb3.TabIndex = 3;
            this.GlobalClockAddAdd_cb3.Text = "三";
            this.GlobalClockAddAdd_cb3.UseVisualStyleBackColor = true;
            // 
            // GlobalClockAddAdd_cb2
            // 
            this.GlobalClockAddAdd_cb2.AutoSize = true;
            this.GlobalClockAddAdd_cb2.Location = new System.Drawing.Point(85, 21);
            this.GlobalClockAddAdd_cb2.Name = "GlobalClockAddAdd_cb2";
            this.GlobalClockAddAdd_cb2.Size = new System.Drawing.Size(36, 16);
            this.GlobalClockAddAdd_cb2.TabIndex = 2;
            this.GlobalClockAddAdd_cb2.Text = "二";
            this.GlobalClockAddAdd_cb2.UseVisualStyleBackColor = true;
            // 
            // GlobalClockAddAdd_cb1
            // 
            this.GlobalClockAddAdd_cb1.AutoSize = true;
            this.GlobalClockAddAdd_cb1.Location = new System.Drawing.Point(48, 21);
            this.GlobalClockAddAdd_cb1.Name = "GlobalClockAddAdd_cb1";
            this.GlobalClockAddAdd_cb1.Size = new System.Drawing.Size(36, 16);
            this.GlobalClockAddAdd_cb1.TabIndex = 1;
            this.GlobalClockAddAdd_cb1.Text = "一";
            this.GlobalClockAddAdd_cb1.UseVisualStyleBackColor = true;
            // 
            // GlobalClockAddAdd_cb0
            // 
            this.GlobalClockAddAdd_cb0.AutoSize = true;
            this.GlobalClockAddAdd_cb0.Location = new System.Drawing.Point(11, 21);
            this.GlobalClockAddAdd_cb0.Name = "GlobalClockAddAdd_cb0";
            this.GlobalClockAddAdd_cb0.Size = new System.Drawing.Size(36, 16);
            this.GlobalClockAddAdd_cb0.TabIndex = 0;
            this.GlobalClockAddAdd_cb0.Text = "日";
            this.GlobalClockAddAdd_cb0.UseVisualStyleBackColor = true;
            // 
            // GlobalClockAddAdd_rb3
            // 
            this.GlobalClockAddAdd_rb3.AutoSize = true;
            this.GlobalClockAddAdd_rb3.Checked = true;
            this.GlobalClockAddAdd_rb3.Location = new System.Drawing.Point(62, 287);
            this.GlobalClockAddAdd_rb3.Name = "GlobalClockAddAdd_rb3";
            this.GlobalClockAddAdd_rb3.Size = new System.Drawing.Size(59, 16);
            this.GlobalClockAddAdd_rb3.TabIndex = 15;
            this.GlobalClockAddAdd_rb3.TabStop = true;
            this.GlobalClockAddAdd_rb3.Text = "一次性";
            this.GlobalClockAddAdd_rb3.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.time.DefaultCellStyle = dataGridViewCellStyle2;
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // tag
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tag.DefaultCellStyle = dataGridViewCellStyle3;
            this.tag.HeaderText = "提示信息";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.delete.Width = 90;
            // 
            // GlobalClockAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 410);
            this.Controls.Add(this.GlobalClockAddAdd_rb3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GlobalClockAddAdd_rb2);
            this.Controls.Add(this.GlobalClockAddAdd_rb1);
            this.Controls.Add(this.GlobalClockAddAdd_btn);
            this.Controls.Add(this.GlobalClockAddSave_btn);
            this.Controls.Add(this.GlobalClockAdd_grv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GlobalClockAddTag_txt);
            this.Controls.Add(this.label1);
            this.Name = "GlobalClockAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加闹钟";
            ((System.ComponentModel.ISupportInitialize)(this.GlobalClockAdd_grv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GlobalClockAddAdd_btn;
        private System.Windows.Forms.Button GlobalClockAddSave_btn;
        private System.Windows.Forms.DataGridView GlobalClockAdd_grv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GlobalClockAddTag_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton GlobalClockAddAdd_rb1;
        private System.Windows.Forms.RadioButton GlobalClockAddAdd_rb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox GlobalClockAddAdd_cb6;
        private System.Windows.Forms.CheckBox GlobalClockAddAdd_cb5;
        private System.Windows.Forms.CheckBox GlobalClockAddAdd_cb4;
        private System.Windows.Forms.CheckBox GlobalClockAddAdd_cb3;
        private System.Windows.Forms.CheckBox GlobalClockAddAdd_cb2;
        private System.Windows.Forms.CheckBox GlobalClockAddAdd_cb1;
        private System.Windows.Forms.CheckBox GlobalClockAddAdd_cb0;
        private System.Windows.Forms.RadioButton GlobalClockAddAdd_rb3;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
    }
}