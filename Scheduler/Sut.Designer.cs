﻿namespace Scheduler
{
    partial class Sut
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
            this.calSut = new System.Windows.Forms.Button();
            this.editSut = new System.Windows.Forms.Button();
            this.refreshSut = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveSut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1382, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suturday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calSut
            // 
            this.calSut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calSut.FlatAppearance.BorderSize = 0;
            this.calSut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calSut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.calSut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calSut.Image = global::Scheduler.Properties.Resources.icons8_calendar_32;
            this.calSut.Location = new System.Drawing.Point(83, 72);
            this.calSut.Name = "calSut";
            this.calSut.Size = new System.Drawing.Size(32, 32);
            this.calSut.TabIndex = 9;
            this.calSut.UseVisualStyleBackColor = true;
            // 
            // editSut
            // 
            this.editSut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editSut.FlatAppearance.BorderSize = 0;
            this.editSut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editSut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editSut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSut.Image = global::Scheduler.Properties.Resources.icons8_edit_32;
            this.editSut.Location = new System.Drawing.Point(127, 72);
            this.editSut.Name = "editSut";
            this.editSut.Size = new System.Drawing.Size(33, 32);
            this.editSut.TabIndex = 8;
            this.editSut.UseVisualStyleBackColor = true;
            this.editSut.Click += new System.EventHandler(this.editSut_Click);
            // 
            // refreshSut
            // 
            this.refreshSut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshSut.FlatAppearance.BorderSize = 0;
            this.refreshSut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.refreshSut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshSut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshSut.Image = global::Scheduler.Properties.Resources.icons8_refresh_32;
            this.refreshSut.Location = new System.Drawing.Point(170, 72);
            this.refreshSut.Name = "refreshSut";
            this.refreshSut.Size = new System.Drawing.Size(32, 32);
            this.refreshSut.TabIndex = 7;
            this.refreshSut.UseVisualStyleBackColor = true;
            this.refreshSut.Click += new System.EventHandler(this.refreshSut_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToResizeColumns = false;
            this.dataGridView6.AllowUserToResizeRows = false;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.todo});
            this.dataGridView6.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView6.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView6.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView6.Enabled = false;
            this.dataGridView6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView6.Location = new System.Drawing.Point(83, 110);
            this.dataGridView6.Name = "dataGridView6";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView6.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridView6.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView6.RowTemplate.Height = 30;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView6.Size = new System.Drawing.Size(1215, 490);
            this.dataGridView6.TabIndex = 6;
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
            // saveSut
            // 
            this.saveSut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveSut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveSut.Location = new System.Drawing.Point(1223, 606);
            this.saveSut.Name = "saveSut";
            this.saveSut.Size = new System.Drawing.Size(75, 30);
            this.saveSut.TabIndex = 11;
            this.saveSut.Text = "Save";
            this.saveSut.UseVisualStyleBackColor = true;
            this.saveSut.Click += new System.EventHandler(this.saveSut_Click);
            // 
            // Sut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.saveSut);
            this.Controls.Add(this.calSut);
            this.Controls.Add(this.editSut);
            this.Controls.Add(this.refreshSut);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.label1);
            this.Name = "Sut";
            this.Size = new System.Drawing.Size(1382, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calSut;
        private System.Windows.Forms.Button editSut;
        private System.Windows.Forms.Button refreshSut;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
        private System.Windows.Forms.Button saveSut;
    }
}
