using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Scheduler
{
    public partial class Tue : UserControl
    {
        string file = "../../bins/tuebin.bin";
        public Tue()
        {
            InitializeComponent();
            DataGridView dgv = dataGridView2;
            if (!File.Exists(file)) using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
                {
                    bw.Write(dgv.Columns.Count);
                    bw.Write(dgv.Rows.Count);
                    foreach (DataGridViewRow dgvR in dgv.Rows)
                    {
                        for (int j = 0; j < dgv.Columns.Count; ++j)
                        {
                            object val = dgvR.Cells[j].Value;
                            if (val == null)
                            {
                                bw.Write(false);
                                bw.Write(false);
                            }
                            else
                            {
                                bw.Write(true);
                                bw.Write(val.ToString());
                            }
                        }
                    }
                }
            refreshTue.PerformClick();
        }

        private void editTue_Click(object sender, EventArgs e)
        {
            if (!dataGridView2.Enabled)
            {
                dataGridView2.Enabled = true;
                editTue.Image = Scheduler.Properties.Resources.icons8_edit_32_blue;
            }
            else
            {
                dataGridView2.Enabled = false;
                editTue.Image = Scheduler.Properties.Resources.icons8_edit_32;
            }
        }

        private void refreshTue_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView2;
            dgv.Rows.Clear();
                using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
                {
                    int n = bw.ReadInt32();
                    int m = bw.ReadInt32();
                    for (int i = 0; i < m; ++i)
                    {
                        dgv.Rows.Add();
                        for (int j = 0; j < n; ++j)
                        {
                            if (bw.ReadBoolean())
                            {
                                dgv.Rows[i].Cells[j].Value = bw.ReadString();
                            }
                            else bw.ReadBoolean();
                        }
                    }
                }
            
            editTue.Image = Scheduler.Properties.Resources.icons8_edit_32;
            dataGridView2.Enabled = false;
        }

        private void saveTue_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView2;
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dgv.Columns.Count);
                bw.Write(dgv.Rows.Count);
                foreach (DataGridViewRow dgvR in dgv.Rows)
                {
                    for (int j = 0; j < dgv.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
            refreshTue.PerformClick();
        }
    }
    
}
