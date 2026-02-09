using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LAZYSHELL
{
    public class RangeListEditor : UserControl
    {
        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonRemove;
        private Label labelTitle;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }

        public RangeListEditor()
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.SuspendLayout();

            labelTitle = new Label();
            labelTitle.Text = "Ranges";
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Height = 18;
            labelTitle.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);

            dataGridView = new DataGridView();
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ScrollBars = ScrollBars.Vertical;

            DataGridViewTextBoxColumn colStart = new DataGridViewTextBoxColumn();
            colStart.Name = "Start";
            colStart.HeaderText = "Start (hex)";
            colStart.Width = 80;
            dataGridView.Columns.Add(colStart);

            DataGridViewTextBoxColumn colEnd = new DataGridViewTextBoxColumn();
            colEnd.Name = "End";
            colEnd.HeaderText = "End (hex)";
            colEnd.Width = 80;
            dataGridView.Columns.Add(colEnd);

            DataGridViewTextBoxColumn colSize = new DataGridViewTextBoxColumn();
            colSize.Name = "Size";
            colSize.HeaderText = "Size";
            colSize.Width = 60;
            colSize.ReadOnly = true;
            dataGridView.Columns.Add(colSize);

            dataGridView.CellValueChanged += DataGridView_CellValueChanged;
            dataGridView.CellValidating += DataGridView_CellValidating;

            Panel buttonPanel = new Panel();
            buttonPanel.Dock = DockStyle.Bottom;
            buttonPanel.Height = 28;

            buttonAdd = new Button();
            buttonAdd.Text = "Add";
            buttonAdd.Size = new Size(60, 23);
            buttonAdd.Location = new Point(0, 2);
            buttonAdd.Click += ButtonAdd_Click;

            buttonRemove = new Button();
            buttonRemove.Text = "Remove";
            buttonRemove.Size = new Size(60, 23);
            buttonRemove.Location = new Point(65, 2);
            buttonRemove.Click += ButtonRemove_Click;

            buttonPanel.Controls.Add(buttonAdd);
            buttonPanel.Controls.Add(buttonRemove);

            dataGridView.Dock = DockStyle.Fill;

            this.Controls.Add(dataGridView);
            this.Controls.Add(buttonPanel);
            this.Controls.Add(labelTitle);
            this.Size = new Size(240, 150);
            this.ResumeLayout(false);
        }

        public List<RomRange> GetRanges()
        {
            var list = new List<RomRange>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                try
                {
                    string startStr = row.Cells["Start"].Value?.ToString() ?? "";
                    string endStr = row.Cells["End"].Value?.ToString() ?? "";
                    if (string.IsNullOrEmpty(startStr) || string.IsNullOrEmpty(endStr)) continue;
                    int start = Convert.ToInt32(startStr, 16);
                    int end = Convert.ToInt32(endStr, 16);
                    list.Add(new RomRange(start, end));
                }
                catch { }
            }
            return list;
        }

        public void SetRanges(List<RomRange> ranges)
        {
            dataGridView.Rows.Clear();
            foreach (var r in ranges)
            {
                int idx = dataGridView.Rows.Add();
                dataGridView.Rows[idx].Cells["Start"].Value = r.Start.ToString("X6");
                dataGridView.Rows[idx].Cells["End"].Value = r.End.ToString("X6");
                dataGridView.Rows[idx].Cells["Size"].Value = r.Size.ToString();
            }
        }

        public StringCollection ToStringCollection()
        {
            return RomConfig.ToStringCollection(GetRanges());
        }

        public void FromStringCollection(StringCollection sc)
        {
            SetRanges(RomConfig.ParseRanges(sc));
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int idx = dataGridView.Rows.Add();
            dataGridView.Rows[idx].Cells["Start"].Value = "000000";
            dataGridView.Rows[idx].Cells["End"].Value = "000000";
            dataGridView.Rows[idx].Cells["Size"].Value = "0";
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && dataGridView.Rows.Count > 1)
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1) // Start or End changed
            {
                try
                {
                    string startStr = dataGridView.Rows[e.RowIndex].Cells["Start"].Value?.ToString() ?? "0";
                    string endStr = dataGridView.Rows[e.RowIndex].Cells["End"].Value?.ToString() ?? "0";
                    int start = Convert.ToInt32(startStr, 16);
                    int end = Convert.ToInt32(endStr, 16);
                    dataGridView.Rows[e.RowIndex].Cells["Size"].Value = (end - start).ToString();
                }
                catch
                {
                    dataGridView.Rows[e.RowIndex].Cells["Size"].Value = "?";
                }
            }
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2) return; // Size column is read-only
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                string val = e.FormattedValue?.ToString() ?? "";
                if (string.IsNullOrEmpty(val)) return;
                int result;
                if (!int.TryParse(val, System.Globalization.NumberStyles.HexNumber, null, out result))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a valid hexadecimal value.", "LAZYSHELL++");
                }
            }
        }
    }
}
