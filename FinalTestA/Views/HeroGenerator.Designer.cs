namespace FinalTestA.Views
{
    partial class HeroGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroGenerator));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentitySheet = new System.Windows.Forms.TabPage();
            this.AbilitiesSheet = new System.Windows.Forms.TabPage();
            this.PowerSheet = new System.Windows.Forms.TabPage();
            this.CharacterSheet = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.heroNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameDataLabel = new System.Windows.Forms.Label();
            this.lastNameDataLabel = new System.Windows.Forms.Label();
            this.generateNameButton = new System.Windows.Forms.Button();
            this.abilityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.popularityDataLabel = new System.Windows.Forms.Label();
            this.enduranceDataLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.enduranceLabel = new System.Windows.Forms.Label();
            this.psycheDataLabel = new System.Windows.Forms.Label();
            this.strengthDataLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.strengLabel = new System.Windows.Forms.Label();
            this.intuitionDataLabel = new System.Windows.Forms.Label();
            this.agilityDataLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.agilityLabel = new System.Windows.Forms.Label();
            this.reasonDataLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fightingDataLabel = new System.Windows.Forms.Label();
            this.fightingLabel = new System.Windows.Forms.Label();
            this.generateAbilityButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.IdentitySheet.SuspendLayout();
            this.AbilitiesSheet.SuspendLayout();
            this.CharacterSheet.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.abilityTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentitySheet);
            this.MainTabControl.Controls.Add(this.AbilitiesSheet);
            this.MainTabControl.Controls.Add(this.PowerSheet);
            this.MainTabControl.Controls.Add(this.CharacterSheet);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(792, 431);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentitySheet
            // 
            this.IdentitySheet.Controls.Add(this.generateNameButton);
            this.IdentitySheet.Controls.Add(this.heroNameTextBox);
            this.IdentitySheet.Controls.Add(this.lastNameLabel);
            this.IdentitySheet.Controls.Add(this.lastNameDataLabel);
            this.IdentitySheet.Controls.Add(this.firstNameDataLabel);
            this.IdentitySheet.Controls.Add(this.firstNameLabel);
            this.IdentitySheet.Controls.Add(this.label1);
            this.IdentitySheet.Location = new System.Drawing.Point(8, 39);
            this.IdentitySheet.Name = "IdentitySheet";
            this.IdentitySheet.Size = new System.Drawing.Size(1149, 384);
            this.IdentitySheet.TabIndex = 2;
            this.IdentitySheet.Text = "Identity";
            this.IdentitySheet.UseVisualStyleBackColor = true;
            // 
            // AbilitiesSheet
            // 
            this.AbilitiesSheet.Controls.Add(this.abilityTableLayoutPanel);
            this.AbilitiesSheet.Location = new System.Drawing.Point(8, 56);
            this.AbilitiesSheet.Name = "AbilitiesSheet";
            this.AbilitiesSheet.Padding = new System.Windows.Forms.Padding(3);
            this.AbilitiesSheet.Size = new System.Drawing.Size(776, 367);
            this.AbilitiesSheet.TabIndex = 0;
            this.AbilitiesSheet.Text = "Abilities";
            this.AbilitiesSheet.UseVisualStyleBackColor = true;
            // 
            // PowerSheet
            // 
            this.PowerSheet.Location = new System.Drawing.Point(8, 56);
            this.PowerSheet.Name = "PowerSheet";
            this.PowerSheet.Padding = new System.Windows.Forms.Padding(3);
            this.PowerSheet.Size = new System.Drawing.Size(734, 367);
            this.PowerSheet.TabIndex = 1;
            this.PowerSheet.Text = "Powers";
            this.PowerSheet.UseVisualStyleBackColor = true;
            // 
            // CharacterSheet
            // 
            this.CharacterSheet.Controls.Add(this.toolStrip1);
            this.CharacterSheet.Controls.Add(this.menuStrip1);
            this.CharacterSheet.Location = new System.Drawing.Point(8, 56);
            this.CharacterSheet.Name = "CharacterSheet";
            this.CharacterSheet.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterSheet.Size = new System.Drawing.Size(734, 367);
            this.CharacterSheet.TabIndex = 3;
            this.CharacterSheet.Text = "Character Sheet";
            this.CharacterSheet.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 43);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(256, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(259, 38);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(194, 38);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(643, 473);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(110, 46);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 473);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 46);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Hero Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroNameTextBox
            // 
            this.heroNameTextBox.Location = new System.Drawing.Point(343, 16);
            this.heroNameTextBox.Name = "heroNameTextBox";
            this.heroNameTextBox.Size = new System.Drawing.Size(411, 49);
            this.heroNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(14, 89);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(323, 47);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(14, 176);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(323, 47);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameDataLabel
            // 
            this.firstNameDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.firstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameDataLabel.Location = new System.Drawing.Point(343, 89);
            this.firstNameDataLabel.Name = "firstNameDataLabel";
            this.firstNameDataLabel.Size = new System.Drawing.Size(412, 47);
            this.firstNameDataLabel.TabIndex = 0;
            this.firstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameDataLabel
            // 
            this.lastNameDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameDataLabel.Location = new System.Drawing.Point(343, 176);
            this.lastNameDataLabel.Name = "lastNameDataLabel";
            this.lastNameDataLabel.Size = new System.Drawing.Size(412, 47);
            this.lastNameDataLabel.TabIndex = 0;
            this.lastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateNameButton
            // 
            this.generateNameButton.Location = new System.Drawing.Point(453, 252);
            this.generateNameButton.Name = "generateNameButton";
            this.generateNameButton.Size = new System.Drawing.Size(305, 65);
            this.generateNameButton.TabIndex = 2;
            this.generateNameButton.Text = "Generate Name";
            this.generateNameButton.UseVisualStyleBackColor = true;
            // 
            // abilityTableLayoutPanel
            // 
            this.abilityTableLayoutPanel.ColumnCount = 4;
            this.abilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilityTableLayoutPanel.Controls.Add(this.label3, 2, 0);
            this.abilityTableLayoutPanel.Controls.Add(this.fightingLabel, 0, 1);
            this.abilityTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.abilityTableLayoutPanel.Controls.Add(this.agilityLabel, 0, 2);
            this.abilityTableLayoutPanel.Controls.Add(this.popularityDataLabel, 3, 4);
            this.abilityTableLayoutPanel.Controls.Add(this.strengLabel, 0, 3);
            this.abilityTableLayoutPanel.Controls.Add(this.psycheDataLabel, 3, 3);
            this.abilityTableLayoutPanel.Controls.Add(this.label14, 2, 4);
            this.abilityTableLayoutPanel.Controls.Add(this.intuitionDataLabel, 3, 2);
            this.abilityTableLayoutPanel.Controls.Add(this.enduranceDataLabel, 1, 4);
            this.abilityTableLayoutPanel.Controls.Add(this.reasonDataLabel, 3, 1);
            this.abilityTableLayoutPanel.Controls.Add(this.enduranceLabel, 0, 4);
            this.abilityTableLayoutPanel.Controls.Add(this.label12, 2, 3);
            this.abilityTableLayoutPanel.Controls.Add(this.fightingDataLabel, 1, 1);
            this.abilityTableLayoutPanel.Controls.Add(this.agilityDataLabel, 1, 2);
            this.abilityTableLayoutPanel.Controls.Add(this.label10, 2, 2);
            this.abilityTableLayoutPanel.Controls.Add(this.strengthDataLabel, 1, 3);
            this.abilityTableLayoutPanel.Controls.Add(this.label8, 2, 1);
            this.abilityTableLayoutPanel.Controls.Add(this.generateAbilityButton, 2, 6);
            this.abilityTableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.abilityTableLayoutPanel.Name = "abilityTableLayoutPanel";
            this.abilityTableLayoutPanel.RowCount = 7;
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.Size = new System.Drawing.Size(739, 358);
            this.abilityTableLayoutPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.abilityTableLayoutPanel.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(371, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 48);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mental Abilities";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.abilityTableLayoutPanel.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 48);
            this.label2.TabIndex = 29;
            this.label2.Text = "Physical Abilities";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popularityDataLabel
            // 
            this.popularityDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.popularityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popularityDataLabel.Location = new System.Drawing.Point(555, 204);
            this.popularityDataLabel.Name = "popularityDataLabel";
            this.popularityDataLabel.Size = new System.Drawing.Size(167, 47);
            this.popularityDataLabel.TabIndex = 26;
            this.popularityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enduranceDataLabel
            // 
            this.enduranceDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enduranceDataLabel.Location = new System.Drawing.Point(187, 204);
            this.enduranceDataLabel.Name = "enduranceDataLabel";
            this.enduranceDataLabel.Size = new System.Drawing.Size(167, 47);
            this.enduranceDataLabel.TabIndex = 25;
            this.enduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(371, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 47);
            this.label14.TabIndex = 28;
            this.label14.Text = "Popularity";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enduranceLabel
            // 
            this.enduranceLabel.Location = new System.Drawing.Point(3, 204);
            this.enduranceLabel.Name = "enduranceLabel";
            this.enduranceLabel.Size = new System.Drawing.Size(178, 47);
            this.enduranceLabel.TabIndex = 27;
            this.enduranceLabel.Text = "Endurance";
            this.enduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // psycheDataLabel
            // 
            this.psycheDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.psycheDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.psycheDataLabel.Location = new System.Drawing.Point(555, 153);
            this.psycheDataLabel.Name = "psycheDataLabel";
            this.psycheDataLabel.Size = new System.Drawing.Size(167, 47);
            this.psycheDataLabel.TabIndex = 21;
            this.psycheDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // strengthDataLabel
            // 
            this.strengthDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.strengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.strengthDataLabel.Location = new System.Drawing.Point(187, 153);
            this.strengthDataLabel.Name = "strengthDataLabel";
            this.strengthDataLabel.Size = new System.Drawing.Size(167, 47);
            this.strengthDataLabel.TabIndex = 22;
            this.strengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(371, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 47);
            this.label12.TabIndex = 23;
            this.label12.Text = "Psyche";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // strengLabel
            // 
            this.strengLabel.Location = new System.Drawing.Point(3, 153);
            this.strengLabel.Name = "strengLabel";
            this.strengLabel.Size = new System.Drawing.Size(178, 47);
            this.strengLabel.TabIndex = 24;
            this.strengLabel.Text = "Strength";
            this.strengLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intuitionDataLabel
            // 
            this.intuitionDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.intuitionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intuitionDataLabel.Location = new System.Drawing.Point(555, 102);
            this.intuitionDataLabel.Name = "intuitionDataLabel";
            this.intuitionDataLabel.Size = new System.Drawing.Size(167, 47);
            this.intuitionDataLabel.TabIndex = 18;
            this.intuitionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agilityDataLabel
            // 
            this.agilityDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.agilityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agilityDataLabel.Location = new System.Drawing.Point(187, 102);
            this.agilityDataLabel.Name = "agilityDataLabel";
            this.agilityDataLabel.Size = new System.Drawing.Size(167, 47);
            this.agilityDataLabel.TabIndex = 17;
            this.agilityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(371, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 47);
            this.label10.TabIndex = 20;
            this.label10.Text = "Intuition";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agilityLabel
            // 
            this.agilityLabel.Location = new System.Drawing.Point(3, 102);
            this.agilityLabel.Name = "agilityLabel";
            this.agilityLabel.Size = new System.Drawing.Size(178, 47);
            this.agilityLabel.TabIndex = 19;
            this.agilityLabel.Text = "Agility";
            this.agilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reasonDataLabel
            // 
            this.reasonDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reasonDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reasonDataLabel.Location = new System.Drawing.Point(555, 51);
            this.reasonDataLabel.Name = "reasonDataLabel";
            this.reasonDataLabel.Size = new System.Drawing.Size(167, 47);
            this.reasonDataLabel.TabIndex = 13;
            this.reasonDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(371, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 47);
            this.label8.TabIndex = 16;
            this.label8.Text = "Reason";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fightingDataLabel
            // 
            this.fightingDataLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fightingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fightingDataLabel.Location = new System.Drawing.Point(187, 51);
            this.fightingDataLabel.Name = "fightingDataLabel";
            this.fightingDataLabel.Size = new System.Drawing.Size(167, 47);
            this.fightingDataLabel.TabIndex = 14;
            this.fightingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fightingLabel
            // 
            this.fightingLabel.Location = new System.Drawing.Point(3, 51);
            this.fightingLabel.Name = "fightingLabel";
            this.fightingLabel.Size = new System.Drawing.Size(178, 47);
            this.fightingLabel.TabIndex = 15;
            this.fightingLabel.Text = "Fighting";
            this.fightingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateAbilityButton
            // 
            this.abilityTableLayoutPanel.SetColumnSpan(this.generateAbilityButton, 2);
            this.generateAbilityButton.Location = new System.Drawing.Point(371, 309);
            this.generateAbilityButton.Name = "generateAbilityButton";
            this.generateAbilityButton.Size = new System.Drawing.Size(365, 46);
            this.generateAbilityButton.TabIndex = 31;
            this.generateAbilityButton.Text = "Generate Ability";
            this.generateAbilityButton.UseVisualStyleBackColor = true;
            // 
            // HeroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.ClientSize = new System.Drawing.Size(792, 543);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HeroGenerator";
            this.Text = "Hero Generator";
            this.MainTabControl.ResumeLayout(false);
            this.IdentitySheet.ResumeLayout(false);
            this.IdentitySheet.PerformLayout();
            this.AbilitiesSheet.ResumeLayout(false);
            this.CharacterSheet.ResumeLayout(false);
            this.CharacterSheet.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.abilityTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentitySheet;
        private System.Windows.Forms.TabPage AbilitiesSheet;
        private System.Windows.Forms.TabPage PowerSheet;
        private System.Windows.Forms.TabPage CharacterSheet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button generateNameButton;
        private System.Windows.Forms.TextBox heroNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label lastNameDataLabel;
        private System.Windows.Forms.Label firstNameDataLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel abilityTableLayoutPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fightingLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label agilityLabel;
        private System.Windows.Forms.Label popularityDataLabel;
        private System.Windows.Forms.Label strengLabel;
        private System.Windows.Forms.Label psycheDataLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label intuitionDataLabel;
        private System.Windows.Forms.Label enduranceDataLabel;
        private System.Windows.Forms.Label reasonDataLabel;
        private System.Windows.Forms.Label enduranceLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label fightingDataLabel;
        private System.Windows.Forms.Label agilityDataLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label strengthDataLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button generateAbilityButton;
    }
}
