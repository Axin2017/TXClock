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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_editCountClock = new System.Windows.Forms.Button();
            this.btn_addCountClock = new System.Windows.Forms.Button();
            this.CountItem_pal = new System.Windows.Forms.Panel();
            this.grv_countClock = new System.Windows.Forms.DataGridView();
            this.cell_tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_allTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_startCount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CountClock_gpb = new System.Windows.Forms.GroupBox();
            this.btn_addOnceCountClock = new System.Windows.Forms.Button();
            this.Counting_pal = new System.Windows.Forms.Panel();
            this.grv_countingClock = new System.Windows.Forms.DataGridView();
            this.StopAllCount_btn = new System.Windows.Forms.Button();
            this.StartAllCount_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cell_countingTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_leftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_enable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            this.Clock_tbc.SuspendLayout();
            this.GlobalClock_tbp.SuspendLayout();
            this.GlobalClock_gpb.SuspendLayout();
            this.GlobalClock_pal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockGlobalGrd_grd)).BeginInit();
            this.CountClock_tbp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CountItem_pal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_countClock)).BeginInit();
            this.CountClock_gpb.SuspendLayout();
            this.Counting_pal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_countingClock)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClockGlobalGrd_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tag.DefaultCellStyle = dataGridViewCellStyle2;
            this.tag.HeaderText = "标签";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 55;
            // 
            // time
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.time.DefaultCellStyle = dataGridViewCellStyle3;
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 55;
            // 
            // leftTime
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.leftTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.leftTime.HeaderText = "剩余时间";
            this.leftTime.Name = "leftTime";
            this.leftTime.ReadOnly = true;
            this.leftTime.Width = 80;
            // 
            // note
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.note.DefaultCellStyle = dataGridViewCellStyle5;
            this.note.HeaderText = "注释";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.note.Width = 70;
            // 
            // clockType
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clockType.DefaultCellStyle = dataGridViewCellStyle6;
            this.clockType.HeaderText = "类型";
            this.clockType.Name = "clockType";
            this.clockType.ReadOnly = true;
            this.clockType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clockType.Width = 55;
            // 
            // enable
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.enable.DefaultCellStyle = dataGridViewCellStyle7;
            this.enable.HeaderText = "启用(点击切换)";
            this.enable.Name = "enable";
            this.enable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.enable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CountClock_tbp
            // 
            this.CountClock_tbp.Controls.Add(this.groupBox1);
            this.CountClock_tbp.Controls.Add(this.CountClock_gpb);
            this.CountClock_tbp.Location = new System.Drawing.Point(4, 4);
            this.CountClock_tbp.Name = "CountClock_tbp";
            this.CountClock_tbp.Padding = new System.Windows.Forms.Padding(3);
            this.CountClock_tbp.Size = new System.Drawing.Size(325, 394);
            this.CountClock_tbp.TabIndex = 1;
            this.CountClock_tbp.Text = "计时";
            this.CountClock_tbp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_editCountClock);
            this.groupBox1.Controls.Add(this.btn_addCountClock);
            this.groupBox1.Controls.Add(this.CountItem_pal);
            this.groupBox1.Location = new System.Drawing.Point(9, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常用计时";
            // 
            // btn_editCountClock
            // 
            this.btn_editCountClock.Location = new System.Drawing.Point(227, 159);
            this.btn_editCountClock.Name = "btn_editCountClock";
            this.btn_editCountClock.Size = new System.Drawing.Size(75, 23);
            this.btn_editCountClock.TabIndex = 5;
            this.btn_editCountClock.Text = "编辑";
            this.btn_editCountClock.UseVisualStyleBackColor = true;
            this.btn_editCountClock.Click += new System.EventHandler(this.btn_editCountClock_Click);
            // 
            // btn_addCountClock
            // 
            this.btn_addCountClock.Location = new System.Drawing.Point(146, 159);
            this.btn_addCountClock.Name = "btn_addCountClock";
            this.btn_addCountClock.Size = new System.Drawing.Size(75, 23);
            this.btn_addCountClock.TabIndex = 4;
            this.btn_addCountClock.Text = "添加";
            this.btn_addCountClock.UseVisualStyleBackColor = true;
            this.btn_addCountClock.Click += new System.EventHandler(this.btn_addCountClock_Click);
            // 
            // CountItem_pal
            // 
            this.CountItem_pal.Controls.Add(this.grv_countClock);
            this.CountItem_pal.Location = new System.Drawing.Point(6, 20);
            this.CountItem_pal.Name = "CountItem_pal";
            this.CountItem_pal.Size = new System.Drawing.Size(296, 129);
            this.CountItem_pal.TabIndex = 3;
            // 
            // grv_countClock
            // 
            this.grv_countClock.AllowUserToAddRows = false;
            this.grv_countClock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_countClock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grv_countClock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_countClock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cell_tag,
            this.cell_allTime,
            this.cell_note,
            this.cell_startCount});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_countClock.DefaultCellStyle = dataGridViewCellStyle12;
            this.grv_countClock.Location = new System.Drawing.Point(4, 4);
            this.grv_countClock.Name = "grv_countClock";
            this.grv_countClock.RowHeadersVisible = false;
            this.grv_countClock.RowTemplate.Height = 23;
            this.grv_countClock.Size = new System.Drawing.Size(285, 122);
            this.grv_countClock.TabIndex = 0;
            this.grv_countClock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_countClock_CellClick);
            // 
            // cell_tag
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_tag.DefaultCellStyle = dataGridViewCellStyle9;
            this.cell_tag.HeaderText = "标签";
            this.cell_tag.Name = "cell_tag";
            this.cell_tag.ReadOnly = true;
            this.cell_tag.Width = 70;
            // 
            // cell_allTime
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_allTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.cell_allTime.HeaderText = "时长";
            this.cell_allTime.Name = "cell_allTime";
            this.cell_allTime.ReadOnly = true;
            this.cell_allTime.Width = 70;
            // 
            // cell_note
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_note.DefaultCellStyle = dataGridViewCellStyle11;
            this.cell_note.HeaderText = "注释";
            this.cell_note.Name = "cell_note";
            this.cell_note.ReadOnly = true;
            this.cell_note.Width = 60;
            // 
            // cell_startCount
            // 
            this.cell_startCount.HeaderText = "开始计时";
            this.cell_startCount.Name = "cell_startCount";
            this.cell_startCount.ReadOnly = true;
            this.cell_startCount.Width = 82;
            // 
            // CountClock_gpb
            // 
            this.CountClock_gpb.Controls.Add(this.btn_addOnceCountClock);
            this.CountClock_gpb.Controls.Add(this.Counting_pal);
            this.CountClock_gpb.Controls.Add(this.StopAllCount_btn);
            this.CountClock_gpb.Controls.Add(this.StartAllCount_btn);
            this.CountClock_gpb.Location = new System.Drawing.Point(8, 6);
            this.CountClock_gpb.Name = "CountClock_gpb";
            this.CountClock_gpb.Size = new System.Drawing.Size(309, 188);
            this.CountClock_gpb.TabIndex = 0;
            this.CountClock_gpb.TabStop = false;
            this.CountClock_gpb.Text = "倒计时";
            // 
            // btn_addOnceCountClock
            // 
            this.btn_addOnceCountClock.Location = new System.Drawing.Point(227, 152);
            this.btn_addOnceCountClock.Name = "btn_addOnceCountClock";
            this.btn_addOnceCountClock.Size = new System.Drawing.Size(69, 26);
            this.btn_addOnceCountClock.TabIndex = 3;
            this.btn_addOnceCountClock.Text = "添加";
            this.btn_addOnceCountClock.UseVisualStyleBackColor = true;
            // 
            // Counting_pal
            // 
            this.Counting_pal.Controls.Add(this.grv_countingClock);
            this.Counting_pal.Location = new System.Drawing.Point(7, 14);
            this.Counting_pal.Name = "Counting_pal";
            this.Counting_pal.Size = new System.Drawing.Size(296, 132);
            this.Counting_pal.TabIndex = 0;
            // 
            // grv_countingClock
            // 
            this.grv_countingClock.AllowUserToAddRows = false;
            this.grv_countingClock.AllowUserToDeleteRows = false;
            this.grv_countingClock.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_countingClock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grv_countingClock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_countingClock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cell_countingTag,
            this.cell_leftTime,
            this.cell_enable,
            this.cell_delete});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_countingClock.DefaultCellStyle = dataGridViewCellStyle17;
            this.grv_countingClock.Location = new System.Drawing.Point(4, 7);
            this.grv_countingClock.Name = "grv_countingClock";
            this.grv_countingClock.RowHeadersVisible = false;
            this.grv_countingClock.RowTemplate.Height = 23;
            this.grv_countingClock.Size = new System.Drawing.Size(285, 122);
            this.grv_countingClock.TabIndex = 0;
            this.grv_countingClock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_countingClock_CellClick);
            // 
            // StopAllCount_btn
            // 
            this.StopAllCount_btn.Location = new System.Drawing.Point(153, 152);
            this.StopAllCount_btn.Name = "StopAllCount_btn";
            this.StopAllCount_btn.Size = new System.Drawing.Size(69, 26);
            this.StopAllCount_btn.TabIndex = 2;
            this.StopAllCount_btn.Text = "全部开始";
            this.StopAllCount_btn.UseVisualStyleBackColor = true;
            // 
            // StartAllCount_btn
            // 
            this.StartAllCount_btn.Location = new System.Drawing.Point(78, 152);
            this.StartAllCount_btn.Name = "StartAllCount_btn";
            this.StartAllCount_btn.Size = new System.Drawing.Size(69, 26);
            this.StartAllCount_btn.TabIndex = 1;
            this.StartAllCount_btn.Text = "全部停止";
            this.StartAllCount_btn.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cell_countingTag
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_countingTag.DefaultCellStyle = dataGridViewCellStyle14;
            this.cell_countingTag.HeaderText = "标签";
            this.cell_countingTag.Name = "cell_countingTag";
            this.cell_countingTag.ReadOnly = true;
            this.cell_countingTag.Width = 70;
            // 
            // cell_leftTime
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_leftTime.DefaultCellStyle = dataGridViewCellStyle15;
            this.cell_leftTime.HeaderText = "剩余时间";
            this.cell_leftTime.Name = "cell_leftTime";
            this.cell_leftTime.ReadOnly = true;
            this.cell_leftTime.Width = 92;
            // 
            // cell_enable
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_enable.DefaultCellStyle = dataGridViewCellStyle16;
            this.cell_enable.HeaderText = "启用";
            this.cell_enable.Name = "cell_enable";
            this.cell_enable.ReadOnly = true;
            this.cell_enable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cell_enable.Width = 60;
            // 
            // cell_delete
            // 
            this.cell_delete.HeaderText = "删除";
            this.cell_delete.Name = "cell_delete";
            this.cell_delete.ReadOnly = true;
            this.cell_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cell_delete.Width = 60;
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
            this.groupBox1.ResumeLayout(false);
            this.CountItem_pal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_countClock)).EndInit();
            this.CountClock_gpb.ResumeLayout(false);
            this.Counting_pal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_countingClock)).EndInit();
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
        private System.Windows.Forms.Label lb_timeNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn enable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_editCountClock;
        private System.Windows.Forms.Button btn_addCountClock;
        private System.Windows.Forms.DataGridView grv_countClock;
        private System.Windows.Forms.Button btn_addOnceCountClock;
        private System.Windows.Forms.DataGridView grv_countingClock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_allTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_note;
        private System.Windows.Forms.DataGridViewButtonColumn cell_startCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_countingTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_leftTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_enable;
        private System.Windows.Forms.DataGridViewButtonColumn cell_delete;
    }
}

