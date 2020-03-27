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
    public partial class Wed : UserControl
    {
        string file = "../../bins/wedbin.bin";
        public Wed()
        {
            InitializeComponent();
            fileOC(dataGridView3, 0);
        }

        private void refreshWed_Click(object sender, EventArgs e)
        {
            fileOC(dataGridView3, 0);
            editWed.Image = Scheduler.Properties.Resources.icons8_edit_32;
            dataGridView3.Enabled = false;
        }
        private void saveWed_Click(object sender, EventArgs e)
        {
            fileOC(dataGridView3, 1);
            refreshWed.PerformClick();
        }
        public void fileOC(DataGridView dgv, int oc)
        {
            if ((oc == 0) && File.Exists(file))//oc 0=open 1=create/write
            {
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
            }
            else
            {
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
            }
        }

        private void editWed_Click(object sender, EventArgs e)
        {
            if (!dataGridView3.Enabled)
            {
                dataGridView3.Enabled = true;
                editWed.Image = Scheduler.Properties.Resources.icons8_edit_32_blue;
            }
            else
            {
                dataGridView3.Enabled = false;
                editWed.Image = Scheduler.Properties.Resources.icons8_edit_32;
            }
        }
    }
}
