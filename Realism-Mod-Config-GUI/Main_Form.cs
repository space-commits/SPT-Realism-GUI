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

        private List<ControlRule> _controlRules = new List<ControlRule>();
        private string? _configFilePath;
        private ConfigTemplate? _configTemplate;
        private PackageTemplate? _packageTemplate;
        private DirectoryInfo[]? _weapPresetFilePath;
        private DirectoryInfo[]? _attPresetFilePath;
        private DirectoryInfo[]? _gearPresetFilePath;
        private bool _haveInitialized = false;

        public Main_Form()
        {
            try
            {
                InitializeComponent();
                DeserializeJSON();
                SetTitleBar();
                SetNumericLimits();
                warningTextBox.Hide();
                SetDisplayValues();
                _controlRules = InitializeControlRules();
                EvaluateControlRules();
                _haveInitialized = true;
            }
            catch (Exception exception)
            {
                warningTextBox.Show();
                warningTextBox.Text = $"{exception.Message}  \n\nMake sure this app is located in the 'SPT-Realism-Mod' folder, and make sure the 'config.json' file is located in 'config\\config.json'";
            }
        }

        private void DeserializeJSON()
        {
            _configFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"config\config.json");
            string configJSON = File.ReadAllText(_configFilePath);
            _configTemplate = JsonConvert.DeserializeObject<ConfigTemplate>(configJSON);

            string weapFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\weapons\");
            DirectoryInfo weapDI = new DirectoryInfo(weapFilePath);
            _weapPresetFilePath = weapDI.GetDirectories();

            string attFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\attatchments\");
            DirectoryInfo attDI = new DirectoryInfo(attFilePath);
            _attPresetFilePath = attDI.GetDirectories();

            string gearFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"db\templates\gear\");
            DirectoryInfo gearDI = new DirectoryInfo(gearFilePath);
            _gearPresetFilePath = gearDI.GetDirectories();

            string packagePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"package.json");
            string packageJSON = File.ReadAllText(packagePath);
            _packageTemplate = JsonConvert.DeserializeObject<PackageTemplate>(packageJSON);
        }

        private void SetTitleBar()
        {
            string modVer = "v" + _packageTemplate.version;
            string sptVer = "v" + _packageTemplate.sptVersion;

            this.Text = "SPT Realism Mod Config SPTRM " + modVer + " SPT " + sptVer;

            modVerLabel.Text = modVer;
        }

        private void SetNumericLimits()
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

        private void SetPresetComboBoxes(DirectoryInfo[]? dirInfoArr, ComboBox cb)
        {
            foreach (DirectoryInfo dir in dirInfoArr)
            {
                cb.Items.Add(dir.Name);
            }
        }

        private void SetDisplayValues()
        {
            hostNum1.Value = (decimal)_configTemplate.bot_hostile1;
            hostNum2.Value = (decimal)_configTemplate.bot_hostile2;
            hostNum3.Value = (decimal)_configTemplate.bot_hostile3;

            standardHPNumeric.Value = (decimal)_configTemplate.standard_bot_hp_multi;
            midHPNumeric.Value = (decimal)_configTemplate.mid_bot_hp_multi;
            bossHPNumeric.Value = (decimal)_configTemplate.boss_bot_hp_multi;
            playerHPNumeric.Value = (decimal)_configTemplate.player_hp_multi;

            realPlayerHealthCheck.Checked = _configTemplate.realistic_player_health;
            realBallisticsCheck.Checked = _configTemplate.realistic_ballistics;
            recoilAttOverhaulCheck.Checked = _configTemplate.recoil_attachment_overhaul;
            malfChangesCheck.Checked = _configTemplate.malf_changes;
            masteryCheck.Checked = _configTemplate.mastery_changes;
            buffHelmetsCheck.Checked = _configTemplate.buff_helmets;
            headgearConflictsCheck.Checked = _configTemplate.headgear_conflicts;

            stanceCheck.Checked = _configTemplate.enable_stances;
            comfortCheck.Checked = _configTemplate.gear_weight;
            chamberCheck.Checked = _configTemplate.manual_chambering;
            reloadCheck.Checked = _configTemplate.reload_changes;

            medChangesCheck.Checked = _configTemplate.med_changes;
            foodCheck.Checked = _configTemplate.food_changes;
            stimCheck.Checked = _configTemplate.stim_changes;
            revertMedsCheck.Checked = _configTemplate.revert_med_changes;
            movementChangesCheck.Checked = _configTemplate.movement_changes;
            weightCheck.Checked = _configTemplate.weight_limits_changes;
            headsetCheck.Checked = _configTemplate.headset_changes;
            fallDamageChangesCheck.Checked = _configTemplate.fall_damage_changes;
            hazardCheck.Checked = _configTemplate.enable_hazard_zones;

            botOdds1Text.Text = intArrToString(_configTemplate.botTierOdds1);
            botOdds2Text.Text = intArrToString(_configTemplate.botTierOdds2);
            botOdds3Text.Text = intArrToString(_configTemplate.botTierOdds3);
            botOdds4Text.Text = intArrToString(_configTemplate.botTierOdds4);
            botOdds5Text.Text = intArrToString(_configTemplate.botTierOdds5);
            botOdds6Text.Text = intArrToString(_configTemplate.botTierOdds6);
            botOdds7Text.Text = intArrToString(_configTemplate.botTierOdds7);
            botOdds8Text.Text = intArrToString(_configTemplate.botTierOdds8);
            botOdds9Text.Text = intArrToString(_configTemplate.botTierOdds9);

            botChangesCheck.Checked = _configTemplate.bot_changes;
            botLootCheck.Checked = _configTemplate.bot_loot_changes;
            increasedBotCapCheck.Checked = _configTemplate.increased_bot_cap;
            openZonesFixCheck.Checked = _configTemplate.open_zones_fix;
            bossSpawnCheck.Checked = _configTemplate.boss_spawns;
            spawnWaveCheck.Checked = _configTemplate.spawn_waves;
            realBossHealthCheck.Checked = _configTemplate.realistic_boss_health;
            realFollowerHealthCheck.Checked = _configTemplate.realistic_boss_follower_health;
            realRRHealthCheck.Checked = _configTemplate.realistic_raider_rogue_health;
            realCultistHealthCheck.Checked = _configTemplate.realistic_cultist_health;
            bossDifficultyCheck.Checked = _configTemplate.boss_difficulty;
            pmcDifficultyCheck.Checked = _configTemplate.pmc_difficulty;
            pmcTypeCheck.Checked = _configTemplate.pmc_types;
            pmcNamesCheck.Checked = _configTemplate.bot_names;
            cyrillicNamesCheck.Checked = _configTemplate.cyrillic_bear_names;

            tieredFleaCheck.Checked = _configTemplate.tiered_flea;
            fleaConfigCheck.Checked = _configTemplate.flea_changes;
            traderChangesCheck.Checked = _configTemplate.change_buy_categories;
            nerfFenceCheck.Checked = _configTemplate.nerf_fence;
            allExaminedCheck.Checked = _configTemplate.all_examined;
            removeRaidRestrictionsCheck.Checked = _configTemplate.remove_inraid_restrictions;
            firCheck.Checked = _configTemplate.remove_fir_req;
            firQuestCheck.Checked = _configTemplate.remove_quest_fir_req;
            /*    airdropChangesCheck.Checked = configTemplate.airdrop_changes;
    */
            botTestingCheck.Checked = _configTemplate.bot_testing;
            enableBotWeapsCheck.Checked = _configTemplate.bot_test_weps_enabled;
            bossSpawnsCheck.Checked = _configTemplate.guarantee_boss_spawn;
            bossItemsCheck.Checked = _configTemplate.force_boss_items;
            disableFleaBlacklistCheck.Checked = _configTemplate.disable_flea_blacklist;
            noFallDamageCheck.Checked = _configTemplate.no_fall_damage;
            logEverythingCheck.Checked = _configTemplate.logEverything;
            revertHPCheck.Checked = _configTemplate.revert_hp;

            traderCoeffCheck.Checked = _configTemplate.change_buy_price;
            theraHeaCheck.Checked = _configTemplate.change_heal_cost;
            tradAdjustPriceCheck.Checked = _configTemplate.adjust_trader_prices;
            tradRepairCheck.Checked = _configTemplate.trader_repair_changes;
            traderllCheck.Checked = _configTemplate.change_trader_ll;
            tradCustItemCheck.Checked = _configTemplate.add_cust_trader_items;
            randTradCheck.Checked = _configTemplate.randomize_traders;
            randTradLLCheck.Checked = _configTemplate.randomize_trader_ll;
            randTradStockCheck.Checked = _configTemplate.randomize_trader_stock;
            randTradPriceCheck.Checked = _configTemplate.randomize_trader_prices;
            insuranceCheck.Checked = _configTemplate.insurance_changes;

            backupCheck.Checked = _configTemplate.backup_profiles;

            dynPMCLoot.Checked = _configTemplate.dynamic_loot_pmcs;
            dynScavLoot.Checked = _configTemplate.dynamic_loot_scavs;
            addKeysCheck.Checked = _configTemplate.add_keys;

            stockModMinNum.Value = (decimal)_configTemplate.rand_stock_modifier_min;
            stockModNum.Value = (decimal)_configTemplate.rand_stock_modifier;
            stackMultiNum.Value = (decimal)_configTemplate.rand_stackable_modifier;
            discountNum.Value = (decimal)_configTemplate.rand_cost_discount;
            costIncreaseNum.Value = (decimal)_configTemplate.rand_cost_increase;
            tradRefreshNum.Value = (decimal)_configTemplate.trader_refresh_time;

            if (_configTemplate.bot_test_tier > 1 && _configTemplate.bot_test_tier <= 5)
            {
                botTierNumeric.Value = _configTemplate.bot_test_tier;
            }
            else
            {
                botTierNumeric.Value = 1;
                _configTemplate.bot_test_tier = 1;
            }

            if (_configTemplate.all_scavs == true)
            {
                botTypeCombo.SelectedItem = "All Scavs";
            }
            else if (_configTemplate.all_PMCs == true)
            {
                botTypeCombo.SelectedItem = "All PMCs";
            }
            else if (_configTemplate.all_USEC == true)
            {
                botTypeCombo.SelectedItem = "All USEC";
            }
            else if (_configTemplate.all_bear == true)
            {
                botTypeCombo.SelectedItem = "All Bear";
            }
            else
            {
                botTypeCombo.SelectedItem = "Default";
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

            _configTemplate = new ConfigTemplate();
        }


        private List<ControlRule> InitializeControlRules()
        {
            return new List<ControlRule>
            {
                new ControlRule
                {
                    Targets = new List<Control> { malfChangesCheck, headsetCheck, stanceCheck, reloadCheck, chamberCheck },
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
                    Targets = new List<Control> { hazardCheck },
                    Condition = () => medChangesCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { cyrillicNamesCheck },
                    Condition = () => pmcNamesCheck.Checked
                },
                new ControlRule
                {
                    Targets = new List<Control> { randTradLLCheck, randTradStockCheck, randTradPriceCheck, stockModNum, stockModMinNum, stackMultiNum, discountNum, costIncreaseNum },
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
                    Targets = new List<Control> { dynPMCLoot, dynScavLoot },
                    Condition = () => botLootCheck.Checked
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

        private void EvaluateControlRules()
        {
            foreach (ControlRule rule in _controlRules)
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

        private void ValidateBotTierText()
        {
            _configTemplate.botTierOdds1 = stringToIntArr(StringValidationHelper(botOdds1Text.Text));
            _configTemplate.botTierOdds2 = stringToIntArr(StringValidationHelper(botOdds2Text.Text));
            _configTemplate.botTierOdds3 = stringToIntArr(StringValidationHelper(botOdds3Text.Text));
            _configTemplate.botTierOdds4 = stringToIntArr(StringValidationHelper(botOdds4Text.Text));
            _configTemplate.botTierOdds5 = stringToIntArr(StringValidationHelper(botOdds5Text.Text));
            _configTemplate.botTierOdds6 = stringToIntArr(StringValidationHelper(botOdds6Text.Text));
            _configTemplate.botTierOdds7 = stringToIntArr(StringValidationHelper(botOdds7Text.Text));
            _configTemplate.botTierOdds8 = stringToIntArr(StringValidationHelper(botOdds8Text.Text));
            _configTemplate.botTierOdds9 = stringToIntArr(StringValidationHelper(botOdds9Text.Text));
        }

        private string StringValidationHelper(string str)
        {
            if (str == "" || str.Any(Char.IsLetter) || str.Contains(".") || !str.Contains(","))
            {
                throw new ArgumentException("Invalid Character(s) In Bot Tier String");
            }
            return str;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ValidateBotTierText();
            File.WriteAllText(_configFilePath, JsonConvert.SerializeObject(_configTemplate));
            savedLabel.ForeColor = Color.GreenYellow;
            Timer(savedLabel);
        }
        private void revertButton_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
            SetDisplayValues();
            EvaluateControlRules();
            File.WriteAllText(_configFilePath, JsonConvert.SerializeObject(_configTemplate));
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
            _configTemplate.realistic_player_health = realPlayerHealthCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void realismCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.realistic_ballistics = realBallisticsCheck.Checked == true ? true : false;

            if (realBallisticsCheck.Checked == true)
            {
                realPlayerHealthCheck.Checked = true;
            }

            EvaluateControlRules();

        }
        private void recoilAttOverhaulCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.recoil_attachment_overhaul = recoilAttOverhaulCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void masteryCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.mastery_changes = masteryCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void buffHelmetsCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.buff_helmets = buffHelmetsCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void headgearConflictsCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.headgear_conflicts = headgearConflictsCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void malfChanges_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.malf_changes = malfChangesCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void medChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.med_changes = medChangesCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void revertMedsCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.revert_med_changes = revertMedsCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void movementChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.movement_changes = movementChangesCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void fallDamageChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.fall_damage_changes = fallDamageChangesCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void botChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_changes = botChangesCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }


        private void botLootCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_loot_changes = botLootCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void increasedBotCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.increased_bot_cap = increasedBotCapCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void spawnWaveCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.spawn_waves = spawnWaveCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void bossSpawnCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.boss_spawns = bossSpawnCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void openZonesFixCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.open_zones_fix = openZonesFixCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void realBossHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.realistic_boss_health = realBossHealthCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void realFollowerHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.realistic_boss_follower_health = realFollowerHealthCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void realRRHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.realistic_raider_rogue_health = realRRHealthCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void realCultistHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.realistic_cultist_health = realCultistHealthCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void pmcTypeCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.pmc_types = pmcTypeCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void pmcDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.pmc_difficulty = pmcDifficultyCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void bossDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.boss_difficulty = bossDifficultyCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void pmcNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_names = pmcNamesCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }
        private void cyrillicNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.cyrillic_bear_names = cyrillicNamesCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void tieredFleaCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.tiered_flea = tieredFleaCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void fleaConfigCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.flea_changes = fleaConfigCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void traderChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.change_buy_categories = traderChangesCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void nerfFenceCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.nerf_fence = nerfFenceCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void allExaminedCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.all_examined = allExaminedCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void removeRaidRestrictionsCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.remove_inraid_restrictions = removeRaidRestrictionsCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void firQuestCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.remove_quest_fir_req = firQuestCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void firCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.remove_fir_req = firCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        /*     private void airdropChangesCheck_CheckedChanged(object sender, EventArgs e)
             {
                 configTemplate.airdrop_changes = airdropChangesCheck.Checked == true ? true : false;
                 evaluateControlRules();
             }*/

        private void botTestingCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_testing = botTestingCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void botTierNumeric_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_test_tier = (int)botTierNumeric.Value;
            EvaluateControlRules();
        }

        private void botTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)botTypeCombo.SelectedItem == "Default")
            {
                _configTemplate.all_bear = false;
                _configTemplate.all_USEC = false;
                _configTemplate.all_PMCs = false;
                _configTemplate.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All Scavs")
            {
                _configTemplate.all_bear = false;
                _configTemplate.all_USEC = false;
                _configTemplate.all_PMCs = false;
                _configTemplate.all_scavs = true;
            }
            if ((string)botTypeCombo.SelectedItem == "All PMCs")
            {
                _configTemplate.all_bear = false;
                _configTemplate.all_USEC = false;
                _configTemplate.all_PMCs = true;
                _configTemplate.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All Bear")
            {
                _configTemplate.all_bear = true;
                _configTemplate.all_USEC = false;
                _configTemplate.all_PMCs = false;
                _configTemplate.all_scavs = false;
            }
            if ((string)botTypeCombo.SelectedItem == "All USEC")
            {
                _configTemplate.all_bear = false;
                _configTemplate.all_USEC = true;
                _configTemplate.all_PMCs = false;
                _configTemplate.all_scavs = false;
            }
            EvaluateControlRules();
        }

        private void enableBotWeapsCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_test_weps_enabled = enableBotWeapsCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void bossSpawnsCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.guarantee_boss_spawn = bossSpawnsCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void bossItemsCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.force_boss_items = bossItemsCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void disableFleaBlacklistCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.disable_flea_blacklist = disableFleaBlacklistCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void noFallDamageCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.no_fall_damage = noFallDamageCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void logEverythingCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.logEverything = logEverythingCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void revertHPCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.revert_hp = revertHPCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void standardHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.standard_bot_hp_multi = standardHPNumeric.Value;
            EvaluateControlRules();
        }

        private void midHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.mid_bot_hp_multi = midHPNumeric.Value;
            EvaluateControlRules();
        }

        private void bossHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.boss_bot_hp_multi = bossHPNumeric.Value;
            EvaluateControlRules();
        }

        private void playerHPNumeric_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.player_hp_multi = playerHPNumeric.Value;
            EvaluateControlRules();
        }

        private void weightCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.weight_limits_changes = weightCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void headsetCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.headset_changes = headsetCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void botHost1_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_hostile1 = (int)hostNum1.Value;
            EvaluateControlRules();
        }

        private void botHost2_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_hostile2 = (int)hostNum2.Value;
            EvaluateControlRules();
        }

        private void botHost3_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.bot_hostile3 = (int)hostNum3.Value;
            EvaluateControlRules();
        }

        private void tradRepairCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.trader_repair_changes = tradRepairCheck.Checked == true ? true : false; ;
            EvaluateControlRules();
        }

        private void traderllCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.change_trader_ll = traderllCheck.Checked == true ? true : false; ;
            EvaluateControlRules();
        }

        private void tradCustItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.add_cust_trader_items = tradCustItemCheck.Checked == true ? true : false; ;
            EvaluateControlRules();
        }

        private void tradAdjustPriceCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.adjust_trader_prices = tradAdjustPriceCheck.Checked == true ? true : false; ;
            EvaluateControlRules();
        }

        private void randTradCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.randomize_traders = randTradCheck.Checked == true ? true : false; ;
            EvaluateControlRules();
        }

        private void randTradLLCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.randomize_trader_ll = randTradLLCheck.Checked == true ? true : false; ;
            EvaluateControlRules();
        }

        private void randTradStockCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.randomize_trader_stock = randTradStockCheck.Checked == true ? true : false; ;
            EvaluateControlRules();
        }

        private void randTradPriceCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.randomize_trader_prices = randTradPriceCheck.Checked == true ? true : false; ;
            EvaluateControlRules();
        }

        private void stockModMinNum_ValueChanged(object sender, EventArgs e)
        {
            if (!_haveInitialized) return;
            if (stockModMinNum.Value > stockModNum.Value)
            {
                stockModMinNum.Value = stockModNum.Value;
            }
            stockModNum.Minimum = stockModMinNum.Value;
            _configTemplate.rand_stock_modifier_min = (int)stockModMinNum.Value;
            EvaluateControlRules();
        }

        private void stockModNum_ValueChanged(object sender, EventArgs e)
        {
            if (!_haveInitialized) return;
            if (stockModNum.Value < stockModMinNum.Value)
            {
                stockModNum.Value = stockModMinNum.Value;
            }

            stockModMinNum.Maximum = stockModNum.Value;
            _configTemplate.rand_stock_modifier = (int)stockModNum.Value;
            EvaluateControlRules();
        }

        private void stackMultiNum_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.rand_stackable_modifier = stackMultiNum.Value;
            EvaluateControlRules();
        }

        private void discountNum_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.rand_cost_discount = discountNum.Value;
            EvaluateControlRules();
        }

        private void costIncreaseNum_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.rand_cost_increase = costIncreaseNum.Value;
            EvaluateControlRules();
        }

        private void tradRefreshNum_ValueChanged(object sender, EventArgs e)
        {
            _configTemplate.trader_refresh_time = (int)tradRefreshNum.Value;
            EvaluateControlRules();
        }

        private void backupCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.backup_profiles = backupCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void dynBotLoot_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.dynamic_loot_pmcs = dynPMCLoot.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void dynScavLoot_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.dynamic_loot_scavs = dynScavLoot.Checked == true ? true : false;
            EvaluateControlRules();
        }


        private void addKeysCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.add_keys = addKeysCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void theraHeaCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.change_heal_cost = theraHeaCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void traderCoeffCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.change_buy_price = traderCoeffCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void comfortCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.gear_weight = comfortCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void stanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.enable_stances = stanceCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void reloadCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.reload_changes = reloadCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void chamberCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.manual_chambering = chamberCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void stimCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.stim_changes = stimCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void foodCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.food_changes = foodCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void hazardCheck_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.enable_hazard_zones = hazardCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }

        private void insuranceCheck1_CheckedChanged(object sender, EventArgs e)
        {
            _configTemplate.insurance_changes = insuranceCheck.Checked == true ? true : false;
            EvaluateControlRules();
        }
    }
}