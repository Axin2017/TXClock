namespace TXClock
{
    partial class GlobalClockEditForm
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
            this.GlobalClockEdit_grv = new System.Windows.Forms.DataGridView();
            this.GlobalClockAdd_btn = new System.Windows.Forms.Button();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delele = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalClockEdit_grv)).BeginInit();
            this.SuspendLayout();
            // 
            // GlobalClockEdit_grv
            // 
            this.GlobalClockEdit_grv.AllowUserToAddRows = false;
            this.GlobalClockEdit_grv.AllowUserToDeleteRows = false;
            this.GlobalClockEdit_grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GlobalClockEdit_grv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tag,
            this.edit,
            this.delele});
            this.GlobalClockEdit_grv.Location = new System.Drawing.Point(12, 12);
            this.GlobalClockEdit_grv.Name = "GlobalClockEdit_grv";
            this.GlobalClockEdit_grv.RowHeadersVisible = false;
            this.GlobalClockEdit_grv.RowTemplate.Height = 23;
            this.GlobalClockEdit_grv.Size = new System.Drawing.Size(303, 269);
            this.GlobalClockEdit_grv.TabIndex = 0;
            this.GlobalClockEdit_grv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GlobalClockEdit_grv_CellClick);
            // 
            // GlobalClockAdd_btn
            // 
            this.GlobalClockAdd_btn.Location = new System.Drawing.Point(222, 295);
            this.GlobalClockAdd_btn.Name = "GlobalClockAdd_btn";
            this.GlobalClockAdd_btn.Size = new System.Drawing.Size(75, 23);
            this.GlobalClockAdd_btn.TabIndex = 1;
            this.GlobalClockAdd_btn.Text = "保存";
            this.GlobalClockAdd_btn.UseVisualStyleBackColor = true;
            this.GlobalClockAdd_btn.Click += new System.EventHandler(this.GlobalClockAdd_btn_Click);
            // 
            // tag
            // 
            this.tag.HeaderText = "标签";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "编辑";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // delele
            // 
            this.delele.HeaderText = "删除";
            this.delele.Name = "delele";
            // 
            // GlobalClockEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 330);
            this.Controls.Add(this.GlobalClockAdd_btn);
            this.Controls.Add(this.GlobalClockEdit_grv);
            this.Name = "GlobalClockEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑";
            ((System.ComponentModel.ISupportInitialize)(this.GlobalClockEdit_grv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GlobalClockEdit_grv;
        private System.Windows.Forms.Button GlobalClockAdd_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delele;
    }
}