namespace Scheduler
{
    partial class Tue
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
            this.calTue = new System.Windows.Forms.Button();
            this.editTue = new System.Windows.Forms.Button();
            this.refreshTue = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveTue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1382, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuesday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calTue
            // 
            this.calTue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calTue.FlatAppearance.BorderSize = 0;
            this.calTue.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calTue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.calTue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calTue.Image = global::Scheduler.Properties.Resources.icons8_calendar_32;
            this.calTue.Location = new System.Drawing.Point(83, 72);
            this.calTue.Name = "calTue";
            this.calTue.Size = new System.Drawing.Size(32, 32);
            this.calTue.TabIndex = 9;
            this.calTue.UseVisualStyleBackColor = true;
            // 
            // editTue
            // 
            this.editTue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTue.FlatAppearance.BorderSize = 0;
            this.editTue.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editTue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editTue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTue.Image = global::Scheduler.Properties.Resources.icons8_edit_32;
            this.editTue.Location = new System.Drawing.Point(127, 72);
            this.editTue.Name = "editTue";
            this.editTue.Size = new System.Drawing.Size(33, 32);
            this.editTue.TabIndex = 8;
            this.editTue.UseVisualStyleBackColor = true;
            this.editTue.Click += new System.EventHandler(this.editTue_Click);
            // 
            // refreshTue
            // 
            this.refreshTue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshTue.FlatAppearance.BorderSize = 0;
            this.refreshTue.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.refreshTue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshTue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshTue.Image = global::Scheduler.Properties.Resources.icons8_refresh_32;
            this.refreshTue.Location = new System.Drawing.Point(170, 72);
            this.refreshTue.Name = "refreshTue";
            this.refreshTue.Size = new System.Drawing.Size(32, 32);
            this.refreshTue.TabIndex = 7;
            this.refreshTue.UseVisualStyleBackColor = true;
            this.refreshTue.Click += new System.EventHandler(this.refreshTue_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.todo});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView2.Location = new System.Drawing.Point(83, 110);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1215, 490);
            this.dataGridView2.TabIndex = 6;
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
            // saveTue
            // 
            this.saveTue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveTue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveTue.Location = new System.Drawing.Point(1223, 606);
            this.saveTue.Name = "saveTue";
            this.saveTue.Size = new System.Drawing.Size(75, 30);
            this.saveTue.TabIndex = 10;
            this.saveTue.Text = "Save";
            this.saveTue.UseVisualStyleBackColor = true;
            this.saveTue.Click += new System.EventHandler(this.saveTue_Click);
            // 
            // Tue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.saveTue);
            this.Controls.Add(this.calTue);
            this.Controls.Add(this.editTue);
            this.Controls.Add(this.refreshTue);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Name = "Tue";
            this.Size = new System.Drawing.Size(1382, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calTue;
        private System.Windows.Forms.Button editTue;
        private System.Windows.Forms.Button refreshTue;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
        private System.Windows.Forms.Button saveTue;
    }
}
