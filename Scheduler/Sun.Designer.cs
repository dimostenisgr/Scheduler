namespace Scheduler
{
    partial class Sun
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.calSun = new System.Windows.Forms.Button();
            this.editSun = new System.Windows.Forms.Button();
            this.refreshSun = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveSun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1382, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calSun
            // 
            this.calSun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calSun.FlatAppearance.BorderSize = 0;
            this.calSun.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calSun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.calSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calSun.Image = global::Scheduler.Properties.Resources.icons8_calendar_32;
            this.calSun.Location = new System.Drawing.Point(83, 72);
            this.calSun.Name = "calSun";
            this.calSun.Size = new System.Drawing.Size(32, 32);
            this.calSun.TabIndex = 9;
            this.calSun.UseVisualStyleBackColor = true;
            // 
            // editSun
            // 
            this.editSun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editSun.FlatAppearance.BorderSize = 0;
            this.editSun.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editSun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSun.Image = global::Scheduler.Properties.Resources.icons8_edit_32;
            this.editSun.Location = new System.Drawing.Point(127, 72);
            this.editSun.Name = "editSun";
            this.editSun.Size = new System.Drawing.Size(33, 32);
            this.editSun.TabIndex = 8;
            this.editSun.UseVisualStyleBackColor = true;
            this.editSun.Click += new System.EventHandler(this.editSun_Click);
            // 
            // refreshSun
            // 
            this.refreshSun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshSun.FlatAppearance.BorderSize = 0;
            this.refreshSun.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.refreshSun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshSun.Image = global::Scheduler.Properties.Resources.icons8_refresh_32;
            this.refreshSun.Location = new System.Drawing.Point(170, 72);
            this.refreshSun.Name = "refreshSun";
            this.refreshSun.Size = new System.Drawing.Size(32, 32);
            this.refreshSun.TabIndex = 7;
            this.refreshSun.UseVisualStyleBackColor = true;
            this.refreshSun.Click += new System.EventHandler(this.refreshSun_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToResizeColumns = false;
            this.dataGridView7.AllowUserToResizeRows = false;
            this.dataGridView7.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.todo});
            this.dataGridView7.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView7.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView7.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView7.Enabled = false;
            this.dataGridView7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView7.Location = new System.Drawing.Point(83, 110);
            this.dataGridView7.Name = "dataGridView7";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridView7.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView7.RowTemplate.Height = 30;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView7.Size = new System.Drawing.Size(1215, 490);
            this.dataGridView7.TabIndex = 6;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle12.Format = "t";
            this.Time.DefaultCellStyle = dataGridViewCellStyle12;
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
            // saveSun
            // 
            this.saveSun.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveSun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveSun.Location = new System.Drawing.Point(1223, 606);
            this.saveSun.Name = "saveSun";
            this.saveSun.Size = new System.Drawing.Size(75, 30);
            this.saveSun.TabIndex = 11;
            this.saveSun.Text = "Save";
            this.saveSun.UseVisualStyleBackColor = true;
            this.saveSun.Click += new System.EventHandler(this.saveSun_Click);
            // 
            // Sun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.saveSun);
            this.Controls.Add(this.calSun);
            this.Controls.Add(this.editSun);
            this.Controls.Add(this.refreshSun);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.label1);
            this.Name = "Sun";
            this.Size = new System.Drawing.Size(1382, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calSun;
        private System.Windows.Forms.Button editSun;
        private System.Windows.Forms.Button refreshSun;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
        private System.Windows.Forms.Button saveSun;
    }
}
