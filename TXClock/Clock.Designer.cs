namespace TXClock
{
    partial class Clock
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Setting_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Clock_tbc = new System.Windows.Forms.TabControl();
            this.GlobalClock_tbp = new System.Windows.Forms.TabPage();
            this.GlobalClock_gpb = new System.Windows.Forms.GroupBox();
            this.GlobalClock_pal = new System.Windows.Forms.Panel();
            this.lb_timeNow = new System.Windows.Forms.Label();
            this.btn_editGlobalClock = new System.Windows.Forms.Button();
            this.btn_addGlobalClock = new System.Windows.Forms.Button();
            this.ClockGlobalGrd_grd = new System.Windows.Forms.DataGridView();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountClock_tbp = new System.Windows.Forms.TabPage();
            this.CountItem_pal = new System.Windows.Forms.Panel();
            this.StopAllCount_btn = new System.Windows.Forms.Button();
            this.StartAllCount_btn = new System.Windows.Forms.Button();
            this.CountClock_gpb = new System.Windows.Forms.GroupBox();
            this.Counting_pal = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.Clock_tbc.SuspendLayout();
            this.GlobalClock_tbp.SuspendLayout();
            this.GlobalClock_gpb.SuspendLayout();
            this.GlobalClock_pal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockGlobalGrd_grd)).BeginInit();
            this.CountClock_tbp.SuspendLayout();
            this.CountClock_gpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXNotifyIcon
            // 
            this.TXNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TXNotifyIcon.Icon")));
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting_tsmi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Setting_tsmi
            // 
            this.Setting_tsmi.Name = "Setting_tsmi";
            this.Setting_tsmi.Size = new System.Drawing.Size(44, 21);
            this.Setting_tsmi.Text = "设置";
            this.Setting_tsmi.Click += new System.EventHandler(this.Setting_tsmi_Click);
            // 
            // Clock_tbc
            // 
            this.Clock_tbc.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Clock_tbc.Controls.Add(this.GlobalClock_tbp);
            this.Clock_tbc.Controls.Add(this.CountClock_tbp);
            this.Clock_tbc.Location = new System.Drawing.Point(0, 28);
            this.Clock_tbc.Multiline = true;
            this.Clock_tbc.Name = "Clock_tbc";
            this.Clock_tbc.SelectedIndex = 0;
            this.Clock_tbc.Size = new System.Drawing.Size(333, 420);
            this.Clock_tbc.TabIndex = 2;
            // 
            // GlobalClock_tbp
            // 
            this.GlobalClock_tbp.Controls.Add(this.GlobalClock_gpb);
            this.GlobalClock_tbp.Location = new System.Drawing.Point(4, 4);
            this.GlobalClock_tbp.Name = "GlobalClock_tbp";
            this.GlobalClock_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.GlobalClock_tbp.Size = new System.Drawing.Size(325, 394);
            this.GlobalClock_tbp.TabIndex = 0;
            this.GlobalClock_tbp.Text = "闹钟";
            this.GlobalClock_tbp.UseVisualStyleBackColor = true;
            // 
            // GlobalClock_gpb
            // 
            this.GlobalClock_gpb.Controls.Add(this.GlobalClock_pal);
            this.GlobalClock_gpb.Location = new System.Drawing.Point(3, 6);
            this.GlobalClock_gpb.Name = "GlobalClock_gpb";
            this.GlobalClock_gpb.Size = new System.Drawing.Size(316, 385);
            this.GlobalClock_gpb.TabIndex = 0;
            this.GlobalClock_gpb.TabStop = false;
            this.GlobalClock_gpb.Text = "闹钟";
            // 
            // GlobalClock_pal
            // 
            this.GlobalClock_pal.Controls.Add(this.lb_timeNow);
            this.GlobalClock_pal.Controls.Add(this.btn_editGlobalClock);
            this.GlobalClock_pal.Controls.Add(this.btn_addGlobalClock);
            this.GlobalClock_pal.Controls.Add(this.ClockGlobalGrd_grd);
            this.GlobalClock_pal.Location = new System.Drawing.Point(3, 18);
            this.GlobalClock_pal.Name = "GlobalClock_pal";
            this.GlobalClock_pal.Size = new System.Drawing.Size(311, 361);
            this.GlobalClock_pal.TabIndex = 0;
            // 
            // lb_timeNow
            // 
            this.lb_timeNow.AutoSize = true;
            this.lb_timeNow.Location = new System.Drawing.Point(6, 338);
            this.lb_timeNow.Name = "lb_timeNow";
            this.lb_timeNow.Size = new System.Drawing.Size(0, 12);
            this.lb_timeNow.TabIndex = 3;
            // 
            // btn_editGlobalClock
            // 
            this.btn_editGlobalClock.Location = new System.Drawing.Point(232, 331);
            this.btn_editGlobalClock.Name = "btn_editGlobalClock";
            this.btn_editGlobalClock.Size = new System.Drawing.Size(75, 23);
            this.btn_editGlobalClock.TabIndex = 1;
            this.btn_editGlobalClock.Text = "编辑";
            this.btn_editGlobalClock.UseVisualStyleBackColor = true;
            this.btn_editGlobalClock.Click += new System.EventHandler(this.btn_editGlobalClock_Click);
            // 
            // btn_addGlobalClock
            // 
            this.btn_addGlobalClock.Location = new System.Drawing.Point(152, 331);
            this.btn_addGlobalClock.Name = "btn_addGlobalClock";
            this.btn_addGlobalClock.Size = new System.Drawing.Size(75, 23);
            this.btn_addGlobalClock.TabIndex = 0;
            this.btn_addGlobalClock.Text = "添加";
            this.btn_addGlobalClock.UseVisualStyleBackColor = true;
            this.btn_addGlobalClock.Click += new System.EventHandler(this.btn_addGlobalClock_Click);
            // 
            // ClockGlobalGrd_grd
            // 
            this.ClockGlobalGrd_grd.AllowUserToAddRows = false;
            this.ClockGlobalGrd_grd.AllowUserToDeleteRows = false;
            this.ClockGlobalGrd_grd.AllowUserToOrderColumns = true;
            this.ClockGlobalGrd_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClockGlobalGrd_grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tag,
            this.time,
            this.leftTime,
            this.note,
            this.clockType,
            this.enable});
            this.ClockGlobalGrd_grd.Location = new System.Drawing.Point(2, 3);
            this.ClockGlobalGrd_grd.Name = "ClockGlobalGrd_grd";
            this.ClockGlobalGrd_grd.RowHeadersVisible = false;
            this.ClockGlobalGrd_grd.RowTemplate.Height = 23;
            this.ClockGlobalGrd_grd.Size = new System.Drawing.Size(309, 322);
            this.ClockGlobalGrd_grd.TabIndex = 2;
            this.ClockGlobalGrd_grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClockGlobalGrd_grd_CellClick);
            // 
            // tag
            // 
            this.tag.HeaderText = "标签";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // leftTime
            // 
            this.leftTime.HeaderText = "剩余时间";
            this.leftTime.Name = "leftTime";
            this.leftTime.ReadOnly = true;
            // 
            // note
            // 
            this.note.HeaderText = "注释";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // clockType
            // 
            this.clockType.HeaderText = "类型";
            this.clockType.Name = "clockType";
            this.clockType.ReadOnly = true;
            // 
            // enable
            // 
            this.enable.HeaderText = "启用(点击切换)";
            this.enable.Name = "enable";
            this.enable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CountClock_tbp
            // 
            this.CountClock_tbp.Controls.Add(this.CountItem_pal);
            this.CountClock_tbp.Controls.Add(this.StopAllCount_btn);
            this.CountClock_tbp.Controls.Add(this.StartAllCount_btn);
            this.CountClock_tbp.Controls.Add(this.CountClock_gpb);
            this.CountClock_tbp.Location = new System.Drawing.Point(4, 4);
            this.CountClock_tbp.Name = "CountClock_tbp";
            this.CountClock_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.CountClock_tbp.Size = new System.Drawing.Size(325, 394);
            this.CountClock_tbp.TabIndex = 1;
            this.CountClock_tbp.Text = "计时";
            this.CountClock_tbp.UseVisualStyleBackColor = true;
            // 
            // CountItem_pal
            // 
            this.CountItem_pal.Location = new System.Drawing.Point(9, 200);
            this.CountItem_pal.Name = "CountItem_pal";
            this.CountItem_pal.Size = new System.Drawing.Size(307, 193);
            this.CountItem_pal.TabIndex = 3;
            // 
            // StopAllCount_btn
            // 
            this.StopAllCount_btn.Location = new System.Drawing.Point(165, 167);
            this.StopAllCount_btn.Name = "StopAllCount_btn";
            this.StopAllCount_btn.Size = new System.Drawing.Size(152, 26);
            this.StopAllCount_btn.TabIndex = 2;
            this.StopAllCount_btn.Text = "全部开始";
            this.StopAllCount_btn.UseVisualStyleBackColor = true;
            // 
            // StartAllCount_btn
            // 
            this.StartAllCount_btn.Location = new System.Drawing.Point(8, 167);
            this.StartAllCount_btn.Name = "StartAllCount_btn";
            this.StartAllCount_btn.Size = new System.Drawing.Size(152, 26);
            this.StartAllCount_btn.TabIndex = 1;
            this.StartAllCount_btn.Text = "全部停止";
            this.StartAllCount_btn.UseVisualStyleBackColor = true;
            // 
            // CountClock_gpb
            // 
            this.CountClock_gpb.Controls.Add(this.Counting_pal);
            this.CountClock_gpb.Location = new System.Drawing.Point(8, 6);
            this.CountClock_gpb.Name = "CountClock_gpb";
            this.CountClock_gpb.Size = new System.Drawing.Size(309, 152);
            this.CountClock_gpb.TabIndex = 0;
            this.CountClock_gpb.TabStop = false;
            this.CountClock_gpb.Text = "倒计时";
            // 
            // Counting_pal
            // 
            this.Counting_pal.Location = new System.Drawing.Point(7, 14);
            this.Counting_pal.Name = "Counting_pal";
            this.Counting_pal.Size = new System.Drawing.Size(296, 132);
            this.Counting_pal.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 451);
            this.Controls.Add(this.Clock_tbc);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TXClock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Clock_tbc.ResumeLayout(false);
            this.GlobalClock_tbp.ResumeLayout(false);
            this.GlobalClock_gpb.ResumeLayout(false);
            this.GlobalClock_pal.ResumeLayout(false);
            this.GlobalClock_pal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockGlobalGrd_grd)).EndInit();
            this.CountClock_tbp.ResumeLayout(false);
            this.CountClock_gpb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Setting_tsmi;
        private System.Windows.Forms.TabControl Clock_tbc;
        private System.Windows.Forms.TabPage GlobalClock_tbp;
        private System.Windows.Forms.TabPage CountClock_tbp;
        private System.Windows.Forms.Button StopAllCount_btn;
        private System.Windows.Forms.Button StartAllCount_btn;
        private System.Windows.Forms.GroupBox CountClock_gpb;
        private System.Windows.Forms.Panel Counting_pal;
        private System.Windows.Forms.GroupBox GlobalClock_gpb;
        private System.Windows.Forms.Panel GlobalClock_pal;
        private System.Windows.Forms.Panel CountItem_pal;
        private System.Windows.Forms.DataGridView ClockGlobalGrd_grd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_editGlobalClock;
        private System.Windows.Forms.Button btn_addGlobalClock;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn enable;
        private System.Windows.Forms.Label lb_timeNow;
    }
}

