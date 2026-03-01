using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAZYSHELL
{
    public class LevelEventPalettes : Form
    {
        private delegate void Function();
        private Levels levels;
        private CheckBox[] checkboxes = new CheckBox[7];
        private NumericUpDown[] numerics = new NumericUpDown[7];
        private Button[] editButtons = new Button[7];
        private PaletteEditor[] paletteEditors = new PaletteEditor[7];
        private PaletteSet[] eventPaletteSets = new PaletteSet[7];
        // Temporary backup for transient override apply/remove during rendering
        private int[][] tempReds = new int[7][];
        private int[][] tempGreens = new int[7][];
        private int[][] tempBlues = new int[7][];
        private bool overridesApplied = false;

        public LevelEventPalettes(Levels levels)
        {
            this.levels = levels;
            this.FormBorderStyle = FormBorderStyle.None;
            this.AutoScroll = true;
            this.Width = 220;
            BuildUI();
        }

        private void BuildUI()
        {
            int y = 8;
            for (int i = 0; i < 7; i++)
            {
                int row = i; // capture for closures

                Label label = new Label();
                label.Text = "Row " + (row + 1);
                label.AutoSize = true;
                label.Location = new Point(4, y + 3);
                this.Controls.Add(label);

                checkboxes[row] = new CheckBox();
                checkboxes[row].Location = new Point(50, y + 1);
                checkboxes[row].AutoSize = true;
                checkboxes[row].CheckedChanged += (s, e) => checkbox_CheckedChanged(row);
                this.Controls.Add(checkboxes[row]);

                numerics[row] = new NumericUpDown();
                numerics[row].Minimum = 0;
                numerics[row].Maximum = 255;
                numerics[row].Location = new Point(70, y);
                numerics[row].Size = new Size(55, 20);
                numerics[row].ValueChanged += (s, e) => numeric_ValueChanged(row);
                this.Controls.Add(numerics[row]);

                editButtons[row] = new Button();
                editButtons[row].Text = "Edit";
                editButtons[row].Location = new Point(130, y - 1);
                editButtons[row].Size = new Size(40, 23);
                editButtons[row].Click += (s, e) => editButton_Click(row);
                this.Controls.Add(editButtons[row]);

                y += 28;
            }
        }

        private PaletteSet CreateEventPaletteSet(int number)
        {
            return new PaletteSet(Model.ROM, number, 0x379FFE + number * 30, 1, 16, 30);
        }

        /// <summary>
        /// Temporarily applies event palette overrides into the level PaletteSet for rendering.
        /// Must be followed by RemoveOverridesAfterRendering() to restore originals.
        /// </summary>
        public void ApplyOverridesForRendering()
        {
            if (overridesApplied) return;
            PaletteSet ps = levels.PaletteSet;
            for (int i = 0; i < 7; i++)
            {
                if (checkboxes[i].Checked && eventPaletteSets[i] != null)
                {
                    int paletteRow = i + 1;
                    tempReds[i] = new int[16];
                    tempGreens[i] = new int[16];
                    tempBlues[i] = new int[16];
                    for (int j = 0; j < 16; j++)
                    {
                        tempReds[i][j] = ps.Reds[paletteRow * 16 + j];
                        tempGreens[i][j] = ps.Greens[paletteRow * 16 + j];
                        tempBlues[i][j] = ps.Blues[paletteRow * 16 + j];
                        ps.Reds[paletteRow * 16 + j] = eventPaletteSets[i].Reds[j];
                        ps.Greens[paletteRow * 16 + j] = eventPaletteSets[i].Greens[j];
                        ps.Blues[paletteRow * 16 + j] = eventPaletteSets[i].Blues[j];
                    }
                }
            }
            overridesApplied = true;
        }

        /// <summary>
        /// Removes transient overrides, restoring the original level palette values.
        /// </summary>
        public void RemoveOverridesAfterRendering()
        {
            if (!overridesApplied) return;
            PaletteSet ps = levels.PaletteSet;
            for (int i = 0; i < 7; i++)
            {
                if (tempReds[i] != null)
                {
                    int paletteRow = i + 1;
                    for (int j = 0; j < 16; j++)
                    {
                        ps.Reds[paletteRow * 16 + j] = tempReds[i][j];
                        ps.Greens[paletteRow * 16 + j] = tempGreens[i][j];
                        ps.Blues[paletteRow * 16 + j] = tempBlues[i][j];
                    }
                    tempReds[i] = null;
                    tempGreens[i] = null;
                    tempBlues[i] = null;
                }
            }
            overridesApplied = false;
        }

        private void checkbox_CheckedChanged(int row)
        {
            if (checkboxes[row].Checked && eventPaletteSets[row] == null)
                eventPaletteSets[row] = CreateEventPaletteSet((int)numerics[row].Value);
            levels.RefreshLevel();
        }

        private void numeric_ValueChanged(int row)
        {
            if (checkboxes[row].Checked)
            {
                eventPaletteSets[row] = CreateEventPaletteSet((int)numerics[row].Value);
                levels.RefreshLevel();
                if (paletteEditors[row] != null && paletteEditors[row].Visible)
                    paletteEditors[row].Reload(new Function(delegate { PaletteEditUpdate(row); }), eventPaletteSets[row], 1, 0, 1);
            }
        }

        private void editButton_Click(int row)
        {
            int id = (int)numerics[row].Value;
            if (eventPaletteSets[row] == null)
                eventPaletteSets[row] = CreateEventPaletteSet(id);
            if (paletteEditors[row] == null)
            {
                paletteEditors[row] = new PaletteEditor(new Function(delegate { PaletteEditUpdate(row); }), eventPaletteSets[row], 1, 0, 1);
                paletteEditors[row].Text = "Event Palette - Row " + (row + 1);
                paletteEditors[row].FormClosing += (s, e) =>
                {
                    e.Cancel = true;
                    ((Form)s).Hide();
                };
            }
            else
            {
                paletteEditors[row].Reload(new Function(delegate { PaletteEditUpdate(row); }), eventPaletteSets[row], 1, 0, 1);
            }
            paletteEditors[row].Show();
            paletteEditors[row].BringToFront();
        }

        private void PaletteEditUpdate(int row)
        {
            levels.RefreshLevel();
        }
    }
}
