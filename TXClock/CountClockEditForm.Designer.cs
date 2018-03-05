namespace TXClock
{
    partial class CountClockEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grv_countClock = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.cell_tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_allTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cell_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_countClock)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_countClock
            // 
            this.grv_countClock.AllowUserToAddRows = false;
            this.grv_countClock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_countClock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_countClock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_countClock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cell_tag,
            this.cell_allTime,
            this.cell_note,
            this.cell_delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_countClock.DefaultCellStyle = dataGridViewCellStyle5;
            this.grv_countClock.Location = new System.Drawing.Point(18, 12);
            this.grv_countClock.Name = "grv_countClock";
            this.grv_countClock.RowHeadersVisible = false;
            this.grv_countClock.RowTemplate.Height = 23;
            this.grv_countClock.Size = new System.Drawing.Size(304, 205);
            this.grv_countClock.TabIndex = 1;
            this.grv_countClock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_countClock_CellClick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(247, 227);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cell_tag
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_tag.DefaultCellStyle = dataGridViewCellStyle2;
            this.cell_tag.HeaderText = "标签";
            this.cell_tag.Name = "cell_tag";
            this.cell_tag.ReadOnly = true;
            this.cell_tag.Width = 70;
            // 
            // cell_allTime
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_allTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.cell_allTime.HeaderText = "时长";
            this.cell_allTime.Name = "cell_allTime";
            this.cell_allTime.ReadOnly = true;
            this.cell_allTime.Width = 70;
            // 
            // cell_note
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cell_note.DefaultCellStyle = dataGridViewCellStyle4;
            this.cell_note.HeaderText = "注释";
            this.cell_note.Name = "cell_note";
            this.cell_note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cell_note.Width = 60;
            // 
            // cell_delete
            // 
            this.cell_delete.HeaderText = "删除";
            this.cell_delete.Name = "cell_delete";
            this.cell_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CountClockEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 262);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grv_countClock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountClockEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑倒计时";
            ((System.ComponentModel.ISupportInitialize)(this.grv_countClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_countClock;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_allTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cell_note;
        private System.Windows.Forms.DataGridViewButtonColumn cell_delete;
    }
}