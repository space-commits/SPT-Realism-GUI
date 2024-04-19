using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using GroupBox = System.Windows.Forms.GroupBox;
using Timer = System.Windows.Forms.Timer;

namespace Realism_Mod_Config_GUI
{
    public partial class Main_Form : Form
    {

        private List<ControlRule> controlRules = new List<ControlRule>();
        private string? configFilePath;
        private ConfigTemplate? configTemplate;
        private PackageTemplate? packageTemplate;
        private DirectoryInfo[]? weapPresetFilePath;
        private DirectoryInfo[]? attPresetFilePath;
        private DirectoryInfo[]? gearPresetFilePath;

        public Main_Form()
        {
            try
            {
                InitializeComponent();
                deserializeJSON();
                setTitleBar();
                setNumericLimits();
                warningTextBox.Hide();
                setDisplayValues();
                setPresetComboBoxes(weapPresetFilePath, weapPresetCombo);
                setPresetComboBoxes(attPresetFilePath, attachPresetCombo);
                setPresetComboBoxes(gearPresetFilePath, gearPresetCombo);
                controlRules = initializeControlRules();
                evaluateControlRules();
            }
            catch (Exception exception)
            {
                warningTextBox.Show();
                warningTextBox.Text = $"{exception.Message}  \n\nMake sure this app is located in the 'SPT-Realism-Mod' folder, and make sure the 'config.json' file is located in 'config\\config.json'";
            }
        }

        private void deserializeJSON()
        {
            configFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"config\config.json");
            string configJSON = File.ReadAllText(configFilePath);
            configTemplate = JsonConvert.DeserializeObject<ConfigTemplate>(configJSON);

            string weapFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\weapons\");
            DirectoryInfo weapDI = new DirectoryInfo(weapFilePath);
            weapPresetFilePath = weapDI.GetDirectories();

            string attFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\attatchments\");
            DirectoryInfo attDI = new DirectoryInfo(attFilePath);
            attPresetFilePath = attDI.GetDirectories();

            string gearFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\gear\");
            DirectoryInfo gearDI = new DirectoryInfo(gearFilePath);
            gearPresetFilePath = gearDI.GetDirectories();

            string packagePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"package.json");
            string packageJSON = File.ReadAllText(packagePath);
            packageTemplate = JsonConvert.DeserializeObject<PackageTemplate>(packageJSON);
        }

        private void setTitleBar()
        {
            string modVer = "v" + packageTemplate.version;
            string sptVer = "v" + packageTemplate.akiVersion;

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

        private void setPresetComboBoxes(DirectoryInfo[]? dirInfoArr, ComboBox cb)
        {
            foreach (DirectoryInfo dir in dirInfoArr)
            {
                cb.Items.Add(dir.Name);
            }
        }

        private void setDisplayValues()
        {
            hostNum1.Value = (decimal)configTemplate.bot_hostile1;
            hostNum2.Value = (decimal)configTemplate.bot_hostile2;
            hostNum3.Value = (decimal)configTemplate.bot_hostile3;

            standardHPNumeric.Value = (decimal)configTemplate.standard_bot_hp_multi;
            midHPNumeric.Value = (decimal)configTemplate.mid_bot_hp_multi;
            bossHPNumeric.Value = (decimal)configTemplate.boss_bot_hp_multi;
            playerHPNumeric.Value = (decimal)configTemplate.player_hp_multi;

            weapPresetCombo.SelectedItem = configTemplate.weap_preset;
            attachPresetCombo.SelectedItem = configTemplate.att_preset;
            gearPresetCombo.SelectedItem = configTemplate.gear_preset;
            weapPresetCombo.Text = configTemplate.weap_preset;
            attachPresetCombo.Text = configTemplate.att_preset;
            gearPresetCombo.Text = configTemplate.gear_preset;

            realPlayerHealthCheck.Checked = configTemplate.realistic_player_health;
            realBallisticsCheck.Checked = configTemplate.realistic_ballistics;
            recoilAttOverhaulCheck.Checked = configTemplate.recoil_attachment_overhaul;
            malfChangesCheck.Checked = configTemplate.malf_changes;
            masteryCheck.Checked = configTemplate.mastery_changes;
            buffHelmetsCheck.Checked = configTemplate.buff_helmets;
            headgearConflictsCheck.Checked = configTemplate.headgear_conflicts;

            stanceCheck.Checked = configTemplate.enable_stances;
            comfortCheck.Checked = configTemplate.gear_weight;
            chamberCheck.Checked = configTemplate.manual_chambering;
            reloadCheck.Checked = configTemplate.reload_changes;

            medChangesCheck.Checked = configTemplate.med_changes;
            foodCheck.Checked = configTemplate.food_changes;
            stimCheck.Checked = configTemplate.stim_changes;
            revertMedsCheck.Checked = configTemplate.revert_med_changes;
            movementChangesCheck.Checked = configTemplate.movement_changes;
            weightCheck.Checked = configTemplate.weight_limits_changes;
            headsetCheck.Checked = configTemplate.headset_changes;
            fallDamageChangesCheck.Checked = configTemplate.fall_damage_changes;

            botOdds1Text.Text = intArrToString(configTemplate.botTierOdds1);
            botOdds2Text.Text = intArrToString(configTemplate.botTierOdds2);
            botOdds3Text.Text = intArrToString(configTemplate.botTierOdds3);
            botOdds4Text.Text = intArrToString(configTemplate.botTierOdds4);
            botOdds5Text.Text = intArrToString(configTemplate.botTierOdds5);
            botOdds6Text.Text = intArrToString(configTemplate.botTierOdds6);
            botOdds7Text.Text = intArrToString(configTemplate.botTierOdds7);
            botOdds8Text.Text = intArrToString(configTemplate.botTierOdds8);
            botOdds9Text.Text = intArrToString(configTemplate.botTierOdds9);

            botChangesCheck.Checked = configTemplate.bot_changes;
            botLootCheck.Checked = configTemplate.bot_loot_changes;
            increasedBotCapCheck.Checked = configTemplate.increased_bot_cap;
            openZonesFixCheck.Checked = configTemplate.open_zones_fix;
            bossSpawnCheck.Checked = configTemplate.boss_spawns;
            spawnWaveCheck.Checked = configTemplate.spawn_waves;
            realBossHealthCheck.Checked = configTemplate.realistic_boss_health;
            realFollowerHealthCheck.Checked = configTemplate.realistic_boss_follower_health;
            realRRHealthCheck.Checked = configTemplate.realistic_raider_rogue_health;
            realCultistHealthCheck.Checked = configTemplate.realistic_cultist_health;
            bossDifficultyCheck.Checked = configTemplate.boss_difficulty;
            pmcDifficultyCheck.Checked = configTemplate.pmc_difficulty;
            pmcTypeCheck.Checked = configTemplate.pmc_types;
            pmcNamesCheck.Checked = configTemplate.bot_names;
            cyrillicNamesCheck.Checked = configTemplate.cyrillic_bear_names;

            tieredFleaCheck.Checked = configTemplate.tiered_flea;
            fleaConfigCheck.Checked = configTemplate.flea_changes;
            traderChangesCheck.Checked = configTemplate.change_buy_categories;
            nerfFenceCheck.Checked = configTemplate.nerf_fence;
            allExaminedCheck.Checked = configTemplate.all_examined;
            removeRaidRestrictionsCheck.Checked = configTemplate.remove_inraid_restrictions;
            firCheck.Checked = configTemplate.remove_fir_req;
            firQuestCheck.Checked = configTemplate.remove_quest_fir_req;
            airdropChangesCheck.Checked = configTemplate.airdrop_changes;

            botTestingCheck.Checked = configTemplate.bot_testing;
            enableBotWeapsCheck.Checked = configTemplate.bot_test_weps_enabled;
            bossSpawnsCheck.Checked = configTemplate.guarantee_boss_spawn;
            bossItemsCheck.Checked = configTemplate.force_boss_items;
            disableFleaBlacklistCheck.Checked = configTemplate.disable_flea_blacklist;
            noFallDamageCheck.Checked = configTemplate.no_fall_damage;
            logEverythingCheck.Checked = configTemplate.logEverything;
            revertHPCheck.Checked = configTemplate.revert_hp;

            traderCoeffCheck.Checked = configTemplate.change_buy_price;
            theraHeaCheck.Checked = configTemplate.change_heal_cost;
            tradAdjustPriceCheck.Checked = configTemplate.adjust_trader_prices;
            tradRepairCheck.Checked = configTemplate.trader_repair_changes;
            traderllCheck.Checked = configTemplate.change_trader_ll;
            tradCustItemCheck.Checked = configTemplate.add_cust_trader_items;
            randTradCheck.Checked = configTemplate.randomize_traders;
            randTradLLCheck.Checked = configTemplate.randomize_trader_ll;
            randTradStockCheck.Checked = configTemplate.randomize_trader_stock;
            randTradPriceCheck.Checked = configTemplate.randomize_trader_prices;

            backupCheck.Checked = configTemplate.backup_profiles;

            dynPMCLoot.Checked = configTemplate.dynamic_loot_pmcs;
            dynScavLoot.Checked = configTemplate.dynamic_loot_scavs;
            addKeysCheck.Checked = configTemplate.add_keys;

            stockModNum.Value = (decimal)configTemplate.rand_stock_modifier;
            stackMultiNum.Value = (decimal)configTemplate.rand_stackable_modifier;
            discountNum.Value = (decimal)configTemplate.rand_cost_discount;
            costIncreaseNum.Value = (decimal)configTemplate.rand_cost_increase;
            tradRefreshNum.Value = (decimal)configTemplate.trader_refresh_time;

            if (configTemplate.bot_test_tier > 1 && configTemplate.bot_test_tier <= 5)
            {
                botTierNumeric.Value = configTemplate.bot_test_tier;
            }
            else
            {
                botTierNumeric.Value = 1;
                configTemplate.bot_test_tier = 1;
            }

            if (configTemplate.all_scavs == true)
            {
                botTypeCombo.SelectedItem = "All Scavs";
            }
            else if (configTemplate.all_PMCs == true)
            {
                botTypeCombo.SelectedItem = "All PMCs";
            }
            else if (configTemplate.all_USEC == true)
            {
                botTypeCombo.SelectedItem = "All USEC";
            }
            else if (configTemplate.all_bear == true)
            {
                botTypeCombo.SelectedItem = "All Bear";
            }
            else
            {
                botTypeCombo.SelectedItem = "Default";
            }
        }

        private void setDefaultValues()
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

            configTemplate = new ConfigTemplate();
        }


        private List<ControlRule> initializeControlRules()
        {
            return new List<ControlRule>
            {
                new ControlRule
                {
                    Targets = new List<Control> { attachPresetCombo, weapPresetCombo, malfChangesCheck, headsetCheck, stanceCheck, reloadCheck, chamberCheck },
                    Condition = () => recoilAttOverhaulCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { buffHelmetsCheck, realBossHealthCheck, realFollowerHealthCheck, realRRHealthCheck, realCultistHealthCheck },
                    Condition = () => realBallisticsCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { realPlayerHealthCheck },
                    Condition = () => realBallisticsCheck.Checked && !revertHPCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { revertHPCheck },
                    Condition = () => !realPlayerHealthCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { playerHPNumeric },
                    Condition = () => realPlayerHealthCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { chamberCheck },
                    Condition = () => malfChangesCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { revertMedsCheck },
                    Condition = () => !medChangesCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { cyrillicNamesCheck },
                    Condition = () => pmcNamesCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { randTradLLCheck, randTradStockCheck, randTradPriceCheck, stockModNum, stackMultiNum, discountNum, costIncreaseNum },
                    Condition = () => randTradCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { botOdds1Text, botOdds2Text, botOdds3Text, botOdds4Text, botOdds5Text, botOdds6Text, botOdds7Text, botOdds8Text,
                    botOdds9Text, botLootCheck, dynPMCLoot, dynScavLoot, addKeysCheck },
                    Condition = () => botChangesCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { enableBotWeapsCheck, botTypeCombo, botTierNumeric },
                    Condition = () => botTestingCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { enableBotWeapsCheck, botTypeCombo, botTierNumeric },
                    Condition = () => botTestingCheck.Checked
                },
            };
        }

        private void evaluateControlRules()
        {
            foreach (ControlRule rule in controlRules)
            {
                rule.Evaluate();
            }

            Color disabled = Color.SlateGray;
            Color enabled = Color.FromArgb(36, 36, 36);

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

        private void validateBotTierText()
        {
            configTemplate.botTierOdds1 = stringToIntArr(stringValidationHelper(botOdds1Text.Text));
            configTemplate.botTierOdds2 = stringToIntArr(stringValidationHelper(botOdds2Text.Text));
            configTemplate.botTierOdds3 = stringToIntArr(stringValidationHelper(botOdds3Text.Text));
            configTemplate.botTierOdds4 = stringToIntArr(stringValidationHelper(botOdds4Text.Text));
            configTemplate.botTierOdds5 = stringToIntArr(stringValidationHelper(botOdds5Text.Text));
            configTemplate.botTierOdds6 = stringToIntArr(stringValidationHelper(botOdds6Text.Text));
            configTemplate.botTierOdds7 = stringToIntArr(stringValidationHelper(botOdds7Text.Text));
            configTemplate.botTierOdds8 = stringToIntArr(stringValidationHelper(botOdds8Text.Text));
            configTemplate.botTierOdds9 = stringToIntArr(stringValidationHelper(botOdds9Text.Text));
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
            File.WriteAllText(configFilePath, JsonConvert.SerializeObject(configTemplate));
            savedLabel.ForeColor = Color.GreenYellow;
            Timer(savedLabel);
        }
        private void revertButton_Click(object sender, EventArgs e)
        {
            setDefaultValues();
            setDisplayValues();
            evaluateControlRules();
            File.WriteAllText(configFilePath, JsonConvert.SerializeObject(configTemplate));
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

        private void realPlayerHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.realistic_player_health = realPlayerHealthCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void realismCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.realistic_ballistics = realBallisticsCheck.Checked == true ? true : false;

            if (realBallisticsCheck.Checked == true)
            {
                realPlayerHealthCheck.Checked = true;
            }

            evaluateControlRules();

        }
        private void recoilAttOverhaulCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.recoil_attachment_overhaul = recoilAttOverhaulCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void masteryCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.mastery_changes = masteryCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void buffHelmetsCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.buff_helmets = buffHelmetsCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void headgearConflictsCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.headgear_conflicts = headgearConflictsCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void malfChanges_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.malf_changes = malfChangesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void medChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.med_changes = medChangesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void revertMedsCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.revert_med_changes = revertMedsCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void movementChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.movement_changes = movementChangesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void fallDamageChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.fall_damage_changes = fallDamageChangesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void botChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.bot_changes = botChangesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }


        private void botLootCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.bot_loot_changes = botLootCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void increasedBotCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.increased_bot_cap = increasedBotCapCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void spawnWaveCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.spawn_waves = spawnWaveCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void bossSpawnCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.boss_spawns = bossSpawnCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void openZonesFixCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.open_zones_fix = openZonesFixCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void realBossHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.realistic_boss_health = realBossHealthCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void realFollowerHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.realistic_boss_follower_health = realFollowerHealthCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void realRRHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.realistic_raider_rogue_health = realRRHealthCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void realCultistHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.realistic_cultist_health = realCultistHealthCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void pmcTypeCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.pmc_types = pmcTypeCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void pmcDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.pmc_difficulty = pmcDifficultyCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void bossDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.boss_difficulty = bossDifficultyCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void pmcNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.bot_names = pmcNamesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }
        private void cyrillicNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.cyrillic_bear_names = cyrillicNamesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void tieredFleaCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.tiered_flea = tieredFleaCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void fleaConfigCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.flea_changes = fleaConfigCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void traderChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.change_buy_categories = traderChangesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void nerfFenceCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.nerf_fence = nerfFenceCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void allExaminedCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.all_examined = allExaminedCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void removeRaidRestrictionsCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.remove_inraid_restrictions = removeRaidRestrictionsCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void firQuestCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.remove_quest_fir_req = firQuestCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void firCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.remove_fir_req = firCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void airdropChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.airdrop_changes = airdropChangesCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void botTestingCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.bot_testing = botTestingCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void botTierNumeric_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.bot_test_tier = (int)botTierNumeric.Value;
            evaluateControlRules();
        }

        private void botTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)botTypeCombo.SelectedItem == "Default")
            {
                configTemplate.all_bear = false;
                configTemplate.all_USEC = false;
                configTemplate.all_PMCs = false;
                configTemplate.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All Scavs")
            {
                configTemplate.all_bear = false;
                configTemplate.all_USEC = false;
                configTemplate.all_PMCs = false;
                configTemplate.all_scavs = true;
            }
            if ((string)botTypeCombo.SelectedItem == "All PMCs")
            {
                configTemplate.all_bear = false;
                configTemplate.all_USEC = false;
                configTemplate.all_PMCs = true;
                configTemplate.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All Bear")
            {
                configTemplate.all_bear = true;
                configTemplate.all_USEC = false;
                configTemplate.all_PMCs = false;
                configTemplate.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All USEC")
            {
                configTemplate.all_bear = false;
                configTemplate.all_USEC = true;
                configTemplate.all_PMCs = false;
                configTemplate.all_scavs = false;
            }
            evaluateControlRules();
        }

        private void enableBotWeapsCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.bot_test_weps_enabled = enableBotWeapsCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void bossSpawnsCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.guarantee_boss_spawn = bossSpawnsCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void bossItemsCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.force_boss_items = bossItemsCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void disableFleaBlacklistCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.disable_flea_blacklist = disableFleaBlacklistCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void noFallDamageCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.no_fall_damage = noFallDamageCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void logEverythingCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.logEverything = logEverythingCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void revertHPCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.revert_hp = revertHPCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void weapPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            configTemplate.weap_preset = weapPresetCombo.SelectedItem.ToString();
            evaluateControlRules();
        }

        private void attachPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            configTemplate.att_preset = attachPresetCombo.SelectedItem.ToString();
            evaluateControlRules();
        }

        private void gearPresetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            configTemplate.gear_preset = gearPresetCombo.SelectedItem.ToString();
            evaluateControlRules();
        }

        private void standardHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.standard_bot_hp_multi = standardHPNumeric.Value;
            evaluateControlRules();
        }

        private void midHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.mid_bot_hp_multi = midHPNumeric.Value;
            evaluateControlRules();
        }

        private void bossHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.boss_bot_hp_multi = bossHPNumeric.Value;
            evaluateControlRules();
        }

        private void playerHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.player_hp_multi = playerHPNumeric.Value;
            evaluateControlRules();
        }

        private void weightCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.weight_limits_changes = weightCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void headsetCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.headset_changes = headsetCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void botHost1_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.bot_hostile1 = (int)hostNum1.Value;
            evaluateControlRules();
        }

        private void botHost2_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.bot_hostile2 = (int)hostNum2.Value;
            evaluateControlRules();
        }

        private void botHost3_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.bot_hostile3 = (int)hostNum3.Value;
            evaluateControlRules();
        }

        private void tradRepairCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.trader_repair_changes = tradRepairCheck.Checked == true ? true : false; ;
            evaluateControlRules();
        }

        private void traderllCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.change_trader_ll = traderllCheck.Checked == true ? true : false; ;
            evaluateControlRules();
        }

        private void tradCustItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.add_cust_trader_items = tradCustItemCheck.Checked == true ? true : false; ;
            evaluateControlRules();
        }

        private void tradAdjustPriceCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.adjust_trader_prices = tradAdjustPriceCheck.Checked == true ? true : false; ;
            evaluateControlRules();
        }

        private void randTradCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.randomize_traders = randTradCheck.Checked == true ? true : false; ;
            evaluateControlRules();
        }

        private void randTradLLCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.randomize_trader_ll = randTradLLCheck.Checked == true ? true : false; ;
            evaluateControlRules();
        }

        private void randTradStockCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.randomize_trader_stock = randTradStockCheck.Checked == true ? true : false; ;
            evaluateControlRules();
        }

        private void randTradPriceCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.randomize_trader_prices = randTradPriceCheck.Checked == true ? true : false; ;
            evaluateControlRules();
        }

        private void stockModNum_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.rand_stock_modifier = (int)stockModNum.Value;
            evaluateControlRules();
        }

        private void stackMultiNum_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.rand_stackable_modifier = stackMultiNum.Value;
            evaluateControlRules();
        }

        private void discountNum_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.rand_cost_discount = discountNum.Value;
            evaluateControlRules();
        }

        private void costIncreaseNum_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.rand_cost_increase = costIncreaseNum.Value;
            evaluateControlRules();
        }

        private void tradRefreshNum_ValueChanged(object sender, EventArgs e)
        {
            configTemplate.trader_refresh_time = (int)tradRefreshNum.Value;
            evaluateControlRules();
        }

        private void backupCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.backup_profiles = backupCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void dynBotLoot_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.dynamic_loot_pmcs = dynPMCLoot.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void dynScavLoot_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.dynamic_loot_scavs = dynScavLoot.Checked == true ? true : false;
            evaluateControlRules();
        }


        private void addKeysCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.add_keys = addKeysCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void theraHeaCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.change_heal_cost = theraHeaCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void traderCoeffCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.change_buy_price = traderCoeffCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void comfortCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.gear_weight = comfortCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void stanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.enable_stances = stanceCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void reloadCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.reload_changes = reloadCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void chamberCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.manual_chambering = chamberCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void stimCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.stim_changes = stimCheck.Checked == true ? true : false;
            evaluateControlRules();
        }

        private void foodCheck_CheckedChanged(object sender, EventArgs e)
        {
            configTemplate.food_changes = foodCheck.Checked == true ? true : false;
            evaluateControlRules();
        }
    }
}