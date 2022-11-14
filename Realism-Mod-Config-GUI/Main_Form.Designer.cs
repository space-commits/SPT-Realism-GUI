namespace Realism_Mod_Config_GUI
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.Realism_Ballistics = new System.Windows.Forms.TabPage();
            this.warningTextBox = new System.Windows.Forms.RichTextBox();
            this.weapGroupBox = new System.Windows.Forms.GroupBox();
            this.masteryCheck = new System.Windows.Forms.CheckBox();
            this.legacyRecoilCheck = new System.Windows.Forms.CheckBox();
            this.recoilAttOverhaulCheck = new System.Windows.Forms.CheckBox();
            this.malfChangesCheck = new System.Windows.Forms.CheckBox();
            this.armorGroupBox = new System.Windows.Forms.GroupBox();
            this.buffHelmetsCheck = new System.Windows.Forms.CheckBox();
            this.armorMousePenaltyCheck = new System.Windows.Forms.CheckBox();
            this.headgearConflictsCheck = new System.Windows.Forms.CheckBox();
            this.realismCheck = new System.Windows.Forms.CheckBox();
            this.Health_Movement = new System.Windows.Forms.TabPage();
            this.moveGroupBox = new System.Windows.Forms.GroupBox();
            this.movementChangesCheck = new System.Windows.Forms.CheckBox();
            this.fallDamageChangesCheck = new System.Windows.Forms.CheckBox();
            this.healthGroupBox = new System.Windows.Forms.GroupBox();
            this.medChangesCheck = new System.Windows.Forms.CheckBox();
            this.revertMedsCheck = new System.Windows.Forms.CheckBox();
            this.Bots = new System.Windows.Forms.TabPage();
            this.botNameGroupBox = new System.Windows.Forms.GroupBox();
            this.pmcNamesCheck = new System.Windows.Forms.CheckBox();
            this.cyrillicNamesCheck = new System.Windows.Forms.CheckBox();
            this.botDiffGroupBox = new System.Windows.Forms.GroupBox();
            this.pmcDifficultyCheck = new System.Windows.Forms.CheckBox();
            this.bossDifficultyCheck = new System.Windows.Forms.CheckBox();
            this.botHealthGroupBox = new System.Windows.Forms.GroupBox();
            this.realBossHealthCheck = new System.Windows.Forms.CheckBox();
            this.realFollowerHealthCheck = new System.Windows.Forms.CheckBox();
            this.realRRHealthCheck = new System.Windows.Forms.CheckBox();
            this.realCultistHealthCheck = new System.Windows.Forms.CheckBox();
            this.openZonesFixCheck = new System.Windows.Forms.CheckBox();
            this.increasedBotCapCheck = new System.Windows.Forms.CheckBox();
            this.botChangesCheck = new System.Windows.Forms.CheckBox();
            this.Misc = new System.Windows.Forms.TabPage();
            this.itemGroupBox = new System.Windows.Forms.GroupBox();
            this.allExaminedCheck = new System.Windows.Forms.CheckBox();
            this.removeRaidRestrictionsCheck = new System.Windows.Forms.CheckBox();
            this.tradeGroupBox = new System.Windows.Forms.GroupBox();
            this.tieredFleaCheck = new System.Windows.Forms.CheckBox();
            this.fleaConfigCheck = new System.Windows.Forms.CheckBox();
            this.traderChangesCheck = new System.Windows.Forms.CheckBox();
            this.airdropChangesCheck = new System.Windows.Forms.CheckBox();
            this.Dev_Tools = new System.Windows.Forms.TabPage();
            this.devToolsTextBox = new System.Windows.Forms.TextBox();
            this.logEverythingCheck = new System.Windows.Forms.CheckBox();
            this.noFallDamageCheck = new System.Windows.Forms.CheckBox();
            this.disableFleaBlacklistCheck = new System.Windows.Forms.CheckBox();
            this.bossSpawnsCheck = new System.Windows.Forms.CheckBox();
            this.botTypeCombo = new System.Windows.Forms.ComboBox();
            this.botTypeLabel = new System.Windows.Forms.Label();
            this.botTierLabel = new System.Windows.Forms.Label();
            this.botTierNumeric = new System.Windows.Forms.NumericUpDown();
            this.enableBotWeapsCheck = new System.Windows.Forms.CheckBox();
            this.botTestingCheck = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.revertButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.revertLabel = new System.Windows.Forms.Label();
            this.savedLabel = new System.Windows.Forms.Label();
            this.devModeCheck = new System.Windows.Forms.CheckBox();
            this.mainTabControl.SuspendLayout();
            this.Realism_Ballistics.SuspendLayout();
            this.weapGroupBox.SuspendLayout();
            this.armorGroupBox.SuspendLayout();
            this.Health_Movement.SuspendLayout();
            this.moveGroupBox.SuspendLayout();
            this.healthGroupBox.SuspendLayout();
            this.Bots.SuspendLayout();
            this.botNameGroupBox.SuspendLayout();
            this.botDiffGroupBox.SuspendLayout();
            this.botHealthGroupBox.SuspendLayout();
            this.Misc.SuspendLayout();
            this.itemGroupBox.SuspendLayout();
            this.tradeGroupBox.SuspendLayout();
            this.Dev_Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botTierNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.Realism_Ballistics);
            this.mainTabControl.Controls.Add(this.Health_Movement);
            this.mainTabControl.Controls.Add(this.Bots);
            this.mainTabControl.Controls.Add(this.Misc);
            this.mainTabControl.Controls.Add(this.Dev_Tools);
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.Location = new System.Drawing.Point(-5, -2);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1368, 712);
            this.mainTabControl.TabIndex = 0;
            // 
            // Realism_Ballistics
            // 
            this.Realism_Ballistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Realism_Ballistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Realism_Ballistics.BackgroundImage")));
            this.Realism_Ballistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Realism_Ballistics.Controls.Add(this.warningTextBox);
            this.Realism_Ballistics.Controls.Add(this.weapGroupBox);
            this.Realism_Ballistics.Controls.Add(this.armorGroupBox);
            this.Realism_Ballistics.Controls.Add(this.realismCheck);
            this.Realism_Ballistics.Location = new System.Drawing.Point(4, 24);
            this.Realism_Ballistics.Margin = new System.Windows.Forms.Padding(0);
            this.Realism_Ballistics.Name = "Realism_Ballistics";
            this.Realism_Ballistics.Padding = new System.Windows.Forms.Padding(3);
            this.Realism_Ballistics.Size = new System.Drawing.Size(1360, 684);
            this.Realism_Ballistics.TabIndex = 0;
            this.Realism_Ballistics.Text = "Realism and Ballistics";
            // 
            // warningTextBox
            // 
            this.warningTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warningTextBox.ForeColor = System.Drawing.Color.Red;
            this.warningTextBox.Location = new System.Drawing.Point(377, 272);
            this.warningTextBox.Name = "warningTextBox";
            this.warningTextBox.Size = new System.Drawing.Size(628, 225);
            this.warningTextBox.TabIndex = 11;
            this.warningTextBox.Text = "CONFIG.JSON NOT FOUND! PLEASE ENSURE ALL FILES ARE IN THE CORRECT LOCATION!\n....";
            // 
            // weapGroupBox
            // 
            this.weapGroupBox.Controls.Add(this.masteryCheck);
            this.weapGroupBox.Controls.Add(this.legacyRecoilCheck);
            this.weapGroupBox.Controls.Add(this.recoilAttOverhaulCheck);
            this.weapGroupBox.Controls.Add(this.malfChangesCheck);
            this.weapGroupBox.ForeColor = System.Drawing.Color.White;
            this.weapGroupBox.Location = new System.Drawing.Point(18, 42);
            this.weapGroupBox.Name = "weapGroupBox";
            this.weapGroupBox.Size = new System.Drawing.Size(206, 126);
            this.weapGroupBox.TabIndex = 8;
            this.weapGroupBox.TabStop = false;
            this.weapGroupBox.Text = "Weapons";
            // 
            // masteryCheck
            // 
            this.masteryCheck.AutoSize = true;
            this.masteryCheck.ForeColor = System.Drawing.Color.White;
            this.masteryCheck.Location = new System.Drawing.Point(6, 72);
            this.masteryCheck.Name = "masteryCheck";
            this.masteryCheck.Size = new System.Drawing.Size(117, 19);
            this.masteryCheck.TabIndex = 7;
            this.masteryCheck.Text = "Mastery Changes";
            this.toolTip1.SetToolTip(this.masteryCheck, resources.GetString("masteryCheck.ToolTip"));
            this.masteryCheck.UseVisualStyleBackColor = true;
            this.masteryCheck.CheckedChanged += new System.EventHandler(this.masteryCheck_CheckedChanged);
            // 
            // legacyRecoilCheck
            // 
            this.legacyRecoilCheck.AutoSize = true;
            this.legacyRecoilCheck.ForeColor = System.Drawing.Color.White;
            this.legacyRecoilCheck.Location = new System.Drawing.Point(6, 97);
            this.legacyRecoilCheck.Name = "legacyRecoilCheck";
            this.legacyRecoilCheck.Size = new System.Drawing.Size(147, 19);
            this.legacyRecoilCheck.TabIndex = 5;
            this.legacyRecoilCheck.Text = "Legacy Recoil Changes";
            this.toolTip1.SetToolTip(this.legacyRecoilCheck, "The standard recoil settings from previous versions. DO NOT USE THIS IF THE RECOI" +
        "L AND ATTACHMENT OVERHAUL IS INSTALLED AND ENABLED.\r\n");
            this.legacyRecoilCheck.UseVisualStyleBackColor = true;
            this.legacyRecoilCheck.CheckedChanged += new System.EventHandler(this.legacyRecoilCheck_CheckedChanged);
            // 
            // recoilAttOverhaulCheck
            // 
            this.recoilAttOverhaulCheck.AutoSize = true;
            this.recoilAttOverhaulCheck.Checked = true;
            this.recoilAttOverhaulCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recoilAttOverhaulCheck.ForeColor = System.Drawing.Color.White;
            this.recoilAttOverhaulCheck.Location = new System.Drawing.Point(6, 22);
            this.recoilAttOverhaulCheck.Name = "recoilAttOverhaulCheck";
            this.recoilAttOverhaulCheck.Size = new System.Drawing.Size(198, 19);
            this.recoilAttOverhaulCheck.TabIndex = 6;
            this.recoilAttOverhaulCheck.Text = "Recoil and Attachment Overhaul";
            this.toolTip1.SetToolTip(this.recoilAttOverhaulCheck, resources.GetString("recoilAttOverhaulCheck.ToolTip"));
            this.recoilAttOverhaulCheck.UseVisualStyleBackColor = true;
            // 
            // malfChangesCheck
            // 
            this.malfChangesCheck.AutoSize = true;
            this.malfChangesCheck.Checked = true;
            this.malfChangesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.malfChangesCheck.ForeColor = System.Drawing.Color.White;
            this.malfChangesCheck.Location = new System.Drawing.Point(6, 47);
            this.malfChangesCheck.Name = "malfChangesCheck";
            this.malfChangesCheck.Size = new System.Drawing.Size(140, 19);
            this.malfChangesCheck.TabIndex = 4;
            this.malfChangesCheck.Text = "Malfunction Changes";
            this.toolTip1.SetToolTip(this.malfChangesCheck, "Enables changes to malfunctions and overheating. No malfunctions will occur betwe" +
        "en 98-100 durability.\r\nSee mod page description for details.\r\n");
            this.malfChangesCheck.UseVisualStyleBackColor = true;
            this.malfChangesCheck.CheckedChanged += new System.EventHandler(this.malfChanges_CheckedChanged);
            // 
            // armorGroupBox
            // 
            this.armorGroupBox.Controls.Add(this.buffHelmetsCheck);
            this.armorGroupBox.Controls.Add(this.armorMousePenaltyCheck);
            this.armorGroupBox.Controls.Add(this.headgearConflictsCheck);
            this.armorGroupBox.ForeColor = System.Drawing.Color.White;
            this.armorGroupBox.Location = new System.Drawing.Point(18, 174);
            this.armorGroupBox.Name = "armorGroupBox";
            this.armorGroupBox.Size = new System.Drawing.Size(150, 100);
            this.armorGroupBox.TabIndex = 7;
            this.armorGroupBox.TabStop = false;
            this.armorGroupBox.Text = "Armor";
            // 
            // buffHelmetsCheck
            // 
            this.buffHelmetsCheck.AutoSize = true;
            this.buffHelmetsCheck.Checked = true;
            this.buffHelmetsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buffHelmetsCheck.ForeColor = System.Drawing.Color.White;
            this.buffHelmetsCheck.Location = new System.Drawing.Point(6, 22);
            this.buffHelmetsCheck.Name = "buffHelmetsCheck";
            this.buffHelmetsCheck.Size = new System.Drawing.Size(95, 19);
            this.buffHelmetsCheck.TabIndex = 1;
            this.buffHelmetsCheck.Text = "Buff Helmets";
            this.toolTip1.SetToolTip(this.buffHelmetsCheck, resources.GetString("buffHelmetsCheck.ToolTip"));
            this.buffHelmetsCheck.UseVisualStyleBackColor = true;
            this.buffHelmetsCheck.CheckedChanged += new System.EventHandler(this.buffHelmetsCheck_CheckedChanged);
            // 
            // armorMousePenaltyCheck
            // 
            this.armorMousePenaltyCheck.AutoSize = true;
            this.armorMousePenaltyCheck.Checked = true;
            this.armorMousePenaltyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.armorMousePenaltyCheck.ForeColor = System.Drawing.Color.White;
            this.armorMousePenaltyCheck.Location = new System.Drawing.Point(6, 47);
            this.armorMousePenaltyCheck.Name = "armorMousePenaltyCheck";
            this.armorMousePenaltyCheck.Size = new System.Drawing.Size(141, 19);
            this.armorMousePenaltyCheck.TabIndex = 2;
            this.armorMousePenaltyCheck.Text = "Armor Mouse Penalty";
            this.toolTip1.SetToolTip(this.armorMousePenaltyCheck, "Armor will reduce mouse sensitivity by % equal to their weight.\r\nIf disabled, arm" +
        "or will have no mouse sensitivity penalty.");
            this.armorMousePenaltyCheck.UseVisualStyleBackColor = true;
            this.armorMousePenaltyCheck.CheckedChanged += new System.EventHandler(this.armorMousePenaltyCheck_CheckedChanged);
            // 
            // headgearConflictsCheck
            // 
            this.headgearConflictsCheck.AutoSize = true;
            this.headgearConflictsCheck.Checked = true;
            this.headgearConflictsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.headgearConflictsCheck.ForeColor = System.Drawing.Color.White;
            this.headgearConflictsCheck.Location = new System.Drawing.Point(6, 72);
            this.headgearConflictsCheck.Name = "headgearConflictsCheck";
            this.headgearConflictsCheck.Size = new System.Drawing.Size(127, 19);
            this.headgearConflictsCheck.TabIndex = 3;
            this.headgearConflictsCheck.Text = "Headgear Conflicts";
            this.toolTip1.SetToolTip(this.headgearConflictsCheck, "Makes some masks and headgear conflict to prevent bots from looking cursed, these" +
        " are items that clip badly. If you want to look cursed too, you can disable it.");
            this.headgearConflictsCheck.UseVisualStyleBackColor = true;
            this.headgearConflictsCheck.CheckedChanged += new System.EventHandler(this.headgearConflictsCheck_CheckedChanged);
            // 
            // realismCheck
            // 
            this.realismCheck.AutoSize = true;
            this.realismCheck.Checked = true;
            this.realismCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realismCheck.ForeColor = System.Drawing.Color.White;
            this.realismCheck.Location = new System.Drawing.Point(18, 17);
            this.realismCheck.Name = "realismCheck";
            this.realismCheck.Size = new System.Drawing.Size(67, 19);
            this.realismCheck.TabIndex = 0;
            this.realismCheck.Text = "Realism";
            this.toolTip1.SetToolTip(this.realismCheck, resources.GetString("realismCheck.ToolTip"));
            this.realismCheck.UseVisualStyleBackColor = true;
            this.realismCheck.CheckedChanged += new System.EventHandler(this.realismCheck_CheckedChanged);
            // 
            // Health_Movement
            // 
            this.Health_Movement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Health_Movement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Health_Movement.BackgroundImage")));
            this.Health_Movement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Health_Movement.Controls.Add(this.moveGroupBox);
            this.Health_Movement.Controls.Add(this.healthGroupBox);
            this.Health_Movement.Location = new System.Drawing.Point(4, 24);
            this.Health_Movement.Name = "Health_Movement";
            this.Health_Movement.Padding = new System.Windows.Forms.Padding(3);
            this.Health_Movement.Size = new System.Drawing.Size(1360, 684);
            this.Health_Movement.TabIndex = 1;
            this.Health_Movement.Text = "Health & Movment";
            // 
            // moveGroupBox
            // 
            this.moveGroupBox.Controls.Add(this.movementChangesCheck);
            this.moveGroupBox.Controls.Add(this.fallDamageChangesCheck);
            this.moveGroupBox.ForeColor = System.Drawing.Color.White;
            this.moveGroupBox.Location = new System.Drawing.Point(19, 98);
            this.moveGroupBox.Name = "moveGroupBox";
            this.moveGroupBox.Size = new System.Drawing.Size(200, 75);
            this.moveGroupBox.TabIndex = 5;
            this.moveGroupBox.TabStop = false;
            this.moveGroupBox.Text = "Movement";
            // 
            // movementChangesCheck
            // 
            this.movementChangesCheck.AutoSize = true;
            this.movementChangesCheck.Checked = true;
            this.movementChangesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.movementChangesCheck.ForeColor = System.Drawing.Color.White;
            this.movementChangesCheck.Location = new System.Drawing.Point(6, 22);
            this.movementChangesCheck.Name = "movementChangesCheck";
            this.movementChangesCheck.Size = new System.Drawing.Size(133, 19);
            this.movementChangesCheck.TabIndex = 0;
            this.movementChangesCheck.Text = "Movement Changes";
            this.toolTip1.SetToolTip(this.movementChangesCheck, "Enables changes to movement speed, inertia, weight limits, and fall/jump penaltie" +
        "s.");
            this.movementChangesCheck.UseVisualStyleBackColor = true;
            this.movementChangesCheck.CheckedChanged += new System.EventHandler(this.movementChangesCheck_CheckedChanged);
            // 
            // fallDamageChangesCheck
            // 
            this.fallDamageChangesCheck.AutoSize = true;
            this.fallDamageChangesCheck.Checked = true;
            this.fallDamageChangesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fallDamageChangesCheck.ForeColor = System.Drawing.Color.White;
            this.fallDamageChangesCheck.Location = new System.Drawing.Point(6, 47);
            this.fallDamageChangesCheck.Name = "fallDamageChangesCheck";
            this.fallDamageChangesCheck.Size = new System.Drawing.Size(140, 19);
            this.fallDamageChangesCheck.TabIndex = 1;
            this.fallDamageChangesCheck.Text = "Fall Damage Changes";
            this.toolTip1.SetToolTip(this.fallDamageChangesCheck, "Enables changes that increases fall damage.");
            this.fallDamageChangesCheck.UseVisualStyleBackColor = true;
            this.fallDamageChangesCheck.CheckedChanged += new System.EventHandler(this.fallDamageChangesCheck_CheckedChanged);
            // 
            // healthGroupBox
            // 
            this.healthGroupBox.Controls.Add(this.medChangesCheck);
            this.healthGroupBox.Controls.Add(this.revertMedsCheck);
            this.healthGroupBox.ForeColor = System.Drawing.Color.White;
            this.healthGroupBox.Location = new System.Drawing.Point(19, 12);
            this.healthGroupBox.Name = "healthGroupBox";
            this.healthGroupBox.Size = new System.Drawing.Size(200, 80);
            this.healthGroupBox.TabIndex = 4;
            this.healthGroupBox.TabStop = false;
            this.healthGroupBox.Text = "Health";
            // 
            // medChangesCheck
            // 
            this.medChangesCheck.AutoSize = true;
            this.medChangesCheck.Checked = true;
            this.medChangesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.medChangesCheck.ForeColor = System.Drawing.Color.White;
            this.medChangesCheck.Location = new System.Drawing.Point(6, 22);
            this.medChangesCheck.Name = "medChangesCheck";
            this.medChangesCheck.Size = new System.Drawing.Size(99, 19);
            this.medChangesCheck.TabIndex = 2;
            this.medChangesCheck.Text = "Med Changes";
            this.toolTip1.SetToolTip(this.medChangesCheck, resources.GetString("medChangesCheck.ToolTip"));
            this.medChangesCheck.UseVisualStyleBackColor = true;
            this.medChangesCheck.CheckedChanged += new System.EventHandler(this.medChangesCheck_CheckedChanged);
            // 
            // revertMedsCheck
            // 
            this.revertMedsCheck.AutoSize = true;
            this.revertMedsCheck.ForeColor = System.Drawing.Color.White;
            this.revertMedsCheck.Location = new System.Drawing.Point(6, 47);
            this.revertMedsCheck.Name = "revertMedsCheck";
            this.revertMedsCheck.Size = new System.Drawing.Size(135, 19);
            this.revertMedsCheck.TabIndex = 3;
            this.revertMedsCheck.Text = "Revert Med Changes";
            this.toolTip1.SetToolTip(this.revertMedsCheck, "If set to enabled **AND** med changes is disabled, the meds in your inventory wil" +
        "l be restored back to their full HP resource.");
            this.revertMedsCheck.UseVisualStyleBackColor = true;
            this.revertMedsCheck.CheckedChanged += new System.EventHandler(this.revertMedsCheck_CheckedChanged);
            // 
            // Bots
            // 
            this.Bots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Bots.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bots.BackgroundImage")));
            this.Bots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bots.Controls.Add(this.botNameGroupBox);
            this.Bots.Controls.Add(this.botDiffGroupBox);
            this.Bots.Controls.Add(this.botHealthGroupBox);
            this.Bots.Controls.Add(this.openZonesFixCheck);
            this.Bots.Controls.Add(this.increasedBotCapCheck);
            this.Bots.Controls.Add(this.botChangesCheck);
            this.Bots.Location = new System.Drawing.Point(4, 24);
            this.Bots.Name = "Bots";
            this.Bots.Size = new System.Drawing.Size(1360, 684);
            this.Bots.TabIndex = 2;
            this.Bots.Text = "Bots";
            // 
            // botNameGroupBox
            // 
            this.botNameGroupBox.Controls.Add(this.pmcNamesCheck);
            this.botNameGroupBox.Controls.Add(this.cyrillicNamesCheck);
            this.botNameGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.botNameGroupBox.Location = new System.Drawing.Point(18, 303);
            this.botNameGroupBox.Name = "botNameGroupBox";
            this.botNameGroupBox.Size = new System.Drawing.Size(140, 75);
            this.botNameGroupBox.TabIndex = 16;
            this.botNameGroupBox.TabStop = false;
            this.botNameGroupBox.Text = "Bot Names";
            this.toolTip1.SetToolTip(this.botNameGroupBox, "Changes bot names to actual names from a huge list. Bear names can use Latin or C" +
        "yrillic alphabet.\r\nNames come courtesy of user Computica.");
            // 
            // pmcNamesCheck
            // 
            this.pmcNamesCheck.AutoSize = true;
            this.pmcNamesCheck.Checked = true;
            this.pmcNamesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pmcNamesCheck.ForeColor = System.Drawing.Color.White;
            this.pmcNamesCheck.Location = new System.Drawing.Point(6, 22);
            this.pmcNamesCheck.Name = "pmcNamesCheck";
            this.pmcNamesCheck.Size = new System.Drawing.Size(117, 19);
            this.pmcNamesCheck.TabIndex = 12;
            this.pmcNamesCheck.Text = "Real PMC Names";
            this.toolTip1.SetToolTip(this.pmcNamesCheck, "Changes bot names to actual names from a huge list. Bear names can use Latin or C" +
        "yrillic alphabet.");
            this.pmcNamesCheck.UseVisualStyleBackColor = true;
            this.pmcNamesCheck.CheckedChanged += new System.EventHandler(this.pmcNamesCheck_CheckedChanged);
            // 
            // cyrillicNamesCheck
            // 
            this.cyrillicNamesCheck.AutoSize = true;
            this.cyrillicNamesCheck.Checked = true;
            this.cyrillicNamesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cyrillicNamesCheck.ForeColor = System.Drawing.Color.White;
            this.cyrillicNamesCheck.Location = new System.Drawing.Point(6, 47);
            this.cyrillicNamesCheck.Name = "cyrillicNamesCheck";
            this.cyrillicNamesCheck.Size = new System.Drawing.Size(128, 19);
            this.cyrillicNamesCheck.TabIndex = 13;
            this.cyrillicNamesCheck.Text = "Cyrillic Bear Names";
            this.toolTip1.SetToolTip(this.cyrillicNamesCheck, "Changes bot names to actual names from a huge list. Bear names can use Latin or C" +
        "yrillic alphabet.");
            this.cyrillicNamesCheck.UseVisualStyleBackColor = true;
            this.cyrillicNamesCheck.CheckedChanged += new System.EventHandler(this.cyrillicNamesCheck_CheckedChanged);
            // 
            // botDiffGroupBox
            // 
            this.botDiffGroupBox.Controls.Add(this.pmcDifficultyCheck);
            this.botDiffGroupBox.Controls.Add(this.bossDifficultyCheck);
            this.botDiffGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.botDiffGroupBox.Location = new System.Drawing.Point(18, 222);
            this.botDiffGroupBox.Name = "botDiffGroupBox";
            this.botDiffGroupBox.Size = new System.Drawing.Size(140, 75);
            this.botDiffGroupBox.TabIndex = 15;
            this.botDiffGroupBox.TabStop = false;
            this.botDiffGroupBox.Text = "Bot Difficulty";
            this.toolTip1.SetToolTip(this.botDiffGroupBox, resources.GetString("botDiffGroupBox.ToolTip"));
            // 
            // pmcDifficultyCheck
            // 
            this.pmcDifficultyCheck.AutoSize = true;
            this.pmcDifficultyCheck.Checked = true;
            this.pmcDifficultyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pmcDifficultyCheck.ForeColor = System.Drawing.Color.White;
            this.pmcDifficultyCheck.Location = new System.Drawing.Point(6, 22);
            this.pmcDifficultyCheck.Name = "pmcDifficultyCheck";
            this.pmcDifficultyCheck.Size = new System.Drawing.Size(103, 19);
            this.pmcDifficultyCheck.TabIndex = 10;
            this.pmcDifficultyCheck.Text = "PMC Difficulty";
            this.toolTip1.SetToolTip(this.pmcDifficultyCheck, "PMC and Boss difficulty will be raised, if set to true.");
            this.pmcDifficultyCheck.UseVisualStyleBackColor = true;
            this.pmcDifficultyCheck.CheckedChanged += new System.EventHandler(this.pmcDifficultyCheck_CheckedChanged);
            // 
            // bossDifficultyCheck
            // 
            this.bossDifficultyCheck.AutoSize = true;
            this.bossDifficultyCheck.Checked = true;
            this.bossDifficultyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bossDifficultyCheck.ForeColor = System.Drawing.Color.White;
            this.bossDifficultyCheck.Location = new System.Drawing.Point(6, 47);
            this.bossDifficultyCheck.Name = "bossDifficultyCheck";
            this.bossDifficultyCheck.Size = new System.Drawing.Size(101, 19);
            this.bossDifficultyCheck.TabIndex = 11;
            this.bossDifficultyCheck.Text = "Boss Difficulty";
            this.toolTip1.SetToolTip(this.bossDifficultyCheck, "PMC and Boss difficulty will be raised, if set to true.");
            this.bossDifficultyCheck.UseVisualStyleBackColor = true;
            this.bossDifficultyCheck.CheckedChanged += new System.EventHandler(this.bossDifficultyCheck_CheckedChanged);
            // 
            // botHealthGroupBox
            // 
            this.botHealthGroupBox.Controls.Add(this.realBossHealthCheck);
            this.botHealthGroupBox.Controls.Add(this.realFollowerHealthCheck);
            this.botHealthGroupBox.Controls.Add(this.realRRHealthCheck);
            this.botHealthGroupBox.Controls.Add(this.realCultistHealthCheck);
            this.botHealthGroupBox.ForeColor = System.Drawing.Color.White;
            this.botHealthGroupBox.Location = new System.Drawing.Point(18, 92);
            this.botHealthGroupBox.Name = "botHealthGroupBox";
            this.botHealthGroupBox.Size = new System.Drawing.Size(200, 124);
            this.botHealthGroupBox.TabIndex = 14;
            this.botHealthGroupBox.TabStop = false;
            this.botHealthGroupBox.Text = "Bot Health";
            this.toolTip1.SetToolTip(this.botHealthGroupBox, resources.GetString("botHealthGroupBox.ToolTip"));
            // 
            // realBossHealthCheck
            // 
            this.realBossHealthCheck.AutoSize = true;
            this.realBossHealthCheck.Checked = true;
            this.realBossHealthCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realBossHealthCheck.ForeColor = System.Drawing.Color.White;
            this.realBossHealthCheck.Location = new System.Drawing.Point(6, 22);
            this.realBossHealthCheck.Name = "realBossHealthCheck";
            this.realBossHealthCheck.Size = new System.Drawing.Size(134, 19);
            this.realBossHealthCheck.TabIndex = 7;
            this.realBossHealthCheck.Text = "Realistic Boss Health";
            this.toolTip1.SetToolTip(this.realBossHealthCheck, "Bot health settings. If set to true, these bot types will have the same health as" +
        " the player. If false, they will have default EFT health pools.");
            this.realBossHealthCheck.UseVisualStyleBackColor = true;
            this.realBossHealthCheck.CheckedChanged += new System.EventHandler(this.realBossHealthCheck_CheckedChanged);
            // 
            // realFollowerHealthCheck
            // 
            this.realFollowerHealthCheck.AutoSize = true;
            this.realFollowerHealthCheck.Checked = true;
            this.realFollowerHealthCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realFollowerHealthCheck.ForeColor = System.Drawing.Color.White;
            this.realFollowerHealthCheck.Location = new System.Drawing.Point(6, 47);
            this.realFollowerHealthCheck.Name = "realFollowerHealthCheck";
            this.realFollowerHealthCheck.Size = new System.Drawing.Size(182, 19);
            this.realFollowerHealthCheck.TabIndex = 6;
            this.realFollowerHealthCheck.Text = "Realistic Boss Follower Health";
            this.toolTip1.SetToolTip(this.realFollowerHealthCheck, "Bot health settings. If set to true, these bot types will have the same health as" +
        " the player. If false, they will have default EFT health pools.");
            this.realFollowerHealthCheck.UseVisualStyleBackColor = true;
            this.realFollowerHealthCheck.CheckedChanged += new System.EventHandler(this.realFollowerHealthCheck_CheckedChanged);
            // 
            // realRRHealthCheck
            // 
            this.realRRHealthCheck.AutoSize = true;
            this.realRRHealthCheck.Checked = true;
            this.realRRHealthCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realRRHealthCheck.ForeColor = System.Drawing.Color.White;
            this.realRRHealthCheck.Location = new System.Drawing.Point(6, 72);
            this.realRRHealthCheck.Name = "realRRHealthCheck";
            this.realRRHealthCheck.Size = new System.Drawing.Size(182, 19);
            this.realRRHealthCheck.TabIndex = 8;
            this.realRRHealthCheck.Text = "Realistic Raider/Rogue Health";
            this.toolTip1.SetToolTip(this.realRRHealthCheck, "Bot health settings. If set to true, these bot types will have the same health as" +
        " the player. If false, they will have default EFT health pools.");
            this.realRRHealthCheck.UseVisualStyleBackColor = true;
            this.realRRHealthCheck.CheckedChanged += new System.EventHandler(this.realRRHealthCheck_CheckedChanged);
            // 
            // realCultistHealthCheck
            // 
            this.realCultistHealthCheck.AutoSize = true;
            this.realCultistHealthCheck.Checked = true;
            this.realCultistHealthCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realCultistHealthCheck.ForeColor = System.Drawing.Color.White;
            this.realCultistHealthCheck.Location = new System.Drawing.Point(6, 97);
            this.realCultistHealthCheck.Name = "realCultistHealthCheck";
            this.realCultistHealthCheck.Size = new System.Drawing.Size(144, 19);
            this.realCultistHealthCheck.TabIndex = 9;
            this.realCultistHealthCheck.Text = "Realistic Cultist Health";
            this.toolTip1.SetToolTip(this.realCultistHealthCheck, "Bot health settings. If set to true, these bot types will have the same health as" +
        " the player. If false, they will have default EFT health pools.");
            this.realCultistHealthCheck.UseVisualStyleBackColor = true;
            this.realCultistHealthCheck.CheckedChanged += new System.EventHandler(this.realCultistHealthCheck_CheckedChanged);
            // 
            // openZonesFixCheck
            // 
            this.openZonesFixCheck.AutoSize = true;
            this.openZonesFixCheck.Checked = true;
            this.openZonesFixCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openZonesFixCheck.ForeColor = System.Drawing.Color.White;
            this.openZonesFixCheck.Location = new System.Drawing.Point(18, 67);
            this.openZonesFixCheck.Name = "openZonesFixCheck";
            this.openZonesFixCheck.Size = new System.Drawing.Size(105, 19);
            this.openZonesFixCheck.TabIndex = 2;
            this.openZonesFixCheck.Text = "OpenZones Fix";
            this.toolTip1.SetToolTip(this.openZonesFixCheck, "OpenZones fix. Adds more zones that bots can spawn in. Credit to JustNU.\r\nThis wi" +
        "ll most likely interfere with Lua\'s Spawn Rework, leave disabled if you\'re using" +
        " that.");
            this.openZonesFixCheck.UseVisualStyleBackColor = true;
            this.openZonesFixCheck.CheckedChanged += new System.EventHandler(this.openZonesFixCheck_CheckedChanged);
            // 
            // increasedBotCapCheck
            // 
            this.increasedBotCapCheck.AutoSize = true;
            this.increasedBotCapCheck.Checked = true;
            this.increasedBotCapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.increasedBotCapCheck.ForeColor = System.Drawing.Color.White;
            this.increasedBotCapCheck.Location = new System.Drawing.Point(18, 42);
            this.increasedBotCapCheck.Name = "increasedBotCapCheck";
            this.increasedBotCapCheck.Size = new System.Drawing.Size(121, 19);
            this.increasedBotCapCheck.TabIndex = 1;
            this.increasedBotCapCheck.Text = "Increased Bot Cap";
            this.toolTip1.SetToolTip(this.increasedBotCapCheck, "Raises max bot cap on most maps.");
            this.increasedBotCapCheck.UseVisualStyleBackColor = true;
            this.increasedBotCapCheck.CheckedChanged += new System.EventHandler(this.increasedBotCapCheck_CheckedChanged);
            // 
            // botChangesCheck
            // 
            this.botChangesCheck.AutoSize = true;
            this.botChangesCheck.Checked = true;
            this.botChangesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.botChangesCheck.ForeColor = System.Drawing.Color.White;
            this.botChangesCheck.Location = new System.Drawing.Point(18, 17);
            this.botChangesCheck.Name = "botChangesCheck";
            this.botChangesCheck.Size = new System.Drawing.Size(93, 19);
            this.botChangesCheck.TabIndex = 0;
            this.botChangesCheck.Text = "Bot Changes";
            this.toolTip1.SetToolTip(this.botChangesCheck, "Enables bot tiered loadouts, randomized PMC behaviour, changes to bot loot, armor" +
        " and weapon durability, hostilitiy chance, spawn ratios, etc.");
            this.botChangesCheck.UseVisualStyleBackColor = true;
            this.botChangesCheck.CheckedChanged += new System.EventHandler(this.botChangesCheck_CheckedChanged);
            // 
            // Misc
            // 
            this.Misc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Misc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Misc.BackgroundImage")));
            this.Misc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Misc.Controls.Add(this.itemGroupBox);
            this.Misc.Controls.Add(this.tradeGroupBox);
            this.Misc.Controls.Add(this.airdropChangesCheck);
            this.Misc.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Misc.Location = new System.Drawing.Point(4, 24);
            this.Misc.Name = "Misc";
            this.Misc.Size = new System.Drawing.Size(1360, 684);
            this.Misc.TabIndex = 4;
            this.Misc.Text = "Misc.";
            // 
            // itemGroupBox
            // 
            this.itemGroupBox.Controls.Add(this.allExaminedCheck);
            this.itemGroupBox.Controls.Add(this.removeRaidRestrictionsCheck);
            this.itemGroupBox.ForeColor = System.Drawing.Color.White;
            this.itemGroupBox.Location = new System.Drawing.Point(19, 118);
            this.itemGroupBox.Name = "itemGroupBox";
            this.itemGroupBox.Size = new System.Drawing.Size(200, 78);
            this.itemGroupBox.TabIndex = 7;
            this.itemGroupBox.TabStop = false;
            this.itemGroupBox.Text = "Items";
            // 
            // allExaminedCheck
            // 
            this.allExaminedCheck.AutoSize = true;
            this.allExaminedCheck.Checked = true;
            this.allExaminedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allExaminedCheck.ForeColor = System.Drawing.Color.White;
            this.allExaminedCheck.Location = new System.Drawing.Point(6, 22);
            this.allExaminedCheck.Name = "allExaminedCheck";
            this.allExaminedCheck.Size = new System.Drawing.Size(127, 19);
            this.allExaminedCheck.TabIndex = 4;
            this.allExaminedCheck.Text = "All Items Examined";
            this.toolTip1.SetToolTip(this.allExaminedCheck, "All items will be by default examined if enabled.");
            this.allExaminedCheck.UseVisualStyleBackColor = true;
            this.allExaminedCheck.CheckedChanged += new System.EventHandler(this.allExaminedCheck_CheckedChanged);
            // 
            // removeRaidRestrictionsCheck
            // 
            this.removeRaidRestrictionsCheck.AutoSize = true;
            this.removeRaidRestrictionsCheck.Checked = true;
            this.removeRaidRestrictionsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeRaidRestrictionsCheck.ForeColor = System.Drawing.Color.White;
            this.removeRaidRestrictionsCheck.Location = new System.Drawing.Point(6, 47);
            this.removeRaidRestrictionsCheck.Name = "removeRaidRestrictionsCheck";
            this.removeRaidRestrictionsCheck.Size = new System.Drawing.Size(181, 19);
            this.removeRaidRestrictionsCheck.TabIndex = 5;
            this.removeRaidRestrictionsCheck.Text = "Removed In-Raid Restrictions";
            this.toolTip1.SetToolTip(this.removeRaidRestrictionsCheck, "Removes all in-raid item count restrictions and discard limits enabled. For examp" +
        "le, you can carry as much cash, BTC, LEDX etc. as you like in raid.");
            this.removeRaidRestrictionsCheck.UseVisualStyleBackColor = true;
            this.removeRaidRestrictionsCheck.CheckedChanged += new System.EventHandler(this.removeRaidRestrictionsCheck_CheckedChanged);
            // 
            // tradeGroupBox
            // 
            this.tradeGroupBox.Controls.Add(this.tieredFleaCheck);
            this.tradeGroupBox.Controls.Add(this.fleaConfigCheck);
            this.tradeGroupBox.Controls.Add(this.traderChangesCheck);
            this.tradeGroupBox.ForeColor = System.Drawing.Color.White;
            this.tradeGroupBox.Location = new System.Drawing.Point(19, 12);
            this.tradeGroupBox.Name = "tradeGroupBox";
            this.tradeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.tradeGroupBox.TabIndex = 6;
            this.tradeGroupBox.TabStop = false;
            this.tradeGroupBox.Text = "Trading";
            // 
            // tieredFleaCheck
            // 
            this.tieredFleaCheck.AutoSize = true;
            this.tieredFleaCheck.Checked = true;
            this.tieredFleaCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tieredFleaCheck.ForeColor = System.Drawing.Color.White;
            this.tieredFleaCheck.Location = new System.Drawing.Point(6, 22);
            this.tieredFleaCheck.Name = "tieredFleaCheck";
            this.tieredFleaCheck.Size = new System.Drawing.Size(119, 19);
            this.tieredFleaCheck.TabIndex = 0;
            this.tieredFleaCheck.Text = "Tiered Fleamarket";
            this.toolTip1.SetToolTip(this.tieredFleaCheck, resources.GetString("tieredFleaCheck.ToolTip"));
            this.tieredFleaCheck.UseVisualStyleBackColor = true;
            this.tieredFleaCheck.CheckedChanged += new System.EventHandler(this.tieredFleaCheck_CheckedChanged);
            // 
            // fleaConfigCheck
            // 
            this.fleaConfigCheck.AutoSize = true;
            this.fleaConfigCheck.Checked = true;
            this.fleaConfigCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fleaConfigCheck.ForeColor = System.Drawing.Color.White;
            this.fleaConfigCheck.Location = new System.Drawing.Point(6, 47);
            this.fleaConfigCheck.Name = "fleaConfigCheck";
            this.fleaConfigCheck.Size = new System.Drawing.Size(138, 19);
            this.fleaConfigCheck.TabIndex = 1;
            this.fleaConfigCheck.Text = "Hardcore Flea Config";
            this.toolTip1.SetToolTip(this.fleaConfigCheck, "Enables a hardcore fleamarket config. There are very few offers per item, if any " +
        "at all. Item condition and stack amount vary a lot, high prices, lower seel chan" +
        "ce and so on.");
            this.fleaConfigCheck.UseVisualStyleBackColor = true;
            this.fleaConfigCheck.CheckedChanged += new System.EventHandler(this.fleaConfigCheck_CheckedChanged);
            // 
            // traderChangesCheck
            // 
            this.traderChangesCheck.AutoSize = true;
            this.traderChangesCheck.Checked = true;
            this.traderChangesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.traderChangesCheck.ForeColor = System.Drawing.Color.White;
            this.traderChangesCheck.Location = new System.Drawing.Point(6, 72);
            this.traderChangesCheck.Name = "traderChangesCheck";
            this.traderChangesCheck.Size = new System.Drawing.Size(107, 19);
            this.traderChangesCheck.TabIndex = 2;
            this.traderChangesCheck.Text = "Trader Changes";
            this.toolTip1.SetToolTip(this.traderChangesCheck, resources.GetString("traderChangesCheck.ToolTip"));
            this.traderChangesCheck.UseVisualStyleBackColor = true;
            this.traderChangesCheck.CheckedChanged += new System.EventHandler(this.traderChangesCheck_CheckedChanged);
            // 
            // airdropChangesCheck
            // 
            this.airdropChangesCheck.AutoSize = true;
            this.airdropChangesCheck.Checked = true;
            this.airdropChangesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.airdropChangesCheck.ForeColor = System.Drawing.Color.White;
            this.airdropChangesCheck.Location = new System.Drawing.Point(19, 202);
            this.airdropChangesCheck.Name = "airdropChangesCheck";
            this.airdropChangesCheck.Size = new System.Drawing.Size(115, 19);
            this.airdropChangesCheck.TabIndex = 3;
            this.airdropChangesCheck.Text = "Airdrop Changes";
            this.toolTip1.SetToolTip(this.airdropChangesCheck, resources.GetString("airdropChangesCheck.ToolTip"));
            this.airdropChangesCheck.UseVisualStyleBackColor = true;
            this.airdropChangesCheck.CheckedChanged += new System.EventHandler(this.airdropChangesCheck_CheckedChanged);
            // 
            // Dev_Tools
            // 
            this.Dev_Tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Dev_Tools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dev_Tools.BackgroundImage")));
            this.Dev_Tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dev_Tools.Controls.Add(this.devModeCheck);
            this.Dev_Tools.Controls.Add(this.devToolsTextBox);
            this.Dev_Tools.Controls.Add(this.logEverythingCheck);
            this.Dev_Tools.Controls.Add(this.noFallDamageCheck);
            this.Dev_Tools.Controls.Add(this.disableFleaBlacklistCheck);
            this.Dev_Tools.Controls.Add(this.bossSpawnsCheck);
            this.Dev_Tools.Controls.Add(this.botTypeCombo);
            this.Dev_Tools.Controls.Add(this.botTypeLabel);
            this.Dev_Tools.Controls.Add(this.botTierLabel);
            this.Dev_Tools.Controls.Add(this.botTierNumeric);
            this.Dev_Tools.Controls.Add(this.enableBotWeapsCheck);
            this.Dev_Tools.Controls.Add(this.botTestingCheck);
            this.Dev_Tools.ForeColor = System.Drawing.Color.White;
            this.Dev_Tools.Location = new System.Drawing.Point(4, 24);
            this.Dev_Tools.Name = "Dev_Tools";
            this.Dev_Tools.Size = new System.Drawing.Size(1360, 684);
            this.Dev_Tools.TabIndex = 5;
            this.Dev_Tools.Text = "Dev Tools";
            // 
            // devToolsTextBox
            // 
            this.devToolsTextBox.Location = new System.Drawing.Point(20, 16);
            this.devToolsTextBox.Multiline = true;
            this.devToolsTextBox.Name = "devToolsTextBox";
            this.devToolsTextBox.ReadOnly = true;
            this.devToolsTextBox.Size = new System.Drawing.Size(651, 51);
            this.devToolsTextBox.TabIndex = 10;
            this.devToolsTextBox.Text = resources.GetString("devToolsTextBox.Text");
            // 
            // logEverythingCheck
            // 
            this.logEverythingCheck.AutoSize = true;
            this.logEverythingCheck.ForeColor = System.Drawing.Color.White;
            this.logEverythingCheck.Location = new System.Drawing.Point(20, 282);
            this.logEverythingCheck.Name = "logEverythingCheck";
            this.logEverythingCheck.Size = new System.Drawing.Size(105, 19);
            this.logEverythingCheck.TabIndex = 9;
            this.logEverythingCheck.Text = "Log Everything";
            this.logEverythingCheck.UseVisualStyleBackColor = true;
            this.logEverythingCheck.CheckedChanged += new System.EventHandler(this.logEverythingCheck_CheckedChanged);
            // 
            // noFallDamageCheck
            // 
            this.noFallDamageCheck.AutoSize = true;
            this.noFallDamageCheck.ForeColor = System.Drawing.Color.White;
            this.noFallDamageCheck.Location = new System.Drawing.Point(20, 232);
            this.noFallDamageCheck.Name = "noFallDamageCheck";
            this.noFallDamageCheck.Size = new System.Drawing.Size(110, 19);
            this.noFallDamageCheck.TabIndex = 8;
            this.noFallDamageCheck.Text = "No Fall Damage";
            this.noFallDamageCheck.UseVisualStyleBackColor = true;
            this.noFallDamageCheck.CheckedChanged += new System.EventHandler(this.noFallDamageCheck_CheckedChanged);
            // 
            // disableFleaBlacklistCheck
            // 
            this.disableFleaBlacklistCheck.AutoSize = true;
            this.disableFleaBlacklistCheck.ForeColor = System.Drawing.Color.White;
            this.disableFleaBlacklistCheck.Location = new System.Drawing.Point(20, 207);
            this.disableFleaBlacklistCheck.Name = "disableFleaBlacklistCheck";
            this.disableFleaBlacklistCheck.Size = new System.Drawing.Size(134, 19);
            this.disableFleaBlacklistCheck.TabIndex = 7;
            this.disableFleaBlacklistCheck.Text = "Disable Flea Blacklist";
            this.disableFleaBlacklistCheck.UseVisualStyleBackColor = true;
            this.disableFleaBlacklistCheck.CheckedChanged += new System.EventHandler(this.disableFleaBlacklistCheck_CheckedChanged);
            // 
            // bossSpawnsCheck
            // 
            this.bossSpawnsCheck.AutoSize = true;
            this.bossSpawnsCheck.ForeColor = System.Drawing.Color.White;
            this.bossSpawnsCheck.Location = new System.Drawing.Point(20, 182);
            this.bossSpawnsCheck.Name = "bossSpawnsCheck";
            this.bossSpawnsCheck.Size = new System.Drawing.Size(150, 19);
            this.bossSpawnsCheck.TabIndex = 6;
            this.bossSpawnsCheck.Text = "Guarantee Boss Spawns";
            this.bossSpawnsCheck.UseVisualStyleBackColor = true;
            this.bossSpawnsCheck.CheckedChanged += new System.EventHandler(this.bossSpawnsCheck_CheckedChanged);
            // 
            // botTypeCombo
            // 
            this.botTypeCombo.BackColor = System.Drawing.Color.White;
            this.botTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.botTypeCombo.ForeColor = System.Drawing.Color.Black;
            this.botTypeCombo.FormattingEnabled = true;
            this.botTypeCombo.Items.AddRange(new object[] {
            "All Scavs",
            "All PMCs",
            "All USEC",
            "All Bear",
            "Default"});
            this.botTypeCombo.Location = new System.Drawing.Point(78, 153);
            this.botTypeCombo.Name = "botTypeCombo";
            this.botTypeCombo.Size = new System.Drawing.Size(121, 23);
            this.botTypeCombo.TabIndex = 5;
            this.botTypeCombo.SelectedIndexChanged += new System.EventHandler(this.botTypeCombo_SelectedIndexChanged);
            // 
            // botTypeLabel
            // 
            this.botTypeLabel.AutoSize = true;
            this.botTypeLabel.ForeColor = System.Drawing.Color.White;
            this.botTypeLabel.Location = new System.Drawing.Point(20, 153);
            this.botTypeLabel.Name = "botTypeLabel";
            this.botTypeLabel.Size = new System.Drawing.Size(52, 15);
            this.botTypeLabel.TabIndex = 4;
            this.botTypeLabel.Text = "Bot Type";
            // 
            // botTierLabel
            // 
            this.botTierLabel.AutoSize = true;
            this.botTierLabel.ForeColor = System.Drawing.Color.White;
            this.botTierLabel.Location = new System.Drawing.Point(20, 129);
            this.botTierLabel.Name = "botTierLabel";
            this.botTierLabel.Size = new System.Drawing.Size(47, 15);
            this.botTierLabel.TabIndex = 3;
            this.botTierLabel.Text = "Bot Tier";
            // 
            // botTierNumeric
            // 
            this.botTierNumeric.Location = new System.Drawing.Point(78, 127);
            this.botTierNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.botTierNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.botTierNumeric.Name = "botTierNumeric";
            this.botTierNumeric.Size = new System.Drawing.Size(121, 23);
            this.botTierNumeric.TabIndex = 2;
            this.botTierNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.botTierNumeric.ValueChanged += new System.EventHandler(this.botTierNumeric_ValueChanged);
            // 
            // enableBotWeapsCheck
            // 
            this.enableBotWeapsCheck.AutoSize = true;
            this.enableBotWeapsCheck.ForeColor = System.Drawing.Color.White;
            this.enableBotWeapsCheck.Location = new System.Drawing.Point(20, 102);
            this.enableBotWeapsCheck.Name = "enableBotWeapsCheck";
            this.enableBotWeapsCheck.Size = new System.Drawing.Size(134, 19);
            this.enableBotWeapsCheck.TabIndex = 1;
            this.enableBotWeapsCheck.Text = "Enable Bot Weapons";
            this.enableBotWeapsCheck.UseVisualStyleBackColor = true;
            this.enableBotWeapsCheck.CheckedChanged += new System.EventHandler(this.enableBotWeapsCheck_CheckedChanged);
            // 
            // botTestingCheck
            // 
            this.botTestingCheck.AutoSize = true;
            this.botTestingCheck.ForeColor = System.Drawing.Color.White;
            this.botTestingCheck.Location = new System.Drawing.Point(20, 77);
            this.botTestingCheck.Name = "botTestingCheck";
            this.botTestingCheck.Size = new System.Drawing.Size(84, 19);
            this.botTestingCheck.TabIndex = 0;
            this.botTestingCheck.Text = "Bot Testing";
            this.botTestingCheck.UseVisualStyleBackColor = true;
            this.botTestingCheck.CheckedChanged += new System.EventHandler(this.botTestingCheck_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5000;
            this.toolTip1.AutoPopDelay = 5000000;
            this.toolTip1.InitialDelay = 400;
            this.toolTip1.ReshowDelay = 400;
            // 
            // revertButton
            // 
            this.revertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.revertButton.BackColor = System.Drawing.Color.DarkOrange;
            this.revertButton.Location = new System.Drawing.Point(12, 665);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(89, 27);
            this.revertButton.TabIndex = 7;
            this.revertButton.Text = "Revert";
            this.toolTip1.SetToolTip(this.revertButton, "Reverts all settings to default values. \r\nTHIS WILL SAVE WHEN PRESSEED, CANNOT BE" +
        " UNDONE!");
            this.revertButton.UseVisualStyleBackColor = false;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.GreenYellow;
            this.saveButton.Location = new System.Drawing.Point(1255, 665);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 27);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // revertLabel
            // 
            this.revertLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.revertLabel.AutoSize = true;
            this.revertLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.revertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.revertLabel.Location = new System.Drawing.Point(5, 647);
            this.revertLabel.Name = "revertLabel";
            this.revertLabel.Size = new System.Drawing.Size(101, 15);
            this.revertLabel.TabIndex = 9;
            this.revertLabel.Text = "Settings Reverted!";
            // 
            // savedLabel
            // 
            this.savedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savedLabel.AutoSize = true;
            this.savedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.savedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.savedLabel.Location = new System.Drawing.Point(1256, 647);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(86, 15);
            this.savedLabel.TabIndex = 10;
            this.savedLabel.Text = "Settings Saved!";
            // 
            // devModeCheck
            // 
            this.devModeCheck.AutoSize = true;
            this.devModeCheck.ForeColor = System.Drawing.Color.White;
            this.devModeCheck.Location = new System.Drawing.Point(20, 257);
            this.devModeCheck.Name = "devModeCheck";
            this.devModeCheck.Size = new System.Drawing.Size(80, 19);
            this.devModeCheck.TabIndex = 11;
            this.devModeCheck.Text = "Dev Mode";
            this.devModeCheck.UseVisualStyleBackColor = true;
            this.devModeCheck.CheckedChanged += new System.EventHandler(this.devModeCheck_CheckedChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1356, 703);
            this.Controls.Add(this.savedLabel);
            this.Controls.Add(this.revertLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.mainTabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = " ";
            this.mainTabControl.ResumeLayout(false);
            this.Realism_Ballistics.ResumeLayout(false);
            this.Realism_Ballistics.PerformLayout();
            this.weapGroupBox.ResumeLayout(false);
            this.weapGroupBox.PerformLayout();
            this.armorGroupBox.ResumeLayout(false);
            this.armorGroupBox.PerformLayout();
            this.Health_Movement.ResumeLayout(false);
            this.moveGroupBox.ResumeLayout(false);
            this.moveGroupBox.PerformLayout();
            this.healthGroupBox.ResumeLayout(false);
            this.healthGroupBox.PerformLayout();
            this.Bots.ResumeLayout(false);
            this.Bots.PerformLayout();
            this.botNameGroupBox.ResumeLayout(false);
            this.botNameGroupBox.PerformLayout();
            this.botDiffGroupBox.ResumeLayout(false);
            this.botDiffGroupBox.PerformLayout();
            this.botHealthGroupBox.ResumeLayout(false);
            this.botHealthGroupBox.PerformLayout();
            this.Misc.ResumeLayout(false);
            this.Misc.PerformLayout();
            this.itemGroupBox.ResumeLayout(false);
            this.itemGroupBox.PerformLayout();
            this.tradeGroupBox.ResumeLayout(false);
            this.tradeGroupBox.PerformLayout();
            this.Dev_Tools.ResumeLayout(false);
            this.Dev_Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botTierNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage Realism_Ballistics;
        private TabPage Health_Movement;
        private TabPage Bots;
        private TabPage Misc;
        private TabPage Dev_Tools;
        private CheckBox buffHelmetsCheck;
        private CheckBox realismCheck;
        private CheckBox headgearConflictsCheck;
        private CheckBox armorMousePenaltyCheck;
        private CheckBox legacyRecoilCheck;
        private CheckBox malfChangesCheck;
        private CheckBox recoilAttOverhaulCheck;
        private ToolTip toolTip1;
        private CheckBox movementChangesCheck;
        private CheckBox botChangesCheck;
        private CheckBox fallDamageChangesCheck;
        private CheckBox medChangesCheck;
        private CheckBox revertMedsCheck;
        private CheckBox openZonesFixCheck;
        private CheckBox increasedBotCapCheck;
        private CheckBox removeRaidRestrictionsCheck;
        private CheckBox allExaminedCheck;
        private CheckBox airdropChangesCheck;
        private CheckBox traderChangesCheck;
        private CheckBox fleaConfigCheck;
        private CheckBox tieredFleaCheck;
        private CheckBox botTestingCheck;
        private CheckBox enableBotWeapsCheck;
        private NumericUpDown botTierNumeric;
        private Label botTierLabel;
        private Label botTypeLabel;
        private ComboBox botTypeCombo;
        private CheckBox bossSpawnsCheck;
        private CheckBox disableFleaBlacklistCheck;
        private CheckBox noFallDamageCheck;
        private CheckBox logEverythingCheck;
        private Button revertButton;
        private Button saveButton;
        private TextBox devToolsTextBox;
        private CheckBox realBossHealthCheck;
        private CheckBox realFollowerHealthCheck;
        private CheckBox pmcNamesCheck;
        private CheckBox bossDifficultyCheck;
        private CheckBox pmcDifficultyCheck;
        private CheckBox realCultistHealthCheck;
        private CheckBox realRRHealthCheck;
        private CheckBox cyrillicNamesCheck;
        private GroupBox botHealthGroupBox;
        private GroupBox botNameGroupBox;
        private GroupBox botDiffGroupBox;
        private GroupBox weapGroupBox;
        private GroupBox armorGroupBox;
        private GroupBox moveGroupBox;
        private GroupBox healthGroupBox;
        private GroupBox itemGroupBox;
        private GroupBox tradeGroupBox;
        private CheckBox masteryCheck;
        private Label revertLabel;
        private Label savedLabel;
        private RichTextBox warningTextBox;
        private CheckBox devModeCheck;
    }
}