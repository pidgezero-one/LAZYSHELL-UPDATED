
namespace LAZYSHELL
{
    partial class SettingsEditor
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
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabRomLayout = new System.Windows.Forms.TabPage();
            this.tabLabels = new System.Windows.Forms.TabPage();
            this.tabAdvanced = new System.Windows.Forms.TabPage();

            // General tab controls
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.customDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.visualThemeSystem = new System.Windows.Forms.RadioButton();
            this.visualThemeStandard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.romDirectory = new System.Windows.Forms.RadioButton();
            this.customDirectory = new System.Windows.Forms.RadioButton();
            this.buttonCustomDirectory = new System.Windows.Forms.Button();

            // Bottom buttons
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();

            // ROM Layout tab controls
            this.panelRomLayout = new System.Windows.Forms.Panel();
            this.spriteGraphicsRanges = new RangeListEditor();
            this.animationBanksRanges = new RangeListEditor();
            this.itemDescRanges = new RangeListEditor();
            this.spellDescRanges = new RangeListEditor();
            this.psychopathRanges = new RangeListEditor();
            this.labelAnimPtrTable = new System.Windows.Forms.Label();
            this.textAnimPtrTable = new System.Windows.Forms.TextBox();
            this.labelPartitionStart = new System.Windows.Forms.Label();
            this.textPartitionStart = new System.Windows.Forms.TextBox();
            this.labelPartitionCount = new System.Windows.Forms.Label();
            this.numPartitionCount = new System.Windows.Forms.NumericUpDown();
            this.labelNPCCount = new System.Windows.Forms.Label();
            this.numNPCCount = new System.Windows.Forms.NumericUpDown();
            this.labelPacketCount = new System.Windows.Forms.Label();
            this.numPacketCount = new System.Windows.Forms.NumericUpDown();

            // Labels tab controls
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboLabelCategory = new System.Windows.Forms.ComboBox();
            this.textCustomLabels = new System.Windows.Forms.TextBox();
            this.panelLineNumbers = new System.Windows.Forms.Panel();
            this.labelLabelHelp = new System.Windows.Forms.Label();

            // Advanced tab controls
            this.checkEnable0xCE = new System.Windows.Forms.CheckBox();
            this.buttonResetDefaults = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.labelConfigInfo = new System.Windows.Forms.Label();

            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabRomLayout.SuspendLayout();
            this.tabLabels.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPartitionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNPCCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketCount)).BeginInit();
            this.SuspendLayout();

            // ============ TAB CONTROL ============
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabRomLayout);
            this.tabControl.Controls.Add(this.tabLabels);
            this.tabControl.Controls.Add(this.tabAdvanced);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(714, 600);
            this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.tabControl.TabIndex = 0;

            // ============ GENERAL TAB ============
            this.tabGeneral.Text = "General";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(6);
            this.tabGeneral.Controls.Add(this.checkedListBox1);
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Controls.Add(this.groupBox2);

            // checkedListBox1
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 214;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Auto-load last used ROM",
            "Auto-create all editor data",
            "Auto-load last used Notes DB",
            "Create back-up ROM on save",
            "Create back-up ROM on load",
            "Verify ROM",
            "Show encryption warnings",
            "Remember last loaded indexes"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(454, 84);
            this.checkedListBox1.TabIndex = 0;

            // groupBox1 - Visual Theme
            this.groupBox1.Controls.Add(this.visualThemeSystem);
            this.groupBox1.Controls.Add(this.visualThemeStandard);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual Theme";

            this.visualThemeSystem.AutoSize = true;
            this.visualThemeSystem.Location = new System.Drawing.Point(6, 20);
            this.visualThemeSystem.Name = "visualThemeSystem";
            this.visualThemeSystem.Size = new System.Drawing.Size(60, 17);
            this.visualThemeSystem.TabIndex = 0;
            this.visualThemeSystem.TabStop = true;
            this.visualThemeSystem.Text = "System";
            this.visualThemeSystem.UseVisualStyleBackColor = true;

            this.visualThemeStandard.AutoSize = true;
            this.visualThemeStandard.Location = new System.Drawing.Point(6, 37);
            this.visualThemeStandard.Name = "visualThemeStandard";
            this.visualThemeStandard.Size = new System.Drawing.Size(69, 17);
            this.visualThemeStandard.TabIndex = 1;
            this.visualThemeStandard.TabStop = true;
            this.visualThemeStandard.Text = "Standard";
            this.visualThemeStandard.UseVisualStyleBackColor = true;

            // groupBox2 - Backup ROM
            this.groupBox2.Controls.Add(this.romDirectory);
            this.groupBox2.Controls.Add(this.customDirectory);
            this.groupBox2.Controls.Add(this.customDirectoryTextBox);
            this.groupBox2.Controls.Add(this.buttonCustomDirectory);
            this.groupBox2.Location = new System.Drawing.Point(105, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Back-up ROM location";

            this.romDirectory.AutoSize = true;
            this.romDirectory.Location = new System.Drawing.Point(6, 20);
            this.romDirectory.Name = "romDirectory";
            this.romDirectory.Size = new System.Drawing.Size(94, 17);
            this.romDirectory.TabIndex = 0;
            this.romDirectory.TabStop = true;
            this.romDirectory.Text = "ROM directory";
            this.romDirectory.UseVisualStyleBackColor = true;

            this.customDirectory.AutoSize = true;
            this.customDirectory.Location = new System.Drawing.Point(6, 37);
            this.customDirectory.Name = "customDirectory";
            this.customDirectory.Size = new System.Drawing.Size(111, 17);
            this.customDirectory.TabIndex = 1;
            this.customDirectory.TabStop = true;
            this.customDirectory.Text = "Custom directory:";
            this.customDirectory.UseVisualStyleBackColor = true;

            this.customDirectoryTextBox.Location = new System.Drawing.Point(123, 35);
            this.customDirectoryTextBox.Name = "customDirectoryTextBox";
            this.customDirectoryTextBox.ReadOnly = true;
            this.customDirectoryTextBox.Size = new System.Drawing.Size(199, 21);
            this.customDirectoryTextBox.TabIndex = 2;

            this.buttonCustomDirectory.Location = new System.Drawing.Point(328, 35);
            this.buttonCustomDirectory.Name = "buttonCustomDirectory";
            this.buttonCustomDirectory.Size = new System.Drawing.Size(27, 21);
            this.buttonCustomDirectory.TabIndex = 3;
            this.buttonCustomDirectory.Text = "...";
            this.buttonCustomDirectory.UseVisualStyleBackColor = true;
            this.buttonCustomDirectory.Click += new System.EventHandler(this.buttonCustomDirectory_Click);

            // ============ ROM LAYOUT TAB ============
            this.tabRomLayout.Text = "ROM Layout";
            this.tabRomLayout.AutoScroll = true;
            this.tabRomLayout.Padding = new System.Windows.Forms.Padding(6);

            // Sprite Graphics Ranges
            this.spriteGraphicsRanges.Title = "Sprite Graphics Ranges";
            this.spriteGraphicsRanges.Location = new System.Drawing.Point(6, 6);
            this.spriteGraphicsRanges.Size = new System.Drawing.Size(240, 130);

            // Animation Banks
            this.animationBanksRanges.Title = "Animation Properties";
            this.animationBanksRanges.Location = new System.Drawing.Point(252, 6);
            this.animationBanksRanges.Size = new System.Drawing.Size(240, 130);

            // Item Description Ranges
            this.itemDescRanges.Title = "Item Description Ranges (bank 3A)";
            this.itemDescRanges.Location = new System.Drawing.Point(6, 142);
            this.itemDescRanges.Size = new System.Drawing.Size(240, 130);

            // Spell Description Ranges
            this.spellDescRanges.Title = "Spell Description Ranges (bank 3A)";
            this.spellDescRanges.Location = new System.Drawing.Point(252, 142);
            this.spellDescRanges.Size = new System.Drawing.Size(240, 130);

            // Psychopath Message Ranges
            this.psychopathRanges.Title = "Psychopath Message Ranges (bank 3A)";
            this.psychopathRanges.Location = new System.Drawing.Point(498, 142);
            this.psychopathRanges.Size = new System.Drawing.Size(200, 130);

            // Scalar fields - each on its own row, label inline with control
            this.labelAnimPtrTable.Text = "Anim. Pointer Table:";
            this.labelAnimPtrTable.Location = new System.Drawing.Point(498, 9);
            this.labelAnimPtrTable.AutoSize = true;

            this.textAnimPtrTable.Location = new System.Drawing.Point(628, 6);
            this.textAnimPtrTable.Size = new System.Drawing.Size(70, 21);

            this.labelPartitionStart.Text = "Partition Table Start:";
            this.labelPartitionStart.Location = new System.Drawing.Point(498, 35);
            this.labelPartitionStart.AutoSize = true;

            this.textPartitionStart.Location = new System.Drawing.Point(628, 32);
            this.textPartitionStart.Size = new System.Drawing.Size(70, 21);

            this.labelPartitionCount.Text = "Partition Count:";
            this.labelPartitionCount.Location = new System.Drawing.Point(498, 61);
            this.labelPartitionCount.AutoSize = true;

            this.numPartitionCount.Location = new System.Drawing.Point(628, 58);
            this.numPartitionCount.Size = new System.Drawing.Size(70, 21);
            this.numPartitionCount.Minimum = 1;
            this.numPartitionCount.Maximum = 65535;

            this.labelNPCCount.Text = "NPC Properties Count:";
            this.labelNPCCount.Location = new System.Drawing.Point(498, 87);
            this.labelNPCCount.AutoSize = true;

            this.numNPCCount.Location = new System.Drawing.Point(628, 84);
            this.numNPCCount.Size = new System.Drawing.Size(70, 21);
            this.numNPCCount.Minimum = 1;
            this.numNPCCount.Maximum = 65535;

            this.labelPacketCount.Text = "NPC Packet Count:";
            this.labelPacketCount.Location = new System.Drawing.Point(498, 113);
            this.labelPacketCount.AutoSize = true;

            this.numPacketCount.Location = new System.Drawing.Point(628, 110);
            this.numPacketCount.Size = new System.Drawing.Size(70, 21);
            this.numPacketCount.Minimum = 1;
            this.numPacketCount.Maximum = 65535;

            this.tabRomLayout.Controls.Add(this.spriteGraphicsRanges);
            this.tabRomLayout.Controls.Add(this.animationBanksRanges);
            this.tabRomLayout.Controls.Add(this.itemDescRanges);
            this.tabRomLayout.Controls.Add(this.spellDescRanges);
            this.tabRomLayout.Controls.Add(this.psychopathRanges);
            this.tabRomLayout.Controls.Add(this.labelAnimPtrTable);
            this.tabRomLayout.Controls.Add(this.textAnimPtrTable);
            this.tabRomLayout.Controls.Add(this.labelPartitionStart);
            this.tabRomLayout.Controls.Add(this.textPartitionStart);
            this.tabRomLayout.Controls.Add(this.labelPartitionCount);
            this.tabRomLayout.Controls.Add(this.numPartitionCount);
            this.tabRomLayout.Controls.Add(this.labelNPCCount);
            this.tabRomLayout.Controls.Add(this.numNPCCount);
            this.tabRomLayout.Controls.Add(this.labelPacketCount);
            this.tabRomLayout.Controls.Add(this.numPacketCount);

            // ============ LABELS TAB ============
            this.tabLabels.Text = "Labels";
            this.tabLabels.Padding = new System.Windows.Forms.Padding(6);

            // Header panel (docked Top) - category dropdown + help text
            this.panelLabelsHeader = new System.Windows.Forms.Panel();
            this.panelLabelsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabelsHeader.Height = 48;

            this.labelCategory.Text = "Category:";
            this.labelCategory.Location = new System.Drawing.Point(0, 4);
            this.labelCategory.AutoSize = true;

            this.comboLabelCategory.Location = new System.Drawing.Point(64, 1);
            this.comboLabelCategory.Size = new System.Drawing.Size(200, 21);
            this.comboLabelCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLabelCategory.Items.AddRange(new object[] {
                "Sprite Names",
                "Event Script Labels",
                "Action Script Labels",
                "NPC Packet Names",
                "Effects",
                "Battle Event Names",
                "Levels",
                "Music",
                "Overworld Sound Effects",
                "Battle Sound Effects",
                "Battlefields"
            });
            this.comboLabelCategory.SelectedIndex = 0;
            this.comboLabelCategory.SelectedIndexChanged += new System.EventHandler(this.comboLabelCategory_SelectedIndexChanged);

            this.labelLabelHelp.Text = "One label per line. Line number = entry index. Empty lines keep defaults.";
            this.labelLabelHelp.Location = new System.Drawing.Point(0, 26);
            this.labelLabelHelp.AutoSize = true;
            this.labelLabelHelp.ForeColor = System.Drawing.SystemColors.GrayText;

            this.panelLabelsHeader.Controls.Add(this.labelLabelHelp);
            this.panelLabelsHeader.Controls.Add(this.comboLabelCategory);
            this.panelLabelsHeader.Controls.Add(this.labelCategory);

            // Line number gutter panel (docked Left in body)
            this.panelLineNumbers.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLineNumbers.Width = 50;
            this.panelLineNumbers.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelLineNumbers.Font = new System.Drawing.Font("Consolas", 9F);
            this.panelLineNumbers.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLineNumbers_Paint);

            // Text box (docked Fill in body)
            this.textCustomLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCustomLabels.Multiline = true;
            this.textCustomLabels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCustomLabels.AcceptsReturn = true;
            this.textCustomLabels.WordWrap = false;
            this.textCustomLabels.Font = new System.Drawing.Font("Consolas", 9F);
            this.textCustomLabels.MaxLength = 0;
            this.textCustomLabels.TextChanged += new System.EventHandler(this.textCustomLabels_ScrollChanged);
            this.textCustomLabels.Resize += new System.EventHandler(this.textCustomLabels_ScrollChanged);

            // Body panel (docked Fill in tab) - contains gutter + text
            this.panelLabelsBody = new System.Windows.Forms.Panel();
            this.panelLabelsBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLabelsBody.Controls.Add(this.textCustomLabels);
            this.panelLabelsBody.Controls.Add(this.panelLineNumbers);

            // Add to tab: body first (Fill), then header (Top)
            this.tabLabels.Controls.Add(this.panelLabelsBody);
            this.tabLabels.Controls.Add(this.panelLabelsHeader);

            // ============ ADVANCED TAB ============
            this.tabAdvanced.Text = "Advanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(6);

            this.checkEnable0xCE.Text = "Enable 0xCE event script opcode (only if your ROM uses Abyssonym's Learn Special Ability patch that SMRPG Randomizer uses)";
            this.checkEnable0xCE.Location = new System.Drawing.Point(12, 12);
            this.checkEnable0xCE.AutoSize = true;

            this.buttonResetDefaults.Text = "Reset ROM Layout to Vanilla Defaults";
            this.buttonResetDefaults.Location = new System.Drawing.Point(12, 45);
            this.buttonResetDefaults.Size = new System.Drawing.Size(230, 28);
            this.buttonResetDefaults.Click += new System.EventHandler(this.buttonResetDefaults_Click);

            this.labelConfigInfo.Text = "Save/Load ROM layout configuration to share with other romhackers:";
            this.labelConfigInfo.Location = new System.Drawing.Point(12, 85);
            this.labelConfigInfo.AutoSize = true;

            this.buttonSaveConfig.Text = "Save Config File...";
            this.buttonSaveConfig.Location = new System.Drawing.Point(12, 108);
            this.buttonSaveConfig.Size = new System.Drawing.Size(140, 28);
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);

            this.buttonLoadConfig.Text = "Load Config File...";
            this.buttonLoadConfig.Location = new System.Drawing.Point(160, 108);
            this.buttonLoadConfig.Size = new System.Drawing.Size(140, 28);
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);

            this.tabAdvanced.Controls.Add(this.checkEnable0xCE);
            this.tabAdvanced.Controls.Add(this.buttonResetDefaults);
            this.tabAdvanced.Controls.Add(this.labelConfigInfo);
            this.tabAdvanced.Controls.Add(this.buttonSaveConfig);
            this.tabAdvanced.Controls.Add(this.buttonLoadConfig);

            // ============ BOTTOM BUTTONS ============
            this.buttonDefault.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.buttonDefault.Location = new System.Drawing.Point(12, 610);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 7;
            this.buttonDefault.Text = "Default...";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);

            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.buttonOK.Location = new System.Drawing.Point(473, 610);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);

            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.buttonClose.Location = new System.Drawing.Point(554, 610);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);

            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.buttonApply.Location = new System.Drawing.Point(635, 610);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);

            // ============ FORM ============
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 645);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonDefault);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::LAZYSHELL.Properties.Resources.LAZYSHELL_icon;
            this.Name = "SettingsEditor";
            this.Text = "Settings - LAZYSHELL++";

            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabRomLayout.ResumeLayout(false);
            this.tabRomLayout.PerformLayout();
            this.tabLabels.ResumeLayout(false);
            this.tabLabels.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.tabAdvanced.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPartitionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNPCCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacketCount)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        // General tab
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabRomLayout;
        private System.Windows.Forms.TabPage tabLabels;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox customDirectoryTextBox;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.RadioButton visualThemeSystem;
        private System.Windows.Forms.RadioButton visualThemeStandard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton romDirectory;
        private System.Windows.Forms.RadioButton customDirectory;
        private System.Windows.Forms.Button buttonCustomDirectory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOK;

        // ROM Layout tab
        private System.Windows.Forms.Panel panelRomLayout;
        private RangeListEditor spriteGraphicsRanges;
        private RangeListEditor animationBanksRanges;
        private RangeListEditor itemDescRanges;
        private RangeListEditor spellDescRanges;
        private RangeListEditor psychopathRanges;
        private System.Windows.Forms.Label labelAnimPtrTable;
        private System.Windows.Forms.TextBox textAnimPtrTable;
        private System.Windows.Forms.Label labelPartitionStart;
        private System.Windows.Forms.TextBox textPartitionStart;
        private System.Windows.Forms.Label labelPartitionCount;
        private System.Windows.Forms.NumericUpDown numPartitionCount;
        private System.Windows.Forms.Label labelNPCCount;
        private System.Windows.Forms.NumericUpDown numNPCCount;
        private System.Windows.Forms.Label labelPacketCount;
        private System.Windows.Forms.NumericUpDown numPacketCount;

        // Labels tab
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboLabelCategory;
        private System.Windows.Forms.TextBox textCustomLabels;
        private System.Windows.Forms.Panel panelLineNumbers;
        private System.Windows.Forms.Label labelLabelHelp;
        private System.Windows.Forms.Panel panelLabelsHeader;
        private System.Windows.Forms.Panel panelLabelsBody;

        // Advanced tab
        private System.Windows.Forms.CheckBox checkEnable0xCE;
        private System.Windows.Forms.Button buttonResetDefaults;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.Label labelConfigInfo;
    }
}
