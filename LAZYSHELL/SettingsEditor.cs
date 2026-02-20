using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;
using LAZYSHELL.Properties;

namespace LAZYSHELL
{
    public partial class SettingsEditor : NewForm
    {
        private Editor editor
        {
            get
            {
                if (Application.OpenForms.Count == 0)
                    return null;
                return (Editor)Application.OpenForms[0];
            }
            set
            {
                if (Application.OpenForms.Count == 0)
                    return;
                Editor main = (Editor)Application.OpenForms[0];
                main = value;
            }
        }
        private Settings settings = Settings.Default;
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private int currentLabelCategory = 0;
        private Timer gutterTimer;
        private int lastFirstVisibleLine = -1;
        // constructor
        public SettingsEditor()
        {
            InitializeComponent();
            InitializeSettings();
            // Timer to track scroll position changes for line number gutter
            gutterTimer = new Timer();
            gutterTimer.Interval = 50;
            gutterTimer.Tick += (s, ev) =>
            {
                if (textCustomLabels.IsDisposed) return;
                int firstChar = textCustomLabels.GetCharIndexFromPosition(new Point(0, 0));
                int firstLine = textCustomLabels.GetLineFromCharIndex(firstChar);
                if (firstLine != lastFirstVisibleLine)
                {
                    lastFirstVisibleLine = firstLine;
                    panelLineNumbers.Invalidate();
                }
            };
            gutterTimer.Start();
        }
        // functions
        private void InitializeSettings()
        {
            // General tab
            checkedListBox1.SetItemChecked(0, settings.LoadLastUsedROM);
            checkedListBox1.SetItemChecked(1, settings.LoadAllData);
            checkedListBox1.SetItemChecked(2, settings.LoadNotes);
            checkedListBox1.SetItemChecked(3, settings.CreateBackupROMSave);
            checkedListBox1.SetItemChecked(4, settings.CreateBackupROM);
            checkedListBox1.SetItemChecked(5, settings.UnverifiedRomWarning);
            checkedListBox1.SetItemChecked(6, settings.ShowEncryptionWarnings);
            checkedListBox1.SetItemChecked(7, settings.RememberLastIndex);
            if (settings.BackupROMDirectory == "")
            {
                romDirectory.Checked = true;
                customDirectory.Checked = false;
            }
            else
            {
                romDirectory.Checked = false;
                customDirectory.Checked = true;
                customDirectoryTextBox.Text = settings.BackupROMDirectory;
            }
            if (settings.VisualThemeSystem)
            {
                visualThemeSystem.Checked = true;
                visualThemeStandard.Checked = false;
                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
            }
            else
            {
                visualThemeSystem.Checked = false;
                visualThemeStandard.Checked = true;
                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            }

            // ROM Layout tab
            spriteGraphicsRanges.FromStringCollection(settings.SpriteGraphicsRanges);
            animationBanksRanges.FromStringCollection(settings.AnimationBanks);
            itemDescRanges.FromStringCollection(settings.ItemDescriptionRanges);
            spellDescRanges.FromStringCollection(settings.SpellDescriptionRanges);
            psychopathRanges.FromStringCollection(settings.PsychopathMessageRanges);
            textAnimPtrTable.Text = settings.AnimationPointerTable.ToString("X6");
            textPartitionStart.Text = settings.PartitionTableStart.ToString("X6");
            numPartitionCount.Value = settings.PartitionCount;
            numNPCCount.Value = settings.NPCPropertiesCount;
            numPacketCount.Value = settings.NPCPacketCount;

            // Advanced tab
            checkEnable0xCE.Checked = settings.Enable0xCE;

            // Labels tab - reload from settings without saving stale text
            currentLabelCategory = -1;
            LoadLabelCategory(0);
            comboLabelCategory.SelectedIndex = 0;
        }

        private void LoadLabelCategory(int category)
        {
            // Save current before switching (skip if no valid category loaded yet)
            if (currentLabelCategory >= 0)
                SaveCurrentLabelCategory();
            currentLabelCategory = category;
            string customText = GetCustomLabelsText(category);
            string text;
            if (string.IsNullOrEmpty(customText))
                text = GetDefaultLabelsText(category);
            else
                text = customText;
            // Normalize line endings for TextBox (\r\n required)
            text = text.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\r\n");
            textCustomLabels.Text = text;
            textCustomLabels.SelectionStart = 0;
            textCustomLabels.ScrollToCaret();
        }

        private string GetCustomLabelsText(int category)
        {
            switch (category)
            {
                case 0: return settings.CustomSpriteNames;
                case 1: return settings.CustomEventLabels;
                case 2: return settings.CustomActionLabels;
                case 3: return settings.CustomPacketNames;
                case 4: return settings.CustomEffectNames;
                case 5: return settings.CustomBattleEventNames;
                case 6: return settings.CustomLevelNames;
                case 7: return settings.CustomMusicNames;
                case 8: return settings.CustomSoundNames;
                case 9: return settings.CustomBattleSoundNames;
                case 10: return settings.CustomBattlefieldNames;
                default: return "";
            }
        }

        private string GetDefaultLabelsText(int category)
        {
            string[] labels;
            switch (category)
            {
                case 0: labels = ListsDefaults.SpriteNames; break;
                case 1: labels = ListsDefaults.EventLabels; break;
                case 2: labels = ListsDefaults.ActionLabels; break;
                case 3: labels = ListsDefaults.NPCPackets; break;
                case 4: labels = Lists.EffectNames; break;
                case 5: labels = ListsDefaults.BattleEventNames; break;
                case 6: labels = ListsDefaults.LevelNames; break;
                case 7: labels = ListsDefaults.MusicNames; break;
                case 8: labels = ListsDefaults.SoundNames; break;
                case 9: labels = ListsDefaults.BattleSoundNames; break;
                case 10: labels = ListsDefaults.BattlefieldNames; break;
                default: return "";
            }
            return string.Join("\r\n", labels);
        }

        private void SaveCurrentLabelCategory()
        {
            switch (currentLabelCategory)
            {
                case 0: settings.CustomSpriteNames = textCustomLabels.Text; break;
                case 1: settings.CustomEventLabels = textCustomLabels.Text; break;
                case 2: settings.CustomActionLabels = textCustomLabels.Text; break;
                case 3: settings.CustomPacketNames = textCustomLabels.Text; break;
                case 4: settings.CustomEffectNames = textCustomLabels.Text; break;
                case 5: settings.CustomBattleEventNames = textCustomLabels.Text; break;
                case 6: settings.CustomLevelNames = textCustomLabels.Text; break;
                case 7: settings.CustomMusicNames = textCustomLabels.Text; break;
                case 8: settings.CustomSoundNames = textCustomLabels.Text; break;
                case 9: settings.CustomBattleSoundNames = textCustomLabels.Text; break;
                case 10: settings.CustomBattlefieldNames = textCustomLabels.Text; break;
            }
        }

        // event handlers
        private void buttonCustomDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Application.StartupPath;
            folderBrowserDialog.Description = "Select directory to save backup ROMs to...";
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            customDirectoryTextBox.Text = folderBrowserDialog.SelectedPath + "\\";
        }
        private void buttonDefault_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You are about to reset the application's settings. You will lose all custom settings.\n\n" +
                "Are you sure you want to do this?", "LAZYSHELL++", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                settings.Reset();
                editor.InitializeLayout();
            }
            InitializeSettings();
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            // General tab
            settings.LoadLastUsedROM = checkedListBox1.GetItemChecked(0);
            settings.LoadAllData = checkedListBox1.GetItemChecked(1);
            settings.LoadNotes = checkedListBox1.GetItemChecked(2);
            settings.CreateBackupROMSave = checkedListBox1.GetItemChecked(3);
            settings.CreateBackupROM = checkedListBox1.GetItemChecked(4);
            settings.UnverifiedRomWarning = checkedListBox1.GetItemChecked(5);
            settings.ShowEncryptionWarnings = checkedListBox1.GetItemChecked(6);
            settings.RememberLastIndex = checkedListBox1.GetItemChecked(7);
            if (customDirectory.Checked)
                settings.BackupROMDirectory = customDirectoryTextBox.Text;
            else if (romDirectory.Checked)
                settings.BackupROMDirectory = "";
            settings.VisualThemeSystem = visualThemeSystem.Checked;

            // ROM Layout tab
            settings.SpriteGraphicsRanges = spriteGraphicsRanges.ToStringCollection();
            settings.AnimationBanks = animationBanksRanges.ToStringCollection();
            settings.ItemDescriptionRanges = itemDescRanges.ToStringCollection();
            settings.SpellDescriptionRanges = spellDescRanges.ToStringCollection();
            settings.PsychopathMessageRanges = psychopathRanges.ToStringCollection();

            int hexVal;
            if (int.TryParse(textAnimPtrTable.Text, System.Globalization.NumberStyles.HexNumber, null, out hexVal))
                settings.AnimationPointerTable = hexVal;
            if (int.TryParse(textPartitionStart.Text, System.Globalization.NumberStyles.HexNumber, null, out hexVal))
                settings.PartitionTableStart = hexVal;
            settings.PartitionCount = (int)numPartitionCount.Value;
            settings.NPCPropertiesCount = (int)numNPCCount.Value;
            settings.NPCPacketCount = (int)numPacketCount.Value;

            // Advanced tab
            settings.Enable0xCE = checkEnable0xCE.Checked;

            // Labels tab
            SaveCurrentLabelCategory();

            // Apply custom label overlays
            Lists.ApplyCustomLabelOverlays();

            // Clear caches that depend on settings
            ScriptsEditor.AnimationScript.ResetCaches();
            Model.NPCPackets = null; // Force re-creation with new NPCPacketCount on next access

            settings.Save();

            MessageBox.Show("ROM layout changes take effect on next ROM load.", "LAZYSHELL++",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            buttonApply.PerformClick();
            this.Close();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboLabelCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLabelCategory(comboLabelCategory.SelectedIndex);
        }

        private void buttonResetDefaults_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This will reset all ROM layout settings to vanilla SMRPG defaults.\n\n" +
                "Are you sure?", "LAZYSHELL++", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                RomConfig.ResetToDefaults();
                InitializeSettings();
            }
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            // Save current UI state to settings first
            buttonApply.PerformClick();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "LazyShell Config (*.lscfg)|*.lscfg|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            sfd.DefaultExt = "lscfg";
            sfd.Title = "Save ROM Layout Config";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                RomConfig.SaveConfigFile(sfd.FileName);
                MessageBox.Show("Config saved successfully.", "LAZYSHELL++", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving config: " + ex.Message, "LAZYSHELL++", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "LazyShell Config (*.lscfg)|*.lscfg|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            ofd.Title = "Load ROM Layout Config";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                RomConfig.LoadConfigFile(ofd.FileName);
                InitializeSettings();
                Lists.ApplyCustomLabelOverlays();
                ScriptsEditor.AnimationScript.ResetCaches();
                MessageBox.Show("Config loaded successfully. ROM layout changes take effect on next ROM load.",
                    "LAZYSHELL++", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading config: " + ex.Message, "LAZYSHELL++", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Line number gutter support
        private void textCustomLabels_ScrollChanged(object sender, EventArgs e)
        {
            panelLineNumbers.Invalidate();
        }

        private void panelLineNumbers_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(panelLineNumbers.BackColor);
            int lineCount = textCustomLabels.Lines != null ? textCustomLabels.Lines.Length : 0;
            if (lineCount == 0)
            {
                e.Graphics.DrawString("0000", panelLineNumbers.Font,
                    SystemBrushes.GrayText, 2, 1);
                return;
            }

            int firstCharIndex = textCustomLabels.GetCharIndexFromPosition(new Point(0, 0));
            int firstLine = textCustomLabels.GetLineFromCharIndex(firstCharIndex);
            int panelWidth = panelLineNumbers.Width;

            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Far;
                for (int i = firstLine; i < lineCount; i++)
                {
                    int charIndex = textCustomLabels.GetFirstCharIndexFromLine(i);
                    if (charIndex < 0) break;
                    Point pos = textCustomLabels.GetPositionFromCharIndex(charIndex);
                    if (pos.Y > panelLineNumbers.Height) break;
                    e.Graphics.DrawString(
                        i.ToString("D4"),
                        panelLineNumbers.Font,
                        SystemBrushes.GrayText,
                        new RectangleF(0, pos.Y, panelWidth - 4, 20),
                        sf);
                }
            }
        }
    }
}
