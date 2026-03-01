using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAZYSHELL
{
    public class EventPalettePreviewForm : Form
    {
        private delegate void Function();
        private NumericUpDown numericPaletteSet;
        private PaletteEditor paletteEditor;
        private PaletteSet currentPaletteSet;
        private Delegate parentUpdate;
        private Action<PaletteSet> onPaletteSetChanged;
        private Timer focusTimer;

        public PaletteSet CurrentPaletteSet { get { return currentPaletteSet; } }

        public EventPalettePreviewForm(Delegate parentUpdate, Action<PaletteSet> onPaletteSetChanged)
        {
            this.parentUpdate = parentUpdate;
            this.onPaletteSetChanged = onPaletteSetChanged;
            this.Text = "Event Palette Preview";
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(480, 470);
            // Timer for restoring focus after palette updates
            focusTimer = new Timer();
            focusTimer.Interval = 50;
            focusTimer.Tick += focusTimer_Tick;
            // Create initial palette set and editor
            currentPaletteSet = CreateEventPaletteSet(0);
            paletteEditor = new PaletteEditor(new Function(PaletteUpdate), currentPaletteSet, 1, 0, 1);
            paletteEditor.SuspendLayout();
            paletteEditor.TopLevel = false;
            paletteEditor.FormBorderStyle = FormBorderStyle.None;
            // Change all bottom-anchored controls to top-anchored before layout
            foreach (Control c in paletteEditor.Controls)
            {
                if ((c.Anchor & AnchorStyles.Bottom) != 0)
                    c.Anchor = (c.Anchor & ~AnchorStyles.Bottom) | AnchorStyles.Top;
            }
            // Set PaletteEditor to its designer client size (as a borderless control, Height = ClientHeight)
            paletteEditor.Size = new Size(480, 454);
            // Now all controls should be at their designer positions.
            // Shift all non-toolbar controls down by 24px to make room for "Palette set"
            foreach (Control c in paletteEditor.Controls)
            {
                if (c is ToolStrip)
                    continue;
                c.Location = new Point(c.Location.X, c.Location.Y + 24);
            }
            // Explicitly set positions for all formerly-bottom-anchored controls
            // (designer position + 24px shift) since the constructor repositioned them
            foreach (Control c in paletteEditor.Controls)
            {
                if (c.Name == "buttonOK") c.Location = new Point(231, 445);
                else if (c.Name == "buttonCancel") c.Location = new Point(312, 445);
                else if (c.Name == "buttonReset") c.Location = new Point(393, 445);
                else if (c.Name == "buttonSetToColor") c.Location = new Point(351, 219);
                else if (c.Name == "panel13") c.Location = new Point(432, 207);
                else if (c.Name == "panel11") c.Location = new Point(278, 249);
            }
            // When OK/Cancel call Close() on the embedded PaletteEditor, cancel it
            // (to prevent destroying the embedded editor) and close the parent form instead
            paletteEditor.FormClosing += (s, e) =>
            {
                e.Cancel = true;
                this.Close();
            };
            paletteEditor.Dock = DockStyle.Fill;
            paletteEditor.ResumeLayout(false);
            this.Controls.Add(paletteEditor);
            paletteEditor.Visible = true;
            // Add "Palette set" label and numeric right below toolbar (y=23)
            Label label = new Label();
            label.Text = "Palette set";
            label.AutoSize = true;
            label.Location = new Point(24, 27);
            paletteEditor.Controls.Add(label);
            label.BringToFront();
            numericPaletteSet = new NumericUpDown();
            numericPaletteSet.Minimum = 0;
            numericPaletteSet.Maximum = 255;
            numericPaletteSet.Location = new Point(100, 25);
            numericPaletteSet.Size = new Size(60, 20);
            numericPaletteSet.ValueChanged += numericPaletteSet_ValueChanged;
            paletteEditor.Controls.Add(numericPaletteSet);
            numericPaletteSet.BringToFront();
            // Wire up "always on top" toolbar button to control this form's TopMost
            foreach (Control c in paletteEditor.Controls)
            {
                if (c is ToolStrip ts)
                {
                    foreach (ToolStripItem item in ts.Items)
                    {
                        if (item.Name == "alwaysOnTop" && item is ToolStripButton btn)
                        {
                            btn.CheckedChanged += (s, e) => this.TopMost = btn.Checked;
                            this.TopMost = btn.Checked;
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private PaletteSet CreateEventPaletteSet(int number)
        {
            return new PaletteSet(Model.ROM, number, 0x379FFE + number * 30, 1, 16, 30);
        }

        private void numericPaletteSet_ValueChanged(object sender, EventArgs e)
        {
            // Save current palette edits to ROM buffer before switching
            currentPaletteSet.Assemble();
            currentPaletteSet = CreateEventPaletteSet((int)numericPaletteSet.Value);
            paletteEditor.Reload(new Function(PaletteUpdate), currentPaletteSet, 1, 0, 1);
            onPaletteSetChanged(currentPaletteSet);
            focusTimer.Stop();
            focusTimer.Start();
        }

        private void focusTimer_Tick(object sender, EventArgs e)
        {
            focusTimer.Stop();
            this.Activate();
            numericPaletteSet.Focus();
        }

        private void PaletteUpdate()
        {
            parentUpdate.DynamicInvoke();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && focusTimer != null)
            {
                focusTimer.Stop();
                focusTimer.Dispose();
                focusTimer = null;
            }
            base.Dispose(disposing);
        }
    }
}
