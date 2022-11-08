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
            this.recoilAttOverhaul = new System.Windows.Forms.CheckBox();
            this.legacyRecoil = new System.Windows.Forms.CheckBox();
            this.malfChanges = new System.Windows.Forms.CheckBox();
            this.headgearConflicts = new System.Windows.Forms.CheckBox();
            this.armorMousePenalty = new System.Windows.Forms.CheckBox();
            this.buffHelmets = new System.Windows.Forms.CheckBox();
            this.realismMod = new System.Windows.Forms.CheckBox();
            this.Health_Movement = new System.Windows.Forms.TabPage();
            this.revertMeds = new System.Windows.Forms.CheckBox();
            this.medChanges = new System.Windows.Forms.CheckBox();
            this.fallDamageChanges = new System.Windows.Forms.CheckBox();
            this.movementChanges = new System.Windows.Forms.CheckBox();
            this.Bots = new System.Windows.Forms.TabPage();
            this.pmcNamesCheckList = new System.Windows.Forms.CheckedListBox();
            this.botDifficultyCheckList = new System.Windows.Forms.CheckedListBox();
            this.botHealhCheckList = new System.Windows.Forms.CheckedListBox();
            this.openZonesFix = new System.Windows.Forms.CheckBox();
            this.increasedBotCap = new System.Windows.Forms.CheckBox();
            this.botChanges = new System.Windows.Forms.CheckBox();
            this.Misc = new System.Windows.Forms.TabPage();
            this.removeRaidRestrictions = new System.Windows.Forms.CheckBox();
            this.allExamined = new System.Windows.Forms.CheckBox();
            this.airdropChanges = new System.Windows.Forms.CheckBox();
            this.traderChanges = new System.Windows.Forms.CheckBox();
            this.fleaConfig = new System.Windows.Forms.CheckBox();
            this.tieredFlea = new System.Windows.Forms.CheckBox();
            this.Dev_Tools = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logEverything = new System.Windows.Forms.CheckBox();
            this.noFallDamage = new System.Windows.Forms.CheckBox();
            this.disableFleaBlacklist = new System.Windows.Forms.CheckBox();
            this.bossSpawns = new System.Windows.Forms.CheckBox();
            this.botTypeCombo = new System.Windows.Forms.ComboBox();
            this.botTypeLabel = new System.Windows.Forms.Label();
            this.botTierLabel = new System.Windows.Forms.Label();
            this.botTierNumeric = new System.Windows.Forms.NumericUpDown();
            this.enableBotWeaps = new System.Windows.Forms.CheckBox();
            this.botTesting = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.revertButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.Realism_Ballistics.SuspendLayout();
            this.Health_Movement.SuspendLayout();
            this.Bots.SuspendLayout();
            this.Misc.SuspendLayout();
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
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1332, 647);
            this.mainTabControl.TabIndex = 0;
            // 
            // Realism_Ballistics
            // 
            this.Realism_Ballistics.BackColor = System.Drawing.Color.Silver;
            this.Realism_Ballistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Realism_Ballistics.BackgroundImage")));
            this.Realism_Ballistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Realism_Ballistics.Controls.Add(this.recoilAttOverhaul);
            this.Realism_Ballistics.Controls.Add(this.legacyRecoil);
            this.Realism_Ballistics.Controls.Add(this.malfChanges);
            this.Realism_Ballistics.Controls.Add(this.headgearConflicts);
            this.Realism_Ballistics.Controls.Add(this.armorMousePenalty);
            this.Realism_Ballistics.Controls.Add(this.buffHelmets);
            this.Realism_Ballistics.Controls.Add(this.realismMod);
            this.Realism_Ballistics.Location = new System.Drawing.Point(4, 24);
            this.Realism_Ballistics.Name = "Realism_Ballistics";
            this.Realism_Ballistics.Padding = new System.Windows.Forms.Padding(3);
            this.Realism_Ballistics.Size = new System.Drawing.Size(1324, 619);
            this.Realism_Ballistics.TabIndex = 0;
            this.Realism_Ballistics.Text = "Realism and Ballistics";
            // 
            // recoilAttOverhaul
            // 
            this.recoilAttOverhaul.AutoSize = true;
            this.recoilAttOverhaul.Checked = true;
            this.recoilAttOverhaul.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recoilAttOverhaul.Location = new System.Drawing.Point(8, 35);
            this.recoilAttOverhaul.Name = "recoilAttOverhaul";
            this.recoilAttOverhaul.Size = new System.Drawing.Size(198, 19);
            this.recoilAttOverhaul.TabIndex = 6;
            this.recoilAttOverhaul.Text = "Recoil and Attachment Overhaul";
            this.toolTip1.SetToolTip(this.recoilAttOverhaul, resources.GetString("recoilAttOverhaul.ToolTip"));
            this.recoilAttOverhaul.UseVisualStyleBackColor = true;
            // 
            // legacyRecoil
            // 
            this.legacyRecoil.AutoSize = true;
            this.legacyRecoil.Location = new System.Drawing.Point(8, 160);
            this.legacyRecoil.Name = "legacyRecoil";
            this.legacyRecoil.Size = new System.Drawing.Size(147, 19);
            this.legacyRecoil.TabIndex = 5;
            this.legacyRecoil.Text = "Legacy Recoil Changes";
            this.toolTip1.SetToolTip(this.legacyRecoil, "The standard recoil settings from previous versions. DO NOT USE THIS IF THE RECOI" +
        "L AND ATTACHMENT OVERHAUL IS INSTALLED AND ENABLED.\r\n");
            this.legacyRecoil.UseVisualStyleBackColor = true;
            // 
            // malfChanges
            // 
            this.malfChanges.AutoSize = true;
            this.malfChanges.Checked = true;
            this.malfChanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.malfChanges.Location = new System.Drawing.Point(8, 60);
            this.malfChanges.Name = "malfChanges";
            this.malfChanges.Size = new System.Drawing.Size(140, 19);
            this.malfChanges.TabIndex = 4;
            this.malfChanges.Text = "Malfunction Changes";
            this.toolTip1.SetToolTip(this.malfChanges, "Enables changes to malfunctions and overheating. No malfunctions will occur betwe" +
        "en 98-100 durability.\r\nSee mod page description for details.\r\n");
            this.malfChanges.UseVisualStyleBackColor = true;
            // 
            // headgearConflicts
            // 
            this.headgearConflicts.AutoSize = true;
            this.headgearConflicts.Checked = true;
            this.headgearConflicts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.headgearConflicts.Location = new System.Drawing.Point(8, 135);
            this.headgearConflicts.Name = "headgearConflicts";
            this.headgearConflicts.Size = new System.Drawing.Size(127, 19);
            this.headgearConflicts.TabIndex = 3;
            this.headgearConflicts.Text = "Headgear Conflicts";
            this.toolTip1.SetToolTip(this.headgearConflicts, "Makes some masks and headgear conflict to prevent bots from looking cursed, these" +
        " are items that clip badly. If you want to look cursed too, you can disable it.");
            this.headgearConflicts.UseVisualStyleBackColor = true;
            // 
            // armorMousePenalty
            // 
            this.armorMousePenalty.AutoSize = true;
            this.armorMousePenalty.Checked = true;
            this.armorMousePenalty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.armorMousePenalty.Location = new System.Drawing.Point(8, 110);
            this.armorMousePenalty.Name = "armorMousePenalty";
            this.armorMousePenalty.Size = new System.Drawing.Size(141, 19);
            this.armorMousePenalty.TabIndex = 2;
            this.armorMousePenalty.Text = "Armor Mouse Penalty";
            this.toolTip1.SetToolTip(this.armorMousePenalty, "Armor will reduce mouse sensitivity by % equal to their weight.\r\nIf disabled, arm" +
        "or will have no mouse sensitivity penalty.");
            this.armorMousePenalty.UseVisualStyleBackColor = true;
            // 
            // buffHelmets
            // 
            this.buffHelmets.AutoSize = true;
            this.buffHelmets.Checked = true;
            this.buffHelmets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buffHelmets.Location = new System.Drawing.Point(8, 85);
            this.buffHelmets.Name = "buffHelmets";
            this.buffHelmets.Size = new System.Drawing.Size(95, 19);
            this.buffHelmets.TabIndex = 1;
            this.buffHelmets.Text = "Buff Helmets";
            this.toolTip1.SetToolTip(this.buffHelmets, resources.GetString("buffHelmets.ToolTip"));
            this.buffHelmets.UseVisualStyleBackColor = true;
            // 
            // realismMod
            // 
            this.realismMod.AutoSize = true;
            this.realismMod.Checked = true;
            this.realismMod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realismMod.Location = new System.Drawing.Point(8, 10);
            this.realismMod.Name = "realismMod";
            this.realismMod.Size = new System.Drawing.Size(67, 19);
            this.realismMod.TabIndex = 0;
            this.realismMod.Text = "Realism";
            this.toolTip1.SetToolTip(this.realismMod, resources.GetString("realismMod.ToolTip"));
            this.realismMod.UseVisualStyleBackColor = true;
            // 
            // Health_Movement
            // 
            this.Health_Movement.BackColor = System.Drawing.Color.Silver;
            this.Health_Movement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Health_Movement.BackgroundImage")));
            this.Health_Movement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Health_Movement.Controls.Add(this.revertMeds);
            this.Health_Movement.Controls.Add(this.medChanges);
            this.Health_Movement.Controls.Add(this.fallDamageChanges);
            this.Health_Movement.Controls.Add(this.movementChanges);
            this.Health_Movement.Location = new System.Drawing.Point(4, 24);
            this.Health_Movement.Name = "Health_Movement";
            this.Health_Movement.Padding = new System.Windows.Forms.Padding(3);
            this.Health_Movement.Size = new System.Drawing.Size(1324, 619);
            this.Health_Movement.TabIndex = 1;
            this.Health_Movement.Text = "Health & Movment";
            // 
            // revertMeds
            // 
            this.revertMeds.AutoSize = true;
            this.revertMeds.Location = new System.Drawing.Point(8, 42);
            this.revertMeds.Name = "revertMeds";
            this.revertMeds.Size = new System.Drawing.Size(135, 19);
            this.revertMeds.TabIndex = 3;
            this.revertMeds.Text = "Revert Med Changes";
            this.toolTip1.SetToolTip(this.revertMeds, "If set to enabled **AND** med changes is disabled, the meds in your inventory wil" +
        "l be restored back to their full HP resource.");
            this.revertMeds.UseVisualStyleBackColor = true;
            // 
            // medChanges
            // 
            this.medChanges.AutoSize = true;
            this.medChanges.Checked = true;
            this.medChanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.medChanges.Location = new System.Drawing.Point(8, 17);
            this.medChanges.Name = "medChanges";
            this.medChanges.Size = new System.Drawing.Size(99, 19);
            this.medChanges.TabIndex = 2;
            this.medChanges.Text = "Med Changes";
            this.toolTip1.SetToolTip(this.medChanges, resources.GetString("medChanges.ToolTip"));
            this.medChanges.UseVisualStyleBackColor = true;
            // 
            // fallDamageChanges
            // 
            this.fallDamageChanges.AutoSize = true;
            this.fallDamageChanges.Checked = true;
            this.fallDamageChanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fallDamageChanges.Location = new System.Drawing.Point(8, 92);
            this.fallDamageChanges.Name = "fallDamageChanges";
            this.fallDamageChanges.Size = new System.Drawing.Size(140, 19);
            this.fallDamageChanges.TabIndex = 1;
            this.fallDamageChanges.Text = "Fall Damage Changes";
            this.toolTip1.SetToolTip(this.fallDamageChanges, "Enables changes that increases fall damage.");
            this.fallDamageChanges.UseVisualStyleBackColor = true;
            // 
            // movementChanges
            // 
            this.movementChanges.AutoSize = true;
            this.movementChanges.Checked = true;
            this.movementChanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.movementChanges.Location = new System.Drawing.Point(8, 67);
            this.movementChanges.Name = "movementChanges";
            this.movementChanges.Size = new System.Drawing.Size(133, 19);
            this.movementChanges.TabIndex = 0;
            this.movementChanges.Text = "Movement Changes";
            this.toolTip1.SetToolTip(this.movementChanges, "Enables changes to movement speed, inertia, weight limits, and fall/jump penaltie" +
        "s.");
            this.movementChanges.UseVisualStyleBackColor = true;
            // 
            // Bots
            // 
            this.Bots.BackColor = System.Drawing.Color.Silver;
            this.Bots.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bots.BackgroundImage")));
            this.Bots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bots.Controls.Add(this.pmcNamesCheckList);
            this.Bots.Controls.Add(this.botDifficultyCheckList);
            this.Bots.Controls.Add(this.botHealhCheckList);
            this.Bots.Controls.Add(this.openZonesFix);
            this.Bots.Controls.Add(this.increasedBotCap);
            this.Bots.Controls.Add(this.botChanges);
            this.Bots.Location = new System.Drawing.Point(4, 24);
            this.Bots.Name = "Bots";
            this.Bots.Size = new System.Drawing.Size(1324, 619);
            this.Bots.TabIndex = 2;
            this.Bots.Text = "Bots";
            // 
            // pmcNamesCheckList
            // 
            this.pmcNamesCheckList.BackColor = System.Drawing.Color.LightGray;
            this.pmcNamesCheckList.FormattingEnabled = true;
            this.pmcNamesCheckList.Items.AddRange(new object[] {
            "Real PMC Names\t",
            "Cyrillic Bear Names"});
            this.pmcNamesCheckList.Location = new System.Drawing.Point(8, 217);
            this.pmcNamesCheckList.Name = "pmcNamesCheckList";
            this.pmcNamesCheckList.Size = new System.Drawing.Size(137, 40);
            this.pmcNamesCheckList.TabIndex = 5;
            this.toolTip1.SetToolTip(this.pmcNamesCheckList, "Changes bot names to actual names from a huge list. Bear names can use Latin or C" +
        "yrillic alphabet.\r\nNames come courtesy of user Computica.");
            // 
            // botDifficultyCheckList
            // 
            this.botDifficultyCheckList.BackColor = System.Drawing.Color.LightGray;
            this.botDifficultyCheckList.FormattingEnabled = true;
            this.botDifficultyCheckList.Items.AddRange(new object[] {
            "PMC Difficulty\t",
            "Boss Difficulty"});
            this.botDifficultyCheckList.Location = new System.Drawing.Point(8, 171);
            this.botDifficultyCheckList.Name = "botDifficultyCheckList";
            this.botDifficultyCheckList.Size = new System.Drawing.Size(137, 40);
            this.botDifficultyCheckList.TabIndex = 4;
            this.toolTip1.SetToolTip(this.botDifficultyCheckList, "PMC and Boss difficulty will be raised if enabled.\r\nOnly use this if not using ot" +
        "her AI mods. Will just simply set bosses and PMC from \'AsOnline\' to a higher dif" +
        "ficulty settings (Hard or Impossible). ");
            // 
            // botHealhCheckList
            // 
            this.botHealhCheckList.BackColor = System.Drawing.Color.LightGray;
            this.botHealhCheckList.FormattingEnabled = true;
            this.botHealhCheckList.Items.AddRange(new object[] {
            "Reallistic Boss Health",
            "Realistic Boss Follower Health",
            "Realistic Raider/Rogue Health",
            "Realistic Cultist Health"});
            this.botHealhCheckList.Location = new System.Drawing.Point(8, 89);
            this.botHealhCheckList.Name = "botHealhCheckList";
            this.botHealhCheckList.Size = new System.Drawing.Size(185, 76);
            this.botHealhCheckList.TabIndex = 3;
            this.toolTip1.SetToolTip(this.botHealhCheckList, resources.GetString("botHealhCheckList.ToolTip"));
            // 
            // openZonesFix
            // 
            this.openZonesFix.AutoSize = true;
            this.openZonesFix.Checked = true;
            this.openZonesFix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openZonesFix.Location = new System.Drawing.Point(8, 64);
            this.openZonesFix.Name = "openZonesFix";
            this.openZonesFix.Size = new System.Drawing.Size(105, 19);
            this.openZonesFix.TabIndex = 2;
            this.openZonesFix.Text = "OpenZones Fix";
            this.toolTip1.SetToolTip(this.openZonesFix, "OpenZones fix. Adds more zones that bots can spawn in. Credit to JustNU.\r\nThis wi" +
        "ll most likely interfere with Lua\'s Spawn Rework, leave disabled if you\'re using" +
        " that.");
            this.openZonesFix.UseVisualStyleBackColor = true;
            // 
            // increasedBotCap
            // 
            this.increasedBotCap.AutoSize = true;
            this.increasedBotCap.Checked = true;
            this.increasedBotCap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.increasedBotCap.Location = new System.Drawing.Point(8, 39);
            this.increasedBotCap.Name = "increasedBotCap";
            this.increasedBotCap.Size = new System.Drawing.Size(121, 19);
            this.increasedBotCap.TabIndex = 1;
            this.increasedBotCap.Text = "Increased Bot Cap";
            this.toolTip1.SetToolTip(this.increasedBotCap, "Raises max bot cap on most maps.");
            this.increasedBotCap.UseVisualStyleBackColor = true;
            // 
            // botChanges
            // 
            this.botChanges.AutoSize = true;
            this.botChanges.Checked = true;
            this.botChanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.botChanges.Location = new System.Drawing.Point(8, 14);
            this.botChanges.Name = "botChanges";
            this.botChanges.Size = new System.Drawing.Size(93, 19);
            this.botChanges.TabIndex = 0;
            this.botChanges.Text = "Bot Changes";
            this.toolTip1.SetToolTip(this.botChanges, "Enables bot tiered loadouts, randomized PMC behaviour, changes to bot loot, armor" +
        " and weapon durability, hostilitiy chance, spawn ratios, etc.");
            this.botChanges.UseVisualStyleBackColor = true;
            // 
            // Misc
            // 
            this.Misc.BackColor = System.Drawing.Color.Silver;
            this.Misc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Misc.BackgroundImage")));
            this.Misc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Misc.Controls.Add(this.removeRaidRestrictions);
            this.Misc.Controls.Add(this.allExamined);
            this.Misc.Controls.Add(this.airdropChanges);
            this.Misc.Controls.Add(this.traderChanges);
            this.Misc.Controls.Add(this.fleaConfig);
            this.Misc.Controls.Add(this.tieredFlea);
            this.Misc.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Misc.Location = new System.Drawing.Point(4, 24);
            this.Misc.Name = "Misc";
            this.Misc.Size = new System.Drawing.Size(1324, 619);
            this.Misc.TabIndex = 4;
            this.Misc.Text = "Misc.";
            // 
            // removeRaidRestrictions
            // 
            this.removeRaidRestrictions.AutoSize = true;
            this.removeRaidRestrictions.Checked = true;
            this.removeRaidRestrictions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeRaidRestrictions.Location = new System.Drawing.Point(8, 140);
            this.removeRaidRestrictions.Name = "removeRaidRestrictions";
            this.removeRaidRestrictions.Size = new System.Drawing.Size(181, 19);
            this.removeRaidRestrictions.TabIndex = 5;
            this.removeRaidRestrictions.Text = "Removed In-Raid Restrictions";
            this.toolTip1.SetToolTip(this.removeRaidRestrictions, "Removes all in-raid item count restrictions and discard limits enabled. For examp" +
        "le, you can carry as much cash, BTC, LEDX etc. as you like in raid.");
            this.removeRaidRestrictions.UseVisualStyleBackColor = true;
            // 
            // allExamined
            // 
            this.allExamined.AutoSize = true;
            this.allExamined.Checked = true;
            this.allExamined.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allExamined.Location = new System.Drawing.Point(8, 115);
            this.allExamined.Name = "allExamined";
            this.allExamined.Size = new System.Drawing.Size(127, 19);
            this.allExamined.TabIndex = 4;
            this.allExamined.Text = "All Items Examined";
            this.toolTip1.SetToolTip(this.allExamined, "All items will be by default examined if enabled.");
            this.allExamined.UseVisualStyleBackColor = true;
            // 
            // airdropChanges
            // 
            this.airdropChanges.AutoSize = true;
            this.airdropChanges.Checked = true;
            this.airdropChanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.airdropChanges.Location = new System.Drawing.Point(8, 90);
            this.airdropChanges.Name = "airdropChanges";
            this.airdropChanges.Size = new System.Drawing.Size(115, 19);
            this.airdropChanges.TabIndex = 3;
            this.airdropChanges.Text = "Airdrop Changes";
            this.toolTip1.SetToolTip(this.airdropChanges, resources.GetString("airdropChanges.ToolTip"));
            this.airdropChanges.UseVisualStyleBackColor = true;
            // 
            // traderChanges
            // 
            this.traderChanges.AutoSize = true;
            this.traderChanges.Checked = true;
            this.traderChanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.traderChanges.Location = new System.Drawing.Point(8, 65);
            this.traderChanges.Name = "traderChanges";
            this.traderChanges.Size = new System.Drawing.Size(107, 19);
            this.traderChanges.TabIndex = 2;
            this.traderChanges.Text = "Trader Changes";
            this.toolTip1.SetToolTip(this.traderChanges, resources.GetString("traderChanges.ToolTip"));
            this.traderChanges.UseVisualStyleBackColor = true;
            // 
            // fleaConfig
            // 
            this.fleaConfig.AutoSize = true;
            this.fleaConfig.Checked = true;
            this.fleaConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fleaConfig.Location = new System.Drawing.Point(8, 40);
            this.fleaConfig.Name = "fleaConfig";
            this.fleaConfig.Size = new System.Drawing.Size(138, 19);
            this.fleaConfig.TabIndex = 1;
            this.fleaConfig.Text = "Hardcore Flea Config";
            this.toolTip1.SetToolTip(this.fleaConfig, "Enables a hardcore fleamarket config. There are very few offers per item, if any " +
        "at all. Item condition and stack amount vary a lot, high prices, lower seel chan" +
        "ce and so on.");
            this.fleaConfig.UseVisualStyleBackColor = true;
            // 
            // tieredFlea
            // 
            this.tieredFlea.AutoSize = true;
            this.tieredFlea.Checked = true;
            this.tieredFlea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tieredFlea.Location = new System.Drawing.Point(8, 15);
            this.tieredFlea.Name = "tieredFlea";
            this.tieredFlea.Size = new System.Drawing.Size(119, 19);
            this.tieredFlea.TabIndex = 0;
            this.tieredFlea.Text = "Tiered Fleamarket";
            this.toolTip1.SetToolTip(this.tieredFlea, resources.GetString("tieredFlea.ToolTip"));
            this.tieredFlea.UseVisualStyleBackColor = true;
            // 
            // Dev_Tools
            // 
            this.Dev_Tools.BackColor = System.Drawing.Color.Silver;
            this.Dev_Tools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dev_Tools.BackgroundImage")));
            this.Dev_Tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dev_Tools.Controls.Add(this.textBox1);
            this.Dev_Tools.Controls.Add(this.logEverything);
            this.Dev_Tools.Controls.Add(this.noFallDamage);
            this.Dev_Tools.Controls.Add(this.disableFleaBlacklist);
            this.Dev_Tools.Controls.Add(this.bossSpawns);
            this.Dev_Tools.Controls.Add(this.botTypeCombo);
            this.Dev_Tools.Controls.Add(this.botTypeLabel);
            this.Dev_Tools.Controls.Add(this.botTierLabel);
            this.Dev_Tools.Controls.Add(this.botTierNumeric);
            this.Dev_Tools.Controls.Add(this.enableBotWeaps);
            this.Dev_Tools.Controls.Add(this.botTesting);
            this.Dev_Tools.Location = new System.Drawing.Point(4, 24);
            this.Dev_Tools.Name = "Dev_Tools";
            this.Dev_Tools.Size = new System.Drawing.Size(1324, 619);
            this.Dev_Tools.TabIndex = 5;
            this.Dev_Tools.Text = "Dev Tools";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(651, 51);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // logEverything
            // 
            this.logEverything.AutoSize = true;
            this.logEverything.Location = new System.Drawing.Point(12, 254);
            this.logEverything.Name = "logEverything";
            this.logEverything.Size = new System.Drawing.Size(105, 19);
            this.logEverything.TabIndex = 9;
            this.logEverything.Text = "Log Everything";
            this.logEverything.UseVisualStyleBackColor = true;
            // 
            // noFallDamage
            // 
            this.noFallDamage.AutoSize = true;
            this.noFallDamage.Location = new System.Drawing.Point(12, 229);
            this.noFallDamage.Name = "noFallDamage";
            this.noFallDamage.Size = new System.Drawing.Size(110, 19);
            this.noFallDamage.TabIndex = 8;
            this.noFallDamage.Text = "No Fall Damage";
            this.noFallDamage.UseVisualStyleBackColor = true;
            // 
            // disableFleaBlacklist
            // 
            this.disableFleaBlacklist.AutoSize = true;
            this.disableFleaBlacklist.Location = new System.Drawing.Point(12, 204);
            this.disableFleaBlacklist.Name = "disableFleaBlacklist";
            this.disableFleaBlacklist.Size = new System.Drawing.Size(134, 19);
            this.disableFleaBlacklist.TabIndex = 7;
            this.disableFleaBlacklist.Text = "Disable Flea Blacklist";
            this.disableFleaBlacklist.UseVisualStyleBackColor = true;
            // 
            // bossSpawns
            // 
            this.bossSpawns.AutoSize = true;
            this.bossSpawns.Location = new System.Drawing.Point(12, 179);
            this.bossSpawns.Name = "bossSpawns";
            this.bossSpawns.Size = new System.Drawing.Size(150, 19);
            this.bossSpawns.TabIndex = 6;
            this.bossSpawns.Text = "Guarantee Boss Spawns";
            this.bossSpawns.UseVisualStyleBackColor = true;
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
            "All Bear",
            "Default"});
            this.botTypeCombo.Location = new System.Drawing.Point(70, 150);
            this.botTypeCombo.Name = "botTypeCombo";
            this.botTypeCombo.Size = new System.Drawing.Size(121, 23);
            this.botTypeCombo.TabIndex = 5;
            // 
            // botTypeLabel
            // 
            this.botTypeLabel.AutoSize = true;
            this.botTypeLabel.Location = new System.Drawing.Point(12, 150);
            this.botTypeLabel.Name = "botTypeLabel";
            this.botTypeLabel.Size = new System.Drawing.Size(52, 15);
            this.botTypeLabel.TabIndex = 4;
            this.botTypeLabel.Text = "Bot Type";
            // 
            // botTierLabel
            // 
            this.botTierLabel.AutoSize = true;
            this.botTierLabel.Location = new System.Drawing.Point(12, 126);
            this.botTierLabel.Name = "botTierLabel";
            this.botTierLabel.Size = new System.Drawing.Size(47, 15);
            this.botTierLabel.TabIndex = 3;
            this.botTierLabel.Text = "Bot Tier";
            // 
            // botTierNumeric
            // 
            this.botTierNumeric.Location = new System.Drawing.Point(70, 124);
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
            // 
            // enableBotWeaps
            // 
            this.enableBotWeaps.AutoSize = true;
            this.enableBotWeaps.Location = new System.Drawing.Point(12, 99);
            this.enableBotWeaps.Name = "enableBotWeaps";
            this.enableBotWeaps.Size = new System.Drawing.Size(141, 19);
            this.enableBotWeaps.TabIndex = 1;
            this.enableBotWeaps.Text = "Enabled Bot Weapons";
            this.enableBotWeaps.UseVisualStyleBackColor = true;
            // 
            // botTesting
            // 
            this.botTesting.AutoSize = true;
            this.botTesting.Location = new System.Drawing.Point(12, 74);
            this.botTesting.Name = "botTesting";
            this.botTesting.Size = new System.Drawing.Size(84, 19);
            this.botTesting.TabIndex = 0;
            this.botTesting.Text = "Bot Testing";
            this.botTesting.UseVisualStyleBackColor = true;
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
            this.revertButton.UseVisualStyleBackColor = false;
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
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1356, 703);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.mainTabControl);
            this.DoubleBuffered = true;
            this.Name = "Main_Form";
            this.Text = " ";
            this.mainTabControl.ResumeLayout(false);
            this.Realism_Ballistics.ResumeLayout(false);
            this.Realism_Ballistics.PerformLayout();
            this.Health_Movement.ResumeLayout(false);
            this.Health_Movement.PerformLayout();
            this.Bots.ResumeLayout(false);
            this.Bots.PerformLayout();
            this.Misc.ResumeLayout(false);
            this.Misc.PerformLayout();
            this.Dev_Tools.ResumeLayout(false);
            this.Dev_Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botTierNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage Realism_Ballistics;
        private TabPage Health_Movement;
        private TabPage Bots;
        private TabPage Misc;
        private TabPage Dev_Tools;
        private CheckBox buffHelmets;
        private CheckBox realismMod;
        private CheckBox headgearConflicts;
        private CheckBox armorMousePenalty;
        private CheckBox legacyRecoil;
        private CheckBox malfChanges;
        private CheckBox recoilAttOverhaul;
        private ToolTip toolTip1;
        private CheckBox movementChanges;
        private CheckBox botChanges;
        private CheckBox fallDamageChanges;
        private CheckBox medChanges;
        private CheckBox revertMeds;
        private CheckBox openZonesFix;
        private CheckBox increasedBotCap;
        private CheckedListBox botHealhCheckList;
        private CheckedListBox pmcNamesCheckList;
        private CheckedListBox botDifficultyCheckList;
        private CheckBox removeRaidRestrictions;
        private CheckBox allExamined;
        private CheckBox airdropChanges;
        private CheckBox traderChanges;
        private CheckBox fleaConfig;
        private CheckBox tieredFlea;
        private CheckBox botTesting;
        private CheckBox enableBotWeaps;
        private NumericUpDown botTierNumeric;
        private Label botTierLabel;
        private Label botTypeLabel;
        private ComboBox botTypeCombo;
        private CheckBox bossSpawns;
        private CheckBox disableFleaBlacklist;
        private CheckBox noFallDamage;
        private CheckBox logEverything;
        private Button revertButton;
        private Button saveButton;
        private TextBox textBox1;
    }
}