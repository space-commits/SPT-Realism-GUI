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

        public static string gearFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db/templates/gear/");
        public static DirectoryInfo gearDI = new DirectoryInfo(gearFilePath);
        public static DirectoryInfo[] gearPresetFilePath = gearDI.GetDirectories();


        public Main_Form()
        {
            InitializeComponent();
            setTitleBar();
            setNumericLimits();

            try
            {
                warningTextBox.Hide();
                SetDisplayValues();
                SetPresetComboBoxes(weapPresetFilePath, weapPresetCombo);
                SetPresetComboBoxes(attPresetFilePath, attachPresetCombo);
                SetPresetComboBoxes(gearPresetFilePath, gearPresetCombo);
            }
            catch (Exception exception)
            {
                warningTextBox.Show();
                warningTextBox.Text = $"{exception.Message}  \n\nMake sure this app is located in the 'SPT-Realism-Mod' folder, and make sure the 'config.json' file is located in 'config\\config.json'";
            }
        }


        private void setTitleBar()
        {
            string modVer = "v0.7.12";
            string sptVer = "v3.5.5";

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

            decimal botHostMin = 0.0m;
            decimal botHostMax = 100.0m;
            decimal botHostInc = 1.0m;
            int botHostDeci = 0;



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

            camRecNumeric.Minimum = recoilMultiMin;
            camRecNumeric.Maximum = recoilMultiMax;
            camRecNumeric.Increment = increment;
            camRecNumeric.DecimalPlaces = decimalPlaces;

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

            hostNum1.Minimum = botHostMin;
            hostNum1.Maximum = botHostMax;
            hostNum1.Increment = botHostInc;
            hostNum1.DecimalPlaces = botHostDeci;

            hostNum2.Minimum = botHostMin;
            hostNum2.Maximum = botHostMax;
            hostNum2.Increment = botHostInc;
            hostNum2.DecimalPlaces = botHostDeci;

            hostNum3.Minimum = botHostMin;
            hostNum3.Maximum = botHostMax;
            hostNum3.Increment = botHostInc;
            hostNum3.DecimalPlaces = botHostDeci;

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

            /*         vertRecNumeric.Value = 1.0m;
                     horzRecNumeric.Value = 1.0m;
                     convNumeric.Value = 1.0m;
                     dispNumeric.Value = 1.0m;
                     ergoNumeric.Value = 1.0m;
                     camRecNumeric.Value = 1.0m;

                     hostNum1.Value = 95.0m;
                     hostNum2.Value = 99.0m;
                     hostNum3.Value = 100.0m;

                     standardHPNumeric.Value = 1.0m;
                     midHPNumeric.Value = 1.0m;
                     bossHPNumeric.Value = 1.0m;

                     crankCheck.Checked = true;

                     weapPresetCombo.SelectedItem = "Realism";
                     attachPresetCombo.SelectedItem = "Realism";*/

            Config.vert_recoil_multi = 1.0m;
            Config.horz_recoil_multi = 1.0m;
            Config.convergence_multi = 1.0m;
            Config.dispersion_multi = 1.0m;
            Config.ergo_multi = 1.0m;
            Config.cam_multi = 1.0m;

            Config.bot_hostile1 = 95;
            Config.bot_hostile2 = 99;
            Config.bot_hostile3 = 100;

            Config.standard_bot_hp_multi = 1.0m;
            Config.mid_bot_hp_multi = 1.0m;
            Config.boss_bot_hp_multi = 1.0m;

            Config.recoil_crank = true;

            Config.weap_preset = "Realism";
            Config.att_preset = "Realism";
            Config.gear_preset = "Realism";

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
            Config.weight_limits_changes = true;
            Config.headset_changes = true;
            Config.movement_changes = true;
            Config.fall_damage_changes = true;
            Config.bot_changes = true;
            Config.increased_bot_cap = false;
            Config.open_zones_fix = true;
            Config.boss_spawns = true;
            Config.spawn_waves = true;
            Config.realistic_boss_health = true;
            Config.realistic_boss_follower_health = true;
            Config.realistic_raider_rogue_health = true;
            Config.realistic_cultist_health = true;
            Config.pmc_difficulty = false;
            Config.boss_difficulty = false;
            Config.pmc_types = true;
            Config.bot_names = true;
            Config.cyrillic_bear_names = true;
            Config.tiered_flea = true;
            Config.flea_changes = true;
            Config.trader_changes = true;
            Config.all_examined = true;
            Config.remove_inraid_restrictions = true;
            Config.remove_quest_fir_req = true;
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
            Config.revert_hp = false;
            Config.botTierOdds1 = new int[] { 92, 5, 2, 1 };
            Config.botTierOdds2 = new int[] { 82, 15, 2, 1 };
            Config.botTierOdds3 = new int[] { 38, 57, 4, 1 };
            Config.botTierOdds4 = new int[] { 10, 85, 4, 1 };
            Config.botTierOdds5 = new int[] { 8, 69, 21, 2 };
            Config.botTierOdds6 = new int[] { 5, 50, 40, 5 };
            Config.botTierOdds7 = new int[] { 5, 20, 70, 5 };
            Config.botTierOdds8 = new int[] { 3, 18, 64, 15 };

            Config.trader_repair_changes = true;
            Config.change_trader_ll = true;
            Config.add_cust_trader_items = true;
            Config.randomize_traders = true;
            Config.randomize_trader_ll = true;
            Config.randomize_trader_stock = true;
            Config.adjust_trader_prices = true;
            Config.randomize_trader_prices = true;

            Config.old_ballistics = false;

            Config.backup_profiles = true;

            Config.dynamic_loot_bots = false;

            Config.rand_stock_modifier = 0;
            Config.rand_stackable_modifier = 1m;
            Config.rand_cost_discount = 0.85m;
            Config.rand_cost_increase = 1.15m;
            Config.trader_refresh_time = 1800;

            CheckCheckBoxes();
        }

        private void SetDisplayValues()
        {
            vertRecNumeric.Value = (decimal)Config.vert_recoil_multi;
            horzRecNumeric.Value = (decimal)Config.horz_recoil_multi;
            convNumeric.Value = (decimal)Config.convergence_multi;
            dispNumeric.Value = (decimal)Config.dispersion_multi;
            ergoNumeric.Value = (decimal)Config.ergo_multi;
            camRecNumeric.Value = (decimal)Config.cam_multi;

            hostNum1.Value = (decimal)Config.bot_hostile1;
            hostNum2.Value = (decimal)Config.bot_hostile2;
            hostNum3.Value = (decimal)Config.bot_hostile3;

            standardHPNumeric.Value = (decimal)Config.standard_bot_hp_multi;
            midHPNumeric.Value = (decimal)Config.mid_bot_hp_multi;
            bossHPNumeric.Value = (decimal)Config.boss_bot_hp_multi;

            crankCheck.Checked = Config.recoil_crank;

            weapPresetCombo.SelectedItem = Config.weap_preset;
            attachPresetCombo.SelectedItem = Config.att_preset;
            gearPresetCombo.SelectedItem = Config.gear_preset;
            weapPresetCombo.Text = Config.weap_preset;
            attachPresetCombo.Text = Config.att_preset;
            gearPresetCombo.Text = Config.gear_preset;

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
            headsetCheck.Checked = Config.headset_changes;
            fallDamageChangesCheck.Checked = Config.fall_damage_changes;

            botOdds1Text.Text = intArrToString(Config.botTierOdds1);
            botOdds2Text.Text = intArrToString(Config.botTierOdds2);
            botOdds3Text.Text = intArrToString(Config.botTierOdds3);
            botOdds4Text.Text = intArrToString(Config.botTierOdds4);
            botOdds5Text.Text = intArrToString(Config.botTierOdds5);
            botOdds6Text.Text = intArrToString(Config.botTierOdds6);
            botOdds7Text.Text = intArrToString(Config.botTierOdds7);
            botOdds8Text.Text = intArrToString(Config.botTierOdds8);

            botChangesCheck.Checked = Config.bot_changes;
            increasedBotCapCheck.Checked = Config.increased_bot_cap;
            openZonesFixCheck.Checked = Config.open_zones_fix;
            bossSpawnCheck.Checked = Config.boss_spawns;
            spawnWaveCheck.Checked = Config.spawn_waves;
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
            firQuestCheck.Checked = Config.remove_quest_fir_req;
            airdropChangesCheck.Checked = Config.airdrop_changes;

            botTestingCheck.Checked = Config.bot_testing;
            enableBotWeapsCheck.Checked = Config.bot_test_weps_enabled;
            bossSpawnsCheck.Checked = Config.guarantee_boss_spawn;
            bossItemsCheck.Checked = Config.force_boss_items;
            disableFleaBlacklistCheck.Checked = Config.disable_flea_blacklist;
            noFallDamageCheck.Checked = Config.no_fall_damage;
            logEverythingCheck.Checked = Config.logEverything;
            revertHPCheck.Checked = Config.revert_hp;

            tradAdjustPriceCheck.Checked = Config.adjust_trader_prices;
            tradRepairCheck.Checked = Config.trader_repair_changes;
            traderllCheck.Checked = Config.change_trader_ll;
            tradCustItemCheck.Checked = Config.add_cust_trader_items;
            randTradCheck.Checked = Config.randomize_traders;
            randTradLLCheck.Checked = Config.randomize_trader_ll;
            randTradStockCheck.Checked = Config.randomize_trader_stock;
            randTradPriceCheck.Checked = Config.randomize_trader_prices;

            oldBallsCheck.Checked = Config.old_ballistics;

            backupCheck.Checked = Config.backup_profiles;

            dynBotLoot.Checked = Config.dynamic_loot_bots;

            stockModNum.Value = (decimal)Config.rand_stock_modifier;
            stackMultiNum.Value = (decimal)Config.rand_stackable_modifier;
            discountNum.Value = (decimal)Config.rand_cost_discount;
            costIncreaseNum.Value = (decimal)Config.rand_cost_increase;
            tradRefreshNum.Value = (decimal)Config.trader_refresh_time;

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
            Color enabled = Color.FromArgb(36, 36, 36);

            //recoil
            if (recoilAttOverhaulCheck.Checked == true)
            {
                legacyRecoilCheck.Checked = false;
                legacyRecoilCheck.Enabled = false;
                attachPresetCombo.Enabled = true;
                weapPresetCombo.Enabled = true;
            }
            else
            {
                legacyRecoilCheck.Enabled = true;
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
                oldBallsCheck.Enabled = true;

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
                oldBallsCheck.Enabled = false;

                realBossHealthCheck.Enabled = true;
                realFollowerHealthCheck.Enabled = true;
                realRRHealthCheck.Enabled = true;
                realCultistHealthCheck.Enabled = true;
            }


            if (oldBallsCheck.Checked == true)
            {
                realBallisticsCheck.Enabled = false;
            }
            else
            {
                realBallisticsCheck.Enabled = true;
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

            //bot names
            if (pmcNamesCheck.Checked == false)
            {
                cyrillicNamesCheck.Checked = false;
                cyrillicNamesCheck.Enabled = false;
            }
            else
            {
                cyrillicNamesCheck.Enabled = true;
            }

            //traders
            if (randTradCheck.Checked == false)
            {
                randTradLLCheck.Checked = false;
                randTradLLCheck.Enabled = false;

                randTradStockCheck.Checked = false;
                randTradStockCheck.Enabled = false;

                randTradPriceCheck.Checked = false;
                randTradPriceCheck.Enabled = false;

                stockModNum.Enabled = false;
                stackMultiNum.Enabled = false;
                discountNum.Enabled = false;
                costIncreaseNum.Enabled = false;
            }
            else
            {
                randTradLLCheck.Enabled = true;

                randTradStockCheck.Enabled = true;

                randTradPriceCheck.Enabled = true;

                stockModNum.Enabled = true;
                stackMultiNum.Enabled = true;
                discountNum.Enabled = true;
                costIncreaseNum.Enabled = true;
            }

            //bot changes
            if (botChangesCheck.Checked == false)
            {
                botOdds1Text.Enabled = false;
                botOdds2Text.Enabled = false;
                botOdds3Text.Enabled = false;
                botOdds4Text.Enabled = false;
                botOdds5Text.Enabled = false;
                botOdds6Text.Enabled = false;
                botOdds7Text.Enabled = false;
                botOdds8Text.Enabled = false;
            }
            else
            {
                botOdds1Text.Enabled = true;
                botOdds2Text.Enabled = true;
                botOdds3Text.Enabled = true;
                botOdds4Text.Enabled = true;
                botOdds5Text.Enabled = true;
                botOdds6Text.Enabled = true;
                botOdds7Text.Enabled = true;
                botOdds8Text.Enabled = true;
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

        private void spawnWaveCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.spawn_waves = spawnWaveCheck.Checked == true ? true : false;
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

        private void firQuestCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.remove_quest_fir_req = firQuestCheck.Checked == true ? true : false;
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

        private void camRecNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.cam_multi = camRecNumeric.Value;
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

        private void gearPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.gear_preset = gearPresetCombo.SelectedItem.ToString();
            CheckCheckBoxes();
        }

        private void standardHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            Config.standard_bot_hp_multi = standardHPNumeric.Value;
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

        private void headsetCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.headset_changes = headsetCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void botHost1_ValueChanged(object sender, EventArgs e)
        {
            Config.bot_hostile1 = (int)hostNum1.Value;
            CheckCheckBoxes();
        }

        private void botHost2_ValueChanged(object sender, EventArgs e)
        {
            Config.bot_hostile2 = (int)hostNum2.Value;
            CheckCheckBoxes();
        }

        private void botHost3_ValueChanged(object sender, EventArgs e)
        {
            Config.bot_hostile3 = (int)hostNum3.Value;
            CheckCheckBoxes();
        }

        private void tradRepairCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.trader_repair_changes = tradRepairCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void traderllCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.change_trader_ll = traderllCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void tradCustItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.add_cust_trader_items = tradCustItemCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void tradAdjustPriceCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.adjust_trader_prices = tradAdjustPriceCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void randTradCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.randomize_traders = randTradCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void randTradLLCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.randomize_trader_ll = randTradLLCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void randTradStockCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.randomize_trader_stock = randTradStockCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void randTradPriceCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.randomize_trader_prices = randTradPriceCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void stockModNum_ValueChanged(object sender, EventArgs e)
        {
            Config.rand_stock_modifier = (int)stockModNum.Value;
            CheckCheckBoxes();
        }

        private void stackMultiNum_ValueChanged(object sender, EventArgs e)
        {
            Config.rand_stackable_modifier = stackMultiNum.Value;
            CheckCheckBoxes();
        }

        private void discountNum_ValueChanged(object sender, EventArgs e)
        {
            Config.rand_cost_discount = discountNum.Value;
            CheckCheckBoxes();
        }

        private void costIncreaseNum_ValueChanged(object sender, EventArgs e)
        {
            Config.rand_cost_increase = costIncreaseNum.Value;
            CheckCheckBoxes();
        }

        private void tradRefreshNum_ValueChanged(object sender, EventArgs e)
        {
            Config.trader_refresh_time = (int)tradRefreshNum.Value;
            CheckCheckBoxes();
        }


        private void oldBallsCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.old_ballistics = oldBallsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }


        private void backupCheck_CheckedChanged(object sender, EventArgs e)
        {
            Config.backup_profiles = backupCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void dynBotLoot_CheckedChanged(object sender, EventArgs e)
        {
            Config.dynamic_loot_bots = dynBotLoot.Checked == true ? true : false;
            CheckCheckBoxes();
        }



        private void validateBotTierText()
        {
            Config.botTierOdds1 = stringToIntArr(stringValidationHelper(botOdds1Text.Text));
            Config.botTierOdds2 = stringToIntArr(stringValidationHelper(botOdds2Text.Text));
            Config.botTierOdds3 = stringToIntArr(stringValidationHelper(botOdds3Text.Text));
            Config.botTierOdds4 = stringToIntArr(stringValidationHelper(botOdds4Text.Text));
            Config.botTierOdds5 = stringToIntArr(stringValidationHelper(botOdds5Text.Text));
            Config.botTierOdds6 = stringToIntArr(stringValidationHelper(botOdds6Text.Text));
            Config.botTierOdds7 = stringToIntArr(stringValidationHelper(botOdds7Text.Text));
            Config.botTierOdds8 = stringToIntArr(stringValidationHelper(botOdds8Text.Text));
        }

        private string stringValidationHelper(string str)
        {
            if (str == "" || str.Any(Char.IsLetter) || str.Contains(".") || !str.Contains(","))
            {
                throw new ArgumentException("Invalid Character(s) In Bot Tier String");
            }
            return str;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            validateBotTierText();
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

        private int[] stringToIntArr(string str)
        {
            int[] arr = Array.ConvertAll(str.Split(','), int.Parse);
            if (arr.Length < 4 || arr.Length > 4)
            {
                throw new ArgumentException("Bot Tier Array Has Too Few Or Too Many Tiers");
            }
            return arr;
        }

        private string intArrToString(int[] intArr)
        {
            return string.Join(",", intArr);
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
            public bool spawn_waves { get; set; }
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
            public bool remove_quest_fir_req { get; set; }
            public bool legacy_recoil_changes { get; set; }
            public bool bot_testing { get; set; }
            public bool bot_test_weps_enabled { get; set; }
            public int bot_test_tier { get; set; }
            public bool all_scavs { get; set; }
            public bool all_USEC { get; set; }
            public bool all_bear { get; set; }
            public bool all_PMCs { get; set; }
            public bool guarantee_boss_spawn { get; set; }
            public bool disable_flea_blacklist { get; set; }
            public bool no_fall_damage { get; set; }
            public bool logEverything { get; set; }
            public bool force_boss_items { get; set; }
            public bool revert_hp { get; set; }
            public string weap_preset { get; set; }
            public string att_preset { get; set; }
            public string gear_preset { get; set; }
            public bool recoil_crank { get; set; }
            public decimal vert_recoil_multi { get; set; }
            public decimal horz_recoil_multi { get; set; }
            public decimal convergence_multi { get; set; }
            public decimal dispersion_multi { get; set; }
            public decimal ergo_multi { get; set; }
            public decimal cam_multi { get; set; }
            public decimal standard_bot_hp_multi { get; set; }
            public decimal mid_bot_hp_multi { get; set; }
            public decimal boss_bot_hp_multi { get; set; }
            public bool headset_changes { get; set; }
            public int[] botTierOdds1 { get; set; }
            public int[] botTierOdds2 { get; set; }
            public int[] botTierOdds3 { get; set; }
            public int[] botTierOdds4 { get; set; }
            public int[] botTierOdds5 { get; set; }
            public int[] botTierOdds6 { get; set; }
            public int[] botTierOdds7 { get; set; }
            public int[] botTierOdds8 { get; set; }
            public int bot_hostile1 { get; set; }
            public int bot_hostile2 { get; set; }
            public int bot_hostile3 { get; set; }
            public bool trader_repair_changes { get; set; }
            public bool change_trader_ll { get; set; }
            public bool add_cust_trader_items { get; set; }
            public bool randomize_traders { get; set; }
            public bool randomize_trader_ll { get; set; }
            public bool randomize_trader_stock { get; set; }
            public bool adjust_trader_prices { get; set; }
            public bool randomize_trader_prices { get; set; }
            public int rand_stock_modifier { get; set; }
            public decimal rand_stackable_modifier { get; set; }
            public decimal rand_cost_discount { get; set; }
            public decimal rand_cost_increase { get; set; }
            public int trader_refresh_time { get; set; }
            public bool old_ballistics { get; set; }
            public bool backup_profiles { get; set; }
            public bool dynamic_loot_bots { get; set; }
        }


    }
}