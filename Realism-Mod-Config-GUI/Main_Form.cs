using Newtonsoft.Json;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Realism_Mod_Config_GUI
{
    public partial class Main_Form : Form
    {

        public static string ConfigFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"config\config.json");
        public static string ConfigJSON = File.ReadAllText(ConfigFilePath);
        public static ConfigTemplate Config = JsonConvert.DeserializeObject<ConfigTemplate>(ConfigJSON);

        public static string weapFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db/templates/weapons/");
        public static DirectoryInfo weapDI = new DirectoryInfo(weapFilePath);
        public static DirectoryInfo[] weapPresetFilePath = weapDI.GetDirectories();

        public static string attFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db/templates/attatchments/");
        public static DirectoryInfo attDI = new DirectoryInfo(attFilePath);
        public static DirectoryInfo[] attPresetFilePath = attDI.GetDirectories();


        public Main_Form()
        {
            InitializeComponent();
            setTitleBar();
            setNumericLimits();
            SetPresetComboBoxes(weapPresetFilePath, weapPresetCombo);
            SetPresetComboBoxes(attPresetFilePath, attachPresetCombo);

            try
            {
                warningTextBox.Hide();
                SetDisplayValues();
            }
            catch(Exception exception)
            {
                warningTextBox.Show();
               /* warningTextBox.Text = $"config.json not found at file path: {Path.Combine(Path.GetDirectoryName(Environment.ProcessPath))}\\config\\";*/
                warningTextBox.Text = $"{exception.Message}";
            }
        }


        private void setTitleBar()
        {
            string modVer = "v0.6.5";
            string sptVer = "v3.4.1";

            this.Text = "SPT Realism Mod Config SPTRM " + modVer + " SPT " + sptVer;

            modVerLabel.Text = modVer;
        }

        private void setNumericLimits()
        {

            decimal recoilMultiMin = 0.1m;
            decimal recoilMultiMax = 10.0m;
            decimal hpMultiMax = 10.0m;
            decimal hpMultiMin = 0.1m;
            decimal increment = 0.1m;
            int decimalPlaces = 2;

            procNumeric.Minimum = 0.1m;
            procNumeric.Maximum = 2.0m;
            procNumeric.Increment = 0.05m;
            procNumeric.DecimalPlaces = decimalPlaces;

            vertRecNumeric.Minimum = recoilMultiMin;
            vertRecNumeric.Maximum = recoilMultiMax;
            vertRecNumeric.Increment = increment;
            vertRecNumeric.DecimalPlaces = decimalPlaces;

            horzRecNumeric.Minimum = recoilMultiMin;
            horzRecNumeric.Maximum = recoilMultiMax;
            horzRecNumeric.Increment = increment;
            horzRecNumeric.DecimalPlaces = decimalPlaces;

            convNumeric.Minimum = recoilMultiMin;
            convNumeric.Maximum = recoilMultiMax;
            convNumeric.Increment = increment;
            convNumeric.DecimalPlaces = decimalPlaces;

            dispNumeric.Minimum = recoilMultiMin;
            dispNumeric.Maximum = recoilMultiMax;
            dispNumeric.Increment = increment;
            dispNumeric.DecimalPlaces = decimalPlaces;

            ergoNumeric.Minimum = recoilMultiMin;
            ergoNumeric.Maximum = recoilMultiMax;
            ergoNumeric.Increment = increment;
            ergoNumeric.DecimalPlaces = decimalPlaces;

            standardHPNumeric.Minimum = hpMultiMin;
            standardHPNumeric.Maximum = hpMultiMax;
            standardHPNumeric.Increment = increment;
            standardHPNumeric.DecimalPlaces = decimalPlaces;

            midHPNumeric.Minimum = hpMultiMin;
            midHPNumeric.Maximum = hpMultiMax;
            midHPNumeric.Increment = increment;
            midHPNumeric.DecimalPlaces = decimalPlaces;

            bossHPNumeric.Minimum = hpMultiMin;
            bossHPNumeric.Maximum = hpMultiMax;
            bossHPNumeric.Increment = increment;
            bossHPNumeric.DecimalPlaces = decimalPlaces;
        }

        private void SetPresetComboBoxes(DirectoryInfo[] dirInfoArr, ComboBox cb)
        {
            foreach (DirectoryInfo dir in dirInfoArr)
            {
                cb.Items.Add(dir.Name);
            }
        }



        private void SetDefaultValues()
        {

            foreach (TabPage p in this.mainTabControl.TabPages)
            {
                foreach (Control c in p.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;
                        cb.Enabled = true;
                    }
                    if (c is GroupBox)
                    {
                        foreach (Control gc in c.Controls)
                        {
                            gc.Enabled = true;
                        }
                    }
                }
            }



            procNumeric.Value = 1.0m;
            vertRecNumeric.Value = 1.0m;
            horzRecNumeric.Value = 1.0m;
            convNumeric.Value = 1.0m;
            dispNumeric.Value = 1.0m;
            ergoNumeric.Value = 1.0m;

            standardHPNumeric.Value = 1.0m;
            midHPNumeric.Value = 1.0m;
            bossHPNumeric.Value = 1.0m;

            crankCheck.Checked = true;

            weapPresetCombo.SelectedItem = "Realism";
            attachPresetCombo.SelectedItem = "Realism";

            Config.realistic_player_health = true;
            Config.realistic_ballistics = true;
            Config.recoil_attachment_overhaul = true;
            Config.mastery_changes = true;
            Config.legacy_recoil_changes = false;
            Config.buff_helmets = false;
            Config.armor_mouse_penalty = true;
            Config.headgear_conflicts = true;
            Config.malf_changes = true;
            Config.med_changes = true;
            Config.revert_med_changes = false;
            Config.weight_limits_changes= true;
            Config.movement_changes = true;
            Config.fall_damage_changes = true;
            Config.bot_changes = true;
            Config.increased_bot_cap = false;
            Config.open_zones_fix = true;
            Config.boss_spawns= true; 
            Config.realistic_boss_health = true;
            Config.realistic_boss_follower_health = true;
            Config.realistic_raider_rogue_health = true;
            Config.realistic_cultist_health = true;
            Config.pmc_difficulty = false;
            Config.boss_difficulty = false;
            Config.pmc_types= true;
            Config.bot_names = true;
            Config.cyrillic_bear_names = true;
            Config.tiered_flea = true;
            Config.flea_changes = true;
            Config.trader_changes = true;
            Config.all_examined = true;
            Config.remove_inraid_restrictions = true;
            Config.remove_fir_req = true;
            Config.airdrop_changes = true;
            Config.bot_testing = false;
            Config.bot_test_tier = 1;
            Config.all_bear = false;
            Config.all_USEC = false;
            Config.all_PMCs = false;
            Config.all_scavs = false;
            Config.bot_test_weps_enabled = true;
            Config.guarantee_boss_spawn = false;
            Config.force_boss_items = false;    
            Config.disable_flea_blacklist = false;
            Config.no_fall_damage = false;
            Config.logEverything = false;
            Config.dev_mode = false;
            Config.unstuck_GS = false;
            Config.revert_hp= false;

            CheckCheckBoxes();
        }

        private void SetDisplayValues()
        {
            procNumeric.Value = (decimal)Config.procedural_intensity;
            vertRecNumeric.Value = (decimal)Config.vert_recoil_multi;
            horzRecNumeric.Value = (decimal)Config.horz_recoil_multi;
            convNumeric.Value = (decimal)Config.convergence_multi;
            dispNumeric.Value = (decimal)Config.dispersion_multi;
            ergoNumeric.Value = (decimal)Config.ergo_multi;

            standardHPNumeric.Value = (decimal)Config.standard_bot_hp_multi;
            midHPNumeric.Value = (decimal)Config.mid_bot_hp_multi;
            bossHPNumeric.Value = (decimal)Config.boss_bot_hp_multi;

            crankCheck.Checked = Config.recoil_crank;

            weapPresetCombo.SelectedItem = Config.weap_preset;
            attachPresetCombo.SelectedItem = Config.att_preset;

            realPlayerHealthCheck.Checked = Config.realistic_player_health;
            realBallisticsCheck.Checked = Config.realistic_ballistics;
            recoilAttOverhaulCheck.Checked = Config.recoil_attachment_overhaul;
            malfChangesCheck.Checked = Config.malf_changes;
            masteryCheck.Checked = Config.mastery_changes;
            buffHelmetsCheck.Checked = Config.buff_helmets;
            armorMousePenaltyCheck.Checked = Config.armor_mouse_penalty;
            headgearConflictsCheck.Checked = Config.headgear_conflicts;
            legacyRecoilCheck.Checked = Config.legacy_recoil_changes;

            medChangesCheck.Checked = Config.med_changes;
            revertMedsCheck.Checked = Config.revert_med_changes;
            movementChangesCheck.Checked = Config.movement_changes;
            weightCheck.Checked = Config.weight_limits_changes;
            fallDamageChangesCheck.Checked = Config.fall_damage_changes;

            botChangesCheck.Checked = Config.bot_changes;
            increasedBotCapCheck.Checked = Config.increased_bot_cap;
            openZonesFixCheck.Checked = Config.open_zones_fix;
            bossSpawnCheck.Checked = Config.boss_spawns;
            realBossHealthCheck.Checked = Config.realistic_boss_health;
            realFollowerHealthCheck.Checked = Config.realistic_boss_follower_health;
            realRRHealthCheck.Checked = Config.realistic_raider_rogue_health;
            realCultistHealthCheck.Checked = Config.realistic_cultist_health;
            bossDifficultyCheck.Checked = Config.boss_difficulty;
            pmcDifficultyCheck.Checked = Config.pmc_difficulty;
            pmcTypeCheck.Checked = Config.pmc_types;
            pmcNamesCheck.Checked = Config.bot_names;
            cyrillicNamesCheck.Checked = Config.cyrillic_bear_names;

            tieredFleaCheck.Checked = Config.tiered_flea;
            fleaConfigCheck.Checked = Config.flea_changes;
            traderChangesCheck.Checked = Config.trader_changes;
            allExaminedCheck.Checked = Config.all_examined;
            removeRaidRestrictionsCheck.Checked = Config.remove_inraid_restrictions;
            firCheck.Checked = Config.remove_fir_req;
            airdropChangesCheck.Checked = Config.airdrop_changes;

            botTestingCheck.Checked = Config.bot_testing;
            enableBotWeapsCheck.Checked = Config.bot_test_weps_enabled;
            bossSpawnsCheck.Checked = Config.guarantee_boss_spawn;
            bossItemsCheck.Checked = Config.force_boss_items;
            disableFleaBlacklistCheck.Checked = Config.disable_flea_blacklist;
            noFallDamageCheck.Checked = Config.no_fall_damage;
            logEverythingCheck.Checked = Config.logEverything;
            unstuckGSCheck.Checked = Config.unstuck_GS;
            revertHPCheck.Checked = Config.revert_hp;
            devModeCheck.Checked = Config.dev_mode;

            if (Config.bot_test_tier > 1 && Config.bot_test_tier <= 4)
            {
                botTierNumeric.Value = Config.bot_test_tier;
            }
            else
            {
                botTierNumeric.Value = 1;
                Config.bot_test_tier = 1;
            }

            if (Config.all_scavs == true)
            {
                botTypeCombo.SelectedItem = "All Scavs";
            }
            else if (Config.all_PMCs == true)
            {
                botTypeCombo.SelectedItem = "All PMCs";
            }
            else if (Config.all_USEC == true)
            {
                botTypeCombo.SelectedItem = "All USEC";
            }
            else if (Config.all_bear == true)
            {
                botTypeCombo.SelectedItem = "All Bear";
            }
            else
            {
                botTypeCombo.SelectedItem = "Default";
            }
        }

        private void CheckCheckBoxes() 
        {
            Color disabled = Color.SlateGray;
            Color enabled = Color.FromArgb(36,36,36);

            //recoil
            if (recoilAttOverhaulCheck.Checked == true)
            {
                legacyRecoilCheck.Checked = false;
                legacyRecoilCheck.Enabled = false;
                unstuckGSCheck.Enabled = true;
                attachPresetCombo.Enabled = true;
                weapPresetCombo.Enabled = true;
            }
            else
            {
                legacyRecoilCheck.Enabled = true;
                unstuckGSCheck.Enabled = false;
                unstuckGSCheck.Checked = false;
                attachPresetCombo.Enabled = false;
                weapPresetCombo.Enabled = false;
            }
            if (legacyRecoilCheck.Checked == true)
            {
                recoilAttOverhaulCheck.Checked = false;
                recoilAttOverhaulCheck.Enabled = false;
            }
            else
            {
                recoilAttOverhaulCheck.Enabled = true;
            }

            //ballistics
            if (realBallisticsCheck.Checked == false) 
            {
                buffHelmetsCheck.Checked = false;
                buffHelmetsCheck.Enabled = false;
                realPlayerHealthCheck.Checked = false;
                realPlayerHealthCheck.Enabled = false;

                realBossHealthCheck.Checked = false;
                realBossHealthCheck.Enabled = false;
                realFollowerHealthCheck.Checked = false;
                realFollowerHealthCheck.Enabled = false;
                realRRHealthCheck.Checked = false;
                realRRHealthCheck.Enabled = false;
                realCultistHealthCheck.Checked = false;
                realCultistHealthCheck.Enabled = false;
            }
            else
            {
                buffHelmetsCheck.Enabled = true;
                realPlayerHealthCheck.Enabled = true;

                realBossHealthCheck.Enabled = true;
                realFollowerHealthCheck.Enabled = true;
                realRRHealthCheck.Enabled = true;
                realCultistHealthCheck.Enabled = true;
            }


            //realistic player HP
            if (realPlayerHealthCheck.Checked == true)
            {
                revertHPCheck.Checked = false;
                revertHPCheck.Enabled = false;
            }
            else
            {
                revertHPCheck.Enabled = true;
            }
            //revert HP
            if (revertHPCheck.Checked == true)
            {
                realPlayerHealthCheck.Checked = false;
                realPlayerHealthCheck.Enabled = false;
            }
            else
            {
                realPlayerHealthCheck.Enabled = true;
            }

            //health
            if (medChangesCheck.Checked == true)
            {
                revertMedsCheck.Checked = false;
                revertMedsCheck.Enabled = false;
            }
            else
            {
                revertMedsCheck.Enabled = true;
            }

            //bots
            if (pmcNamesCheck.Checked == false)
            {
                cyrillicNamesCheck.Checked = false;
                cyrillicNamesCheck.Enabled = false;
            }
            else
            {
                cyrillicNamesCheck.Enabled = true;
            }
    
  
            //testing
            if (botTestingCheck.Checked == false)
            {
                enableBotWeapsCheck.Checked = false;
                enableBotWeapsCheck.Enabled = false;

                botTypeCombo.Enabled = false;
                botTierNumeric.Enabled = false;
            }
            else
            {
                enableBotWeapsCheck.Enabled = true;

                botTypeCombo.Enabled = true;
                botTierNumeric.Enabled = true;

            }

            foreach (TabPage p in this.mainTabControl.TabPages)
            {
                foreach (Control c in p.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb = (CheckBox)c;
                        if (cb.Enabled == false)
                        {
                            cb.BackColor = disabled;
                        }
                        else
                        {
                            cb.BackColor = enabled;
                        }
                    }
                    if (c is GroupBox)
                    {
                        foreach (Control gc in c.Controls)
                        {
                            if (gc is CheckBox)
                            {
                                CheckBox gcb = (CheckBox)gc;
                                if (gcb.Enabled == false)
                                {
                                    gcb.BackColor = disabled;
                                }
                                else
                                {
                                    gcb.BackColor = enabled;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Timer(Label label)
        {
            var t = new Timer();
            t.Interval = 700;
            t.Tick += (s, e) =>
            {
                label.ForeColor = label.BackColor;
                t.Stop();
            };
            t.Start();
        }

        private void realPlayerHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.realistic_player_health = realPlayerHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realismCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.realistic_ballistics = realBallisticsCheck.Checked == true ? true : false;

            if (realBallisticsCheck.Checked == true)
            {
                realPlayerHealthCheck.Checked = true;
            }
      
            CheckCheckBoxes();

        }
        private void recoilAttOverhaulCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.recoil_attachment_overhaul = recoilAttOverhaulCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void legacyRecoilCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.legacy_recoil_changes = legacyRecoilCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }
        private void masteryCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.mastery_changes = masteryCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void buffHelmetsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.buff_helmets = buffHelmetsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void armorMousePenaltyCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.armor_mouse_penalty = armorMousePenaltyCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void headgearConflictsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.headgear_conflicts = headgearConflictsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void malfChanges_CheckedChanged(object sender, EventArgs e)
        {
            Config.malf_changes = malfChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void medChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.med_changes = medChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void revertMedsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.revert_med_changes = revertMedsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void movementChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.movement_changes = movementChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void fallDamageChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.fall_damage_changes = fallDamageChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void botChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.bot_changes = botChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void increasedBotCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.increased_bot_cap = increasedBotCapCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }


        private void bossSpawnCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.boss_spawns = bossSpawnCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void openZonesFixCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.open_zones_fix = openZonesFixCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realBossHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.realistic_boss_health = realBossHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realFollowerHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.realistic_boss_follower_health = realFollowerHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realRRHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.realistic_raider_rogue_health = realRRHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realCultistHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.realistic_cultist_health = realCultistHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void pmcTypeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.pmc_types = pmcTypeCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void pmcDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.pmc_difficulty = pmcDifficultyCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void bossDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.boss_difficulty = bossDifficultyCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void pmcNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.bot_names = pmcNamesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }
        private void cyrillicNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.cyrillic_bear_names = cyrillicNamesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void tieredFleaCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.tiered_flea = tieredFleaCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void fleaConfigCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.flea_changes = fleaConfigCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void traderChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.trader_changes = traderChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void allExaminedCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.all_examined = allExaminedCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void removeRaidRestrictionsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.remove_inraid_restrictions = removeRaidRestrictionsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void firCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.remove_fir_req = firCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void airdropChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.airdrop_changes = airdropChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void botTestingCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.bot_testing = botTestingCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void botTierNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.bot_test_tier = (int)botTierNumeric.Value;
            CheckCheckBoxes();
        }

        private void botTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)botTypeCombo.SelectedItem == "Default")
            {
                Config.all_bear = false;
                Config.all_USEC = false;
                Config.all_PMCs = false;
                Config.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All Scavs")
            {
                Config.all_bear = false;
                Config.all_USEC = false;
                Config.all_PMCs = false;
                Config.all_scavs = true;
            }
            if ((string)botTypeCombo.SelectedItem == "All PMCs")
            {
                Config.all_bear = false;
                Config.all_USEC = false;
                Config.all_PMCs = true;
                Config.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All Bear")
            {
                Config.all_bear = true;
                Config.all_USEC = false;
                Config.all_PMCs = false;
                Config.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All USEC")
            {
                Config.all_bear = false;
                Config.all_USEC = true;
                Config.all_PMCs = false;
                Config.all_scavs = false;
            }
            CheckCheckBoxes();
        }


        private void enableBotWeapsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.bot_test_weps_enabled = enableBotWeapsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void bossSpawnsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.guarantee_boss_spawn = bossSpawnsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void bossItemsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.force_boss_items = bossItemsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void disableFleaBlacklistCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.disable_flea_blacklist = disableFleaBlacklistCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void noFallDamageCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.no_fall_damage = noFallDamageCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void logEverythingCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.logEverything = logEverythingCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void devModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.dev_mode = devModeCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void unstuckGSCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.unstuck_GS = unstuckGSCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void revertHPCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.revert_hp = revertHPCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void vertRecNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.vert_recoil_multi = vertRecNumeric.Value;
            CheckCheckBoxes();
        }

        private void horzRecNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.horz_recoil_multi = horzRecNumeric.Value;
            CheckCheckBoxes();
        }

        private void convNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.convergence_multi = convNumeric.Value;
            CheckCheckBoxes();
        }

        private void dispNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.dispersion_multi = dispNumeric.Value;
            CheckCheckBoxes();
        }

        private void ergoNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.ergo_multi = ergoNumeric.Value;
            CheckCheckBoxes();
        }

        private void procNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.procedural_intensity = procNumeric.Value;
            CheckCheckBoxes();
        }

        private void crankCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.recoil_crank = crankCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void weapPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.weap_preset = weapPresetCombo.SelectedItem.ToString();
            CheckCheckBoxes();
        }

        private void attachPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.att_preset = attachPresetCombo.SelectedItem.ToString();
            CheckCheckBoxes();
        }

        private void standardHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.standard_bot_hp_multi= standardHPNumeric.Value;
            CheckCheckBoxes();
        }

        private void midHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.mid_bot_hp_multi = midHPNumeric.Value;
            CheckCheckBoxes();
        }

        private void bossHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.boss_bot_hp_multi = bossHPNumeric.Value;
            CheckCheckBoxes();
        }

        private void weightCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.weight_limits_changes = weightCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(ConfigFilePath, JsonConvert.SerializeObject(Config));
            savedLabel.ForeColor = Color.GreenYellow;
            Timer(savedLabel);
        }
        private void revertButton_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
            SetDisplayValues();
            File.WriteAllText(ConfigFilePath, JsonConvert.SerializeObject(Config));
            revertLabel.ForeColor = Color.DarkOrange;
            Timer(revertLabel);
        }

        public class ConfigTemplate
        {
            public bool realistic_player_health { get; set; }
            public bool realistic_ballistics { get; set; }
            public bool buff_helmets { get; set; }
            public bool armor_mouse_penalty { get; set; }
            public bool headgear_conflicts { get; set; }
            public bool recoil_attachment_overhaul { get; set; }
            public bool mastery_changes { get; set; }
            public bool malf_changes { get; set; }
            public bool movement_changes { get; set; }
            public bool weight_limits_changes { get; set; }
            public bool fall_damage_changes { get; set; }
            public bool med_changes { get; set; }
            public bool revert_med_changes { get; set; }
            public bool bot_changes { get; set; }
            public bool increased_bot_cap { get; set; }
            public bool realistic_boss_health { get; set; }
            public bool realistic_boss_follower_health { get; set; }
            public bool realistic_raider_rogue_health { get; set; }
            public bool realistic_cultist_health { get; set; }
            public bool open_zones_fix { get; set; }
            public bool boss_spawns { get; set; }
            public bool pmc_difficulty { get; set; }
            public bool boss_difficulty { get; set; }
            public bool pmc_types { get; set; }
            public bool bot_names { get; set; }
            public bool cyrillic_bear_names { get; set; }
            public bool tiered_flea { get; set; }
            public bool flea_changes { get; set; }
            public bool trader_changes { get; set; }
            public bool airdrop_changes { get; set; }
            public bool all_examined { get; set; }
            public bool remove_inraid_restrictions { get; set; }
            public bool remove_fir_req { get; set; }
            public bool legacy_recoil_changes { get; set; }
            public bool bot_testing { get; set; }
            public bool bot_test_weps_enabled { get; set; }
            public int bot_test_tier { get; set; }
            public bool all_scavs { get; set; }
            public bool all_USEC { get; set; }
            public bool all_bear { get; set; }
            public bool all_PMCs { get; set; }
            public bool dev_mode { get; set; }
            public bool guarantee_boss_spawn { get; set; }
            public bool disable_flea_blacklist { get; set; }
            public bool no_fall_damage { get; set; }
            public bool logEverything { get; set; }
            public bool unstuck_GS { get; set; }
            public bool force_boss_items { get; set; }
            public bool revert_hp { get; set; }
            public string weap_preset { get; set; }
            public string att_preset { get; set; }
            public bool recoil_crank { get; set; }
            public decimal procedural_intensity { get; set; }
            public decimal vert_recoil_multi { get; set; }
            public decimal horz_recoil_multi { get; set; }
            public decimal convergence_multi { get; set; }
            public decimal dispersion_multi { get; set; }
            public decimal ergo_multi { get; set; }
            public decimal standard_bot_hp_multi { get; set; }
            public decimal mid_bot_hp_multi { get; set; }
            public decimal boss_bot_hp_multi { get; set; }

        }

    }
}