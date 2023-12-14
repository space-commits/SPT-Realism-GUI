using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Realism_Mod_Config_GUI
{
    public partial class Main_Form : Form
    {

        public static string configFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"config\config.json");
        public static string configJSON = File.ReadAllText(configFilePath);
        public static ConfigTemplate config = JsonConvert.DeserializeObject<ConfigTemplate>(configJSON);

        public static string weapFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\weapons\");
        public static DirectoryInfo weapDI = new DirectoryInfo(weapFilePath);
        public static DirectoryInfo[] weapPresetFilePath = weapDI.GetDirectories();

        public static string attFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\attatchments\");
        public static DirectoryInfo attDI = new DirectoryInfo(attFilePath);
        public static DirectoryInfo[] attPresetFilePath = attDI.GetDirectories();

        public static string gearFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\gear\");
        public static DirectoryInfo gearDI = new DirectoryInfo(gearFilePath);
        public static DirectoryInfo[] gearPresetFilePath = gearDI.GetDirectories();

        public static string packagePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"package.json");
        public static string packageJSON = File.ReadAllText(packagePath);
        public static PackageTemplate package = JsonConvert.DeserializeObject<PackageTemplate>(packageJSON);

        public Main_Form()
        {
            try
            {
                InitializeComponent();
                setTitleBar();
                setNumericLimits();
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
            string modVer = "v" + package.version;
            string sptVer = "v" + package.akiVersion;

            this.Text = "SPT Realism Mod Config SPTRM " + modVer + " SPT " + sptVer;

            modVerLabel.Text = modVer;
        }

        private void setNumericLimits()
        {
            decimal hpMultiMax = 10.0m;
            decimal hpMultiMin = 0.1m;
            decimal increment = 0.1m;
            int decimalPlaces = 2;

            decimal botHostMin = 0.0m;
            decimal botHostMax = 100.0m;
            decimal botHostInc = 1.0m;
            int botHostDeci = 0;

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

            playerHPNumeric.Minimum = hpMultiMin;
            playerHPNumeric.Maximum = hpMultiMax;
            playerHPNumeric.Increment = increment;
            playerHPNumeric.DecimalPlaces = decimalPlaces;

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

            config.bot_hostile1 = 95;
            config.bot_hostile2 = 99;
            config.bot_hostile3 = 100;

            config.standard_bot_hp_multi = 1.0m;
            config.mid_bot_hp_multi = 1.0m;
            config.boss_bot_hp_multi = 1.0m;
            config.player_hp_multi = 1.0m;
            config.weap_preset = "Realism";
            config.att_preset = "Realism";
            config.gear_preset = "Realism";

            config.realistic_player_health = true;
            config.realistic_ballistics = true;
            config.recoil_attachment_overhaul = true;
            config.mastery_changes = true;
            config.buff_helmets = false;
            config.headgear_conflicts = true;
            config.malf_changes = true;
            config.med_changes = true;
            config.revert_med_changes = false;
            config.weight_limits_changes = true;
            config.headset_changes = true;
            config.movement_changes = true;
            config.fall_damage_changes = true;
            config.bot_changes = true;
            config.bot_loot_changes = true;
            config.increased_bot_cap = false;
            config.open_zones_fix = true;
            config.boss_spawns = true;
            config.spawn_waves = true;
            config.realistic_boss_health = true;
            config.realistic_boss_follower_health = true;
            config.realistic_raider_rogue_health = true;
            config.realistic_cultist_health = true;
            config.pmc_difficulty = false;
            config.boss_difficulty = false;
            config.pmc_types = true;
            config.bot_names = true;
            config.cyrillic_bear_names = true;
            config.tiered_flea = true;
            config.flea_changes = true;
            config.change_buy_categories = true;
            config.nerf_fence = true;
            config.all_examined = true;
            config.remove_inraid_restrictions = true;
            config.remove_quest_fir_req = true;
            config.remove_fir_req = true;
            config.airdrop_changes = true;
            config.bot_testing = false;
            config.bot_test_tier = 1;
            config.all_bear = false;
            config.all_USEC = false;
            config.all_PMCs = false;
            config.all_scavs = false;
            config.bot_test_weps_enabled = true;
            config.guarantee_boss_spawn = false;
            config.force_boss_items = false;
            config.disable_flea_blacklist = false;
            config.no_fall_damage = false;
            config.logEverything = false;
            config.revert_hp = false;
            config.botTierOdds1 = new int[] { 90, 7, 2, 1, 0 };
            config.botTierOdds2 = new int[] { 80, 15, 3, 2, 0 };
            config.botTierOdds3 = new int[] { 30, 52, 13, 5, 0 };
            config.botTierOdds4 = new int[] { 10, 58, 22, 7, 3 };
            config.botTierOdds5 = new int[] { 8, 38, 32, 17, 5 };
            config.botTierOdds6 = new int[] { 5, 25, 40, 23, 7 };
            config.botTierOdds7 = new int[] { 4, 15, 35, 33, 12 };
            config.botTierOdds8 = new int[] { 3, 8, 28, 40, 22 };
            config.botTierOdds9 = new int[] { 3, 7, 15, 35, 40 };
            config.trader_repair_changes = true;
            config.change_trader_ll = true;
            config.add_cust_trader_items = true;
            config.randomize_traders = true;
            config.randomize_trader_ll = true;
            config.randomize_trader_stock = true;
            config.adjust_trader_prices = true;
            config.randomize_trader_prices = true;
            config.change_heal_cost = true;
            config.change_buy_price = true;

            config.backup_profiles = true;

            config.dynamic_loot_pmcs = false;
            config.dynamic_loot_scavs = false;
            config.add_keys = false;

            config.rand_stock_modifier = 0;
            config.rand_stackable_modifier = 1m;
            config.rand_cost_discount = 0.85m;
            config.rand_cost_increase = 1.15m;
            config.trader_refresh_time = 1800;

            CheckCheckBoxes();
        }

        private void SetDisplayValues()
        {
            hostNum1.Value = (decimal)config.bot_hostile1;
            hostNum2.Value = (decimal)config.bot_hostile2;
            hostNum3.Value = (decimal)config.bot_hostile3;

            standardHPNumeric.Value = (decimal)config.standard_bot_hp_multi;
            midHPNumeric.Value = (decimal)config.mid_bot_hp_multi;
            bossHPNumeric.Value = (decimal)config.boss_bot_hp_multi;
            playerHPNumeric.Value = (decimal)config.player_hp_multi;

            weapPresetCombo.SelectedItem = config.weap_preset;
            attachPresetCombo.SelectedItem = config.att_preset;
            gearPresetCombo.SelectedItem = config.gear_preset;
            weapPresetCombo.Text = config.weap_preset;
            attachPresetCombo.Text = config.att_preset;
            gearPresetCombo.Text = config.gear_preset;

            realPlayerHealthCheck.Checked = config.realistic_player_health;
            realBallisticsCheck.Checked = config.realistic_ballistics;
            recoilAttOverhaulCheck.Checked = config.recoil_attachment_overhaul;
            malfChangesCheck.Checked = config.malf_changes;
            masteryCheck.Checked = config.mastery_changes;
            buffHelmetsCheck.Checked = config.buff_helmets;
            headgearConflictsCheck.Checked = config.headgear_conflicts;

            medChangesCheck.Checked = config.med_changes;
            revertMedsCheck.Checked = config.revert_med_changes;
            movementChangesCheck.Checked = config.movement_changes;
            weightCheck.Checked = config.weight_limits_changes;
            headsetCheck.Checked = config.headset_changes;
            fallDamageChangesCheck.Checked = config.fall_damage_changes;

            botOdds1Text.Text = intArrToString(config.botTierOdds1);
            botOdds2Text.Text = intArrToString(config.botTierOdds2);
            botOdds3Text.Text = intArrToString(config.botTierOdds3);
            botOdds4Text.Text = intArrToString(config.botTierOdds4);
            botOdds5Text.Text = intArrToString(config.botTierOdds5);
            botOdds6Text.Text = intArrToString(config.botTierOdds6);
            botOdds7Text.Text = intArrToString(config.botTierOdds7);
            botOdds8Text.Text = intArrToString(config.botTierOdds8);
            botOdds9Text.Text = intArrToString(config.botTierOdds9);

            botChangesCheck.Checked = config.bot_changes;
            botLootCheck.Checked = config.bot_loot_changes;
            increasedBotCapCheck.Checked = config.increased_bot_cap;
            openZonesFixCheck.Checked = config.open_zones_fix;
            bossSpawnCheck.Checked = config.boss_spawns;
            spawnWaveCheck.Checked = config.spawn_waves;
            realBossHealthCheck.Checked = config.realistic_boss_health;
            realFollowerHealthCheck.Checked = config.realistic_boss_follower_health;
            realRRHealthCheck.Checked = config.realistic_raider_rogue_health;
            realCultistHealthCheck.Checked = config.realistic_cultist_health;
            bossDifficultyCheck.Checked = config.boss_difficulty;
            pmcDifficultyCheck.Checked = config.pmc_difficulty;
            pmcTypeCheck.Checked = config.pmc_types;
            pmcNamesCheck.Checked = config.bot_names;
            cyrillicNamesCheck.Checked = config.cyrillic_bear_names;

            tieredFleaCheck.Checked = config.tiered_flea;
            fleaConfigCheck.Checked = config.flea_changes;
            traderChangesCheck.Checked = config.change_buy_categories;
            nerfFenceCheck.Checked = config.nerf_fence;
            allExaminedCheck.Checked = config.all_examined;
            removeRaidRestrictionsCheck.Checked = config.remove_inraid_restrictions;
            firCheck.Checked = config.remove_fir_req;
            firQuestCheck.Checked = config.remove_quest_fir_req;
            airdropChangesCheck.Checked = config.airdrop_changes;

            botTestingCheck.Checked = config.bot_testing;
            enableBotWeapsCheck.Checked = config.bot_test_weps_enabled;
            bossSpawnsCheck.Checked = config.guarantee_boss_spawn;
            bossItemsCheck.Checked = config.force_boss_items;
            disableFleaBlacklistCheck.Checked = config.disable_flea_blacklist;
            noFallDamageCheck.Checked = config.no_fall_damage;
            logEverythingCheck.Checked = config.logEverything;
            revertHPCheck.Checked = config.revert_hp;

            traderCoeffCheck.Checked = config.change_buy_price;
            theraHeaCheck.Checked = config.change_heal_cost;
            tradAdjustPriceCheck.Checked = config.adjust_trader_prices;
            tradRepairCheck.Checked = config.trader_repair_changes;
            traderllCheck.Checked = config.change_trader_ll;
            tradCustItemCheck.Checked = config.add_cust_trader_items;
            randTradCheck.Checked = config.randomize_traders;
            randTradLLCheck.Checked = config.randomize_trader_ll;
            randTradStockCheck.Checked = config.randomize_trader_stock;
            randTradPriceCheck.Checked = config.randomize_trader_prices;

            backupCheck.Checked = config.backup_profiles;

            dynPMCLoot.Checked = config.dynamic_loot_pmcs;
            dynScavLoot.Checked = config.dynamic_loot_scavs;
            addKeysCheck.Checked = config.add_keys;

            stockModNum.Value = (decimal)config.rand_stock_modifier;
            stackMultiNum.Value = (decimal)config.rand_stackable_modifier;
            discountNum.Value = (decimal)config.rand_cost_discount;
            costIncreaseNum.Value = (decimal)config.rand_cost_increase;
            tradRefreshNum.Value = (decimal)config.trader_refresh_time;

            if (config.bot_test_tier > 1 && config.bot_test_tier <= 5)
            {
                botTierNumeric.Value = config.bot_test_tier;
            }
            else
            {
                botTierNumeric.Value = 1;
                config.bot_test_tier = 1;
            }

            if (config.all_scavs == true)
            {
                botTypeCombo.SelectedItem = "All Scavs";
            }
            else if (config.all_PMCs == true)
            {
                botTypeCombo.SelectedItem = "All PMCs";
            }
            else if (config.all_USEC == true)
            {
                botTypeCombo.SelectedItem = "All USEC";
            }
            else if (config.all_bear == true)
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
                attachPresetCombo.Enabled = true;
                weapPresetCombo.Enabled = true;
            }
            else
            {
                attachPresetCombo.Enabled = false;
                weapPresetCombo.Enabled = false;
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
                playerHPNumeric.Enabled = true;
            }
            else
            {
                playerHPNumeric.Enabled = false;
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
                botOdds9Text.Enabled = false;
                botLootCheck.Enabled = false;
                dynPMCLoot.Enabled = false;
                dynScavLoot.Enabled = false;
                addKeysCheck.Enabled = false;
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
                botOdds9Text.Enabled = true;
                botLootCheck.Enabled = true;
                dynPMCLoot.Enabled = true;
                dynScavLoot.Enabled = true;
                addKeysCheck.Enabled = true;
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
            config.realistic_player_health = realPlayerHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realismCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_ballistics = realBallisticsCheck.Checked == true ? true : false;

            if (realBallisticsCheck.Checked == true)
            {
                realPlayerHealthCheck.Checked = true;
            }

            CheckCheckBoxes();

        }
        private void recoilAttOverhaulCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.recoil_attachment_overhaul = recoilAttOverhaulCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void masteryCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.mastery_changes = masteryCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void buffHelmetsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.buff_helmets = buffHelmetsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void headgearConflictsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.headgear_conflicts = headgearConflictsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void malfChanges_CheckedChanged(object sender, EventArgs e)
        {
            config.malf_changes = malfChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void medChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.med_changes = medChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void revertMedsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.revert_med_changes = revertMedsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void movementChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.movement_changes = movementChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void fallDamageChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.fall_damage_changes = fallDamageChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void botChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_changes = botChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }


        private void botLootCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_loot_changes = botLootCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void increasedBotCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.increased_bot_cap = increasedBotCapCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void spawnWaveCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.spawn_waves = spawnWaveCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void bossSpawnCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.boss_spawns = bossSpawnCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void openZonesFixCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.open_zones_fix = openZonesFixCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realBossHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_boss_health = realBossHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realFollowerHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_boss_follower_health = realFollowerHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realRRHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_raider_rogue_health = realRRHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void realCultistHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_cultist_health = realCultistHealthCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void pmcTypeCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.pmc_types = pmcTypeCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void pmcDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.pmc_difficulty = pmcDifficultyCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void bossDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.boss_difficulty = bossDifficultyCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void pmcNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_names = pmcNamesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }
        private void cyrillicNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.cyrillic_bear_names = cyrillicNamesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void tieredFleaCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.tiered_flea = tieredFleaCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void fleaConfigCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.flea_changes = fleaConfigCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void traderChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.change_buy_categories = traderChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void nerfFenceCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.nerf_fence = nerfFenceCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void allExaminedCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.all_examined = allExaminedCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void removeRaidRestrictionsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.remove_inraid_restrictions = removeRaidRestrictionsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void firQuestCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.remove_quest_fir_req = firQuestCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void firCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.remove_fir_req = firCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void airdropChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.airdrop_changes = airdropChangesCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void botTestingCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_testing = botTestingCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void botTierNumeric_ValueChanged(object sender, EventArgs e)
        {
            config.bot_test_tier = (int)botTierNumeric.Value;
            CheckCheckBoxes();
        }

        private void botTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)botTypeCombo.SelectedItem == "Default")
            {
                config.all_bear = false;
                config.all_USEC = false;
                config.all_PMCs = false;
                config.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All Scavs")
            {
                config.all_bear = false;
                config.all_USEC = false;
                config.all_PMCs = false;
                config.all_scavs = true;
            }
            if ((string)botTypeCombo.SelectedItem == "All PMCs")
            {
                config.all_bear = false;
                config.all_USEC = false;
                config.all_PMCs = true;
                config.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All Bear")
            {
                config.all_bear = true;
                config.all_USEC = false;
                config.all_PMCs = false;
                config.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All USEC")
            {
                config.all_bear = false;
                config.all_USEC = true;
                config.all_PMCs = false;
                config.all_scavs = false;
            }
            CheckCheckBoxes();
        }


        private void enableBotWeapsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_test_weps_enabled = enableBotWeapsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void bossSpawnsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.guarantee_boss_spawn = bossSpawnsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void bossItemsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.force_boss_items = bossItemsCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void disableFleaBlacklistCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.disable_flea_blacklist = disableFleaBlacklistCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void noFallDamageCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.no_fall_damage = noFallDamageCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void logEverythingCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.logEverything = logEverythingCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void revertHPCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.revert_hp = revertHPCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void weapPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.weap_preset = weapPresetCombo.SelectedItem.ToString();
            CheckCheckBoxes();
        }

        private void attachPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.att_preset = attachPresetCombo.SelectedItem.ToString();
            CheckCheckBoxes();
        }

        private void gearPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.gear_preset = gearPresetCombo.SelectedItem.ToString();
            CheckCheckBoxes();
        }

        private void standardHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            config.standard_bot_hp_multi = standardHPNumeric.Value;
            CheckCheckBoxes();
        }

        private void midHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            config.mid_bot_hp_multi = midHPNumeric.Value;
            CheckCheckBoxes();
        }

        private void bossHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            config.boss_bot_hp_multi = bossHPNumeric.Value;
            CheckCheckBoxes();
        }

        private void playerHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            config.player_hp_multi = playerHPNumeric.Value;
            CheckCheckBoxes();
        }

        private void weightCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.weight_limits_changes = weightCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void headsetCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.headset_changes = headsetCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void botHost1_ValueChanged(object sender, EventArgs e)
        {
            config.bot_hostile1 = (int)hostNum1.Value;
            CheckCheckBoxes();
        }

        private void botHost2_ValueChanged(object sender, EventArgs e)
        {
            config.bot_hostile2 = (int)hostNum2.Value;
            CheckCheckBoxes();
        }

        private void botHost3_ValueChanged(object sender, EventArgs e)
        {
            config.bot_hostile3 = (int)hostNum3.Value;
            CheckCheckBoxes();
        }

        private void tradRepairCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.trader_repair_changes = tradRepairCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void traderllCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.change_trader_ll = traderllCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void tradCustItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.add_cust_trader_items = tradCustItemCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void tradAdjustPriceCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.adjust_trader_prices = tradAdjustPriceCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void randTradCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.randomize_traders = randTradCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void randTradLLCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.randomize_trader_ll = randTradLLCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void randTradStockCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.randomize_trader_stock = randTradStockCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void randTradPriceCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.randomize_trader_prices = randTradPriceCheck.Checked == true ? true : false; ;
            CheckCheckBoxes();
        }

        private void stockModNum_ValueChanged(object sender, EventArgs e)
        {
            config.rand_stock_modifier = (int)stockModNum.Value;
            CheckCheckBoxes();
        }

        private void stackMultiNum_ValueChanged(object sender, EventArgs e)
        {
            config.rand_stackable_modifier = stackMultiNum.Value;
            CheckCheckBoxes();
        }

        private void discountNum_ValueChanged(object sender, EventArgs e)
        {
            config.rand_cost_discount = discountNum.Value;
            CheckCheckBoxes();
        }

        private void costIncreaseNum_ValueChanged(object sender, EventArgs e)
        {
            config.rand_cost_increase = costIncreaseNum.Value;
            CheckCheckBoxes();
        }

        private void tradRefreshNum_ValueChanged(object sender, EventArgs e)
        {
            config.trader_refresh_time = (int)tradRefreshNum.Value;
            CheckCheckBoxes();
        }

        private void backupCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.backup_profiles = backupCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void dynBotLoot_CheckedChanged(object sender, EventArgs e)
        {
            config.dynamic_loot_pmcs = dynPMCLoot.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void dynScavLoot_CheckedChanged(object sender, EventArgs e)
        {
            config.dynamic_loot_scavs = dynScavLoot.Checked == true ? true : false;
            CheckCheckBoxes();
        }


        private void addKeysCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.add_keys = addKeysCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void theraHeaCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.change_heal_cost = theraHeaCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void traderCoeffCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.change_buy_price = traderCoeffCheck.Checked == true ? true : false;
            CheckCheckBoxes();
        }

        private void validateBotTierText()
        {
            config.botTierOdds1 = stringToIntArr(stringValidationHelper(botOdds1Text.Text));
            config.botTierOdds2 = stringToIntArr(stringValidationHelper(botOdds2Text.Text));
            config.botTierOdds3 = stringToIntArr(stringValidationHelper(botOdds3Text.Text));
            config.botTierOdds4 = stringToIntArr(stringValidationHelper(botOdds4Text.Text));
            config.botTierOdds5 = stringToIntArr(stringValidationHelper(botOdds5Text.Text));
            config.botTierOdds6 = stringToIntArr(stringValidationHelper(botOdds6Text.Text));
            config.botTierOdds7 = stringToIntArr(stringValidationHelper(botOdds7Text.Text));
            config.botTierOdds8 = stringToIntArr(stringValidationHelper(botOdds8Text.Text));
            config.botTierOdds9 = stringToIntArr(stringValidationHelper(botOdds9Text.Text));
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
            File.WriteAllText(configFilePath, JsonConvert.SerializeObject(config));
            savedLabel.ForeColor = Color.GreenYellow;
            Timer(savedLabel);
        }
        private void revertButton_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
            SetDisplayValues();
            File.WriteAllText(configFilePath, JsonConvert.SerializeObject(config));
            revertLabel.ForeColor = Color.DarkOrange;
            Timer(revertLabel);
        }

        private int[] stringToIntArr(string str)
        {
            int[] arr = Array.ConvertAll(str.Split(','), int.Parse);
            if (arr.Length != 5)
            {
                throw new ArgumentException("Bot Tier Array Has Too Few Or Too Many Tiers");
            }
            return arr;
        }

        private string intArrToString(int[] intArr)
        {
            return string.Join(",", intArr);
        }


        public class PackageTemplate
        {
            public string version { get; set; }
            public string akiVersion { get; set; }
        }


        public class ConfigTemplate
        {
            public bool realistic_player_health { get; set; }
            public bool realistic_ballistics { get; set; }
            public bool buff_helmets { get; set; }
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
            public bool bot_loot_changes { get; set; }
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
            public bool change_buy_categories { get; set; }
            public bool airdrop_changes { get; set; }
            public bool all_examined { get; set; }
            public bool remove_inraid_restrictions { get; set; }
            public bool remove_fir_req { get; set; }
            public bool remove_quest_fir_req { get; set; }
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
            public decimal standard_bot_hp_multi { get; set; }
            public decimal mid_bot_hp_multi { get; set; }
            public decimal boss_bot_hp_multi { get; set; }
            public decimal player_hp_multi { get; set; }
            public bool headset_changes { get; set; }
            public int[] botTierOdds1 { get; set; }
            public int[] botTierOdds2 { get; set; }
            public int[] botTierOdds3 { get; set; }
            public int[] botTierOdds4 { get; set; }
            public int[] botTierOdds5 { get; set; }
            public int[] botTierOdds6 { get; set; }
            public int[] botTierOdds7 { get; set; }
            public int[] botTierOdds8 { get; set; }
            public int[] botTierOdds9 { get; set; }
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
            public bool nerf_fence { get; set; }
            public int rand_stock_modifier { get; set; }
            public decimal rand_stackable_modifier { get; set; }
            public decimal rand_cost_discount { get; set; }
            public decimal rand_cost_increase { get; set; }
            public int trader_refresh_time { get; set; }
            public bool backup_profiles { get; set; }
            public bool dynamic_loot_pmcs { get; set; }
            public bool dynamic_loot_scavs { get; set; }
            public bool add_keys { get; set; }
            public bool change_buy_price { get; set; }
            public bool change_heal_cost { get; set; }
        }
    }
}