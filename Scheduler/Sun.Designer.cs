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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToResizeColumns = false;
            this.dataGridView7.AllowUserToResizeRows = false;
            this.dataGridView7.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.todo});
            this.dataGridView7.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView7.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView7.Enabled = false;
            this.dataGridView7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView7.Location = new System.Drawing.Point(83, 110);
            this.dataGridView7.Name = "dataGridView7";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridView7.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView7.RowTemplate.Height = 30;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView7.Size = new System.Drawing.Size(1215, 490);
            this.dataGridView7.TabIndex = 6;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.Format = "t";
            this.Time.DefaultCellStyle = dataGridViewCellStyle2;
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
