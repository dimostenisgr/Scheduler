namespace Scheduler
{
    partial class Fri
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
            this.calFri = new System.Windows.Forms.Button();
            this.editFri = new System.Windows.Forms.Button();
            this.refreshFri = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1382, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Friday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calFri
            // 
            this.calFri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calFri.FlatAppearance.BorderSize = 0;
            this.calFri.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calFri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.calFri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calFri.Image = global::Scheduler.Properties.Resources.icons8_calendar_32;
            this.calFri.Location = new System.Drawing.Point(83, 72);
            this.calFri.Name = "calFri";
            this.calFri.Size = new System.Drawing.Size(32, 32);
            this.calFri.TabIndex = 9;
            this.calFri.UseVisualStyleBackColor = true;
            // 
            // editFri
            // 
            this.editFri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editFri.FlatAppearance.BorderSize = 0;
            this.editFri.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editFri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editFri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editFri.Image = global::Scheduler.Properties.Resources.icons8_edit_32;
            this.editFri.Location = new System.Drawing.Point(127, 72);
            this.editFri.Name = "editFri";
            this.editFri.Size = new System.Drawing.Size(33, 32);
            this.editFri.TabIndex = 8;
            this.editFri.UseVisualStyleBackColor = true;
            this.editFri.Click += new System.EventHandler(this.editFri_Click);
            // 
            // refreshFri
            // 
            this.refreshFri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshFri.FlatAppearance.BorderSize = 0;
            this.refreshFri.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.refreshFri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshFri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshFri.Image = global::Scheduler.Properties.Resources.icons8_refresh_32;
            this.refreshFri.Location = new System.Drawing.Point(170, 72);
            this.refreshFri.Name = "refreshFri";
            this.refreshFri.Size = new System.Drawing.Size(32, 32);
            this.refreshFri.TabIndex = 7;
            this.refreshFri.UseVisualStyleBackColor = true;
            this.refreshFri.Click += new System.EventHandler(this.refreshFri_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.todo});
            this.dataGridView5.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView5.Enabled = false;
            this.dataGridView5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView5.Location = new System.Drawing.Point(83, 110);
            this.dataGridView5.Name = "dataGridView5";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridView5.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView5.RowTemplate.Height = 30;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView5.Size = new System.Drawing.Size(1215, 490);
            this.dataGridView5.TabIndex = 6;
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
            // saveFri
            // 
            this.saveFri.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveFri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveFri.Location = new System.Drawing.Point(1223, 606);
            this.saveFri.Name = "saveFri";
            this.saveFri.Size = new System.Drawing.Size(75, 30);
            this.saveFri.TabIndex = 11;
            this.saveFri.Text = "Save";
            this.saveFri.UseVisualStyleBackColor = true;
            this.saveFri.Click += new System.EventHandler(this.saveFri_Click);
            // 
            // Fri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.saveFri);
            this.Controls.Add(this.calFri);
            this.Controls.Add(this.editFri);
            this.Controls.Add(this.refreshFri);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label1);
            this.Name = "Fri";
            this.Size = new System.Drawing.Size(1382, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calFri;
        private System.Windows.Forms.Button editFri;
        private System.Windows.Forms.Button refreshFri;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
        private System.Windows.Forms.Button saveFri;
    }
}
