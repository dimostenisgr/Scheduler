namespace Scheduler
{
    partial class Mon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveMon = new System.Windows.Forms.Button();
            this.refreshMon = new System.Windows.Forms.Button();
            this.editMon = new System.Windows.Forms.Button();
            this.calMon = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1382, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.todo});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(83, 110);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 490);
            this.dataGridView1.TabIndex = 1;
            // 
            // saveMon
            // 
            this.saveMon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveMon.Location = new System.Drawing.Point(1223, 606);
            this.saveMon.Name = "saveMon";
            this.saveMon.Size = new System.Drawing.Size(75, 30);
            this.saveMon.TabIndex = 2;
            this.saveMon.Text = "Save";
            this.saveMon.UseVisualStyleBackColor = true;
            this.saveMon.Click += new System.EventHandler(this.saveMon_Click);
            // 
            // refreshMon
            // 
            this.refreshMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshMon.FlatAppearance.BorderSize = 0;
            this.refreshMon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.refreshMon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshMon.Image = global::Scheduler.Properties.Resources.icons8_refresh_32;
            this.refreshMon.Location = new System.Drawing.Point(169, 72);
            this.refreshMon.Name = "refreshMon";
            this.refreshMon.Size = new System.Drawing.Size(32, 32);
            this.refreshMon.TabIndex = 3;
            this.refreshMon.UseVisualStyleBackColor = true;
            this.refreshMon.Click += new System.EventHandler(this.refresh_Click);
            // 
            // editMon
            // 
            this.editMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editMon.FlatAppearance.BorderSize = 0;
            this.editMon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editMon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMon.Image = global::Scheduler.Properties.Resources.icons8_edit_32;
            this.editMon.Location = new System.Drawing.Point(126, 72);
            this.editMon.Name = "editMon";
            this.editMon.Size = new System.Drawing.Size(33, 32);
            this.editMon.TabIndex = 4;
            this.editMon.UseVisualStyleBackColor = true;
            this.editMon.Click += new System.EventHandler(this.editMon_Click);
            // 
            // calMon
            // 
            this.calMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calMon.FlatAppearance.BorderSize = 0;
            this.calMon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calMon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.calMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calMon.ForeColor = System.Drawing.Color.Black;
            this.calMon.Image = global::Scheduler.Properties.Resources.icons8_calendar_32;
            this.calMon.Location = new System.Drawing.Point(83, 72);
            this.calMon.Name = "calMon";
            this.calMon.Size = new System.Drawing.Size(32, 32);
            this.calMon.TabIndex = 5;
            this.calMon.Tag = "";
            this.calMon.UseVisualStyleBackColor = true;
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
            this.Time.MaxInputLength = 5;
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
            // Mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.calMon);
            this.Controls.Add(this.editMon);
            this.Controls.Add(this.refreshMon);
            this.Controls.Add(this.saveMon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Mon";
            this.Size = new System.Drawing.Size(1382, 650);
            this.Load += new System.EventHandler(this.Mon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveMon;
        private System.Windows.Forms.Button refreshMon;
        private System.Windows.Forms.Button editMon;
        private System.Windows.Forms.Button calMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
    }
}
