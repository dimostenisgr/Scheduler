namespace Scheduler
{
    partial class Thu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.calThu = new System.Windows.Forms.Button();
            this.editThu = new System.Windows.Forms.Button();
            this.refreshThu = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1382, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thursday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calThu
            // 
            this.calThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calThu.FlatAppearance.BorderSize = 0;
            this.calThu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.calThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calThu.Image = global::Scheduler.Properties.Resources.icons8_calendar_32;
            this.calThu.Location = new System.Drawing.Point(83, 72);
            this.calThu.Name = "calThu";
            this.calThu.Size = new System.Drawing.Size(32, 32);
            this.calThu.TabIndex = 9;
            this.calThu.UseVisualStyleBackColor = true;
            // 
            // editThu
            // 
            this.editThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editThu.FlatAppearance.BorderSize = 0;
            this.editThu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editThu.Image = global::Scheduler.Properties.Resources.icons8_edit_32;
            this.editThu.Location = new System.Drawing.Point(127, 72);
            this.editThu.Name = "editThu";
            this.editThu.Size = new System.Drawing.Size(33, 32);
            this.editThu.TabIndex = 8;
            this.editThu.UseVisualStyleBackColor = true;
            this.editThu.Click += new System.EventHandler(this.editThu_Click);
            // 
            // refreshThu
            // 
            this.refreshThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshThu.FlatAppearance.BorderSize = 0;
            this.refreshThu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.refreshThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshThu.Image = global::Scheduler.Properties.Resources.icons8_refresh_32;
            this.refreshThu.Location = new System.Drawing.Point(170, 72);
            this.refreshThu.Name = "refreshThu";
            this.refreshThu.Size = new System.Drawing.Size(32, 32);
            this.refreshThu.TabIndex = 7;
            this.refreshThu.UseVisualStyleBackColor = true;
            this.refreshThu.Click += new System.EventHandler(this.refreshThu_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.todo});
            this.dataGridView4.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView4.Enabled = false;
            this.dataGridView4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView4.Location = new System.Drawing.Point(83, 110);
            this.dataGridView4.Name = "dataGridView4";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView4.RowTemplate.Height = 30;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1215, 490);
            this.dataGridView4.TabIndex = 6;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.Format = "t";
            this.Time.DefaultCellStyle = dataGridViewCellStyle7;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ToolTipText = "This is the Time";
            this.Time.Width = 68;
            // 
            // todo
            // 
            this.todo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.todo.HeaderText = "To Do";
            this.todo.MinimumWidth = 6;
            this.todo.Name = "todo";
            // 
            // saveThu
            // 
            this.saveThu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveThu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveThu.Location = new System.Drawing.Point(1223, 606);
            this.saveThu.Name = "saveThu";
            this.saveThu.Size = new System.Drawing.Size(75, 30);
            this.saveThu.TabIndex = 11;
            this.saveThu.Text = "Save";
            this.saveThu.UseVisualStyleBackColor = true;
            this.saveThu.Click += new System.EventHandler(this.saveThu_Click);
            // 
            // Thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.saveThu);
            this.Controls.Add(this.calThu);
            this.Controls.Add(this.editThu);
            this.Controls.Add(this.refreshThu);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label1);
            this.Name = "Thu";
            this.Size = new System.Drawing.Size(1382, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calThu;
        private System.Windows.Forms.Button editThu;
        private System.Windows.Forms.Button refreshThu;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
        private System.Windows.Forms.Button saveThu;
    }
}
