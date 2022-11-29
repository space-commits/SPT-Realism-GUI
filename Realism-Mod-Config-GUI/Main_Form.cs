using Newtonsoft.Json;
using Timer = System.Windows.Forms.Timer;

namespace Realism_Mod_Config_GUI
{
    public partial class Main_Form : Form
    {

        public static string confiFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), @"config\config.json");
        public static string configJSON = File.ReadAllText(confiFilePath);

        public static ConfigTemplate config = JsonConvert.DeserializeObject<ConfigTemplate>(configJSON);


        public Main_Form()
        {
            InitializeComponent();

            string modVer = "v0.6.2";
            string sptVer = "v3.3.0";

            this.Text = "SPT Realism Mod Config SPTRM " + modVer + " SPT " + sptVer;

            modVerLabel.Text = modVer;

            try
            {
                warningTextBox.Hide();
                SetDisplayValues();
            }
            catch
            {
                warningTextBox.Show();
                warningTextBox.Text = $"config.json not found at file path: {Path.Combine(Path.GetDirectoryName(Environment.ProcessPath))}\\config\\";
            }
        }

        private void SetDefaultValues()
        {
            config.realistic_player_health = true;
            config.realistic_ballistics = true;
            config.mastery_changes = true;
            config.legacy_recoil_changes = false;
            config.buff_helmets = false;
            config.armor_mouse_penalty = true;
            config.headgear_conflicts = true;
            config.malf_changes = true;
            config.med_changes = true;
            config.revert_med_changes = false;
            config.movement_changes = true;
            config.fall_damage_changes = true;
            config.bot_changes = true;
            config.increased_bot_cap = false;
            config.open_zones_fix = true;
            config.realistic_boss_health = true;
            config.realistic_boss_follower_health = true;
            config.realistic_raider_rogue_health = true;
            config.realistic_cultist_health = true;
            config.pmc_difficulty = false;
            config.boss_difficulty = false;
            config.pmc_types= true;
            config.bot_names = true;
            config.cyrillic_bear_names = true;
            config.tiered_flea = true;
            config.flea_changes = true;
            config.trader_changes = true;
            config.all_examined = true;
            config.remove_inraid_restrictions = true;
            config.airdrop_changes = true;
            config.bot_testing = false;
            config.bot_test_tier = 1;
            config.all_bear = false;
            config.all_USEC = false;
            config.all_PMCs = false;
            config.all_scavs = false;
            config.bot_test_weps_enabled = true;
            config.guarantee_boss_spawn = false;
            config.disable_flea_blacklist = false;
            config.no_fall_damage = false;
            config.logEverything = false;
            config.dev_mode = false;
            config.unstuck_GS = false;
        }

        private void SetDisplayValues()
        {
            realPlayerHealthCheck.Checked = config.realistic_player_health;
            realBallisticsCheck.Checked = config.realistic_ballistics;
            recoilAttOverhaulCheck.Checked = config.recoil_attachment_overhaul;
            malfChangesCheck.Checked = config.malf_changes;
            masteryCheck.Checked = config.mastery_changes;
            buffHelmetsCheck.Checked = config.buff_helmets;
            armorMousePenaltyCheck.Checked = config.armor_mouse_penalty;
            headgearConflictsCheck.Checked = config.headgear_conflicts;
            legacyRecoilCheck.Checked = config.legacy_recoil_changes;

            medChangesCheck.Checked = config.med_changes;
            revertMedsCheck.Checked = config.revert_med_changes;
            movementChangesCheck.Checked = config.movement_changes;
            fallDamageChangesCheck.Checked = config.fall_damage_changes;

            botChangesCheck.Checked = config.bot_changes;
            increasedBotCapCheck.Checked = config.increased_bot_cap;
            openZonesFixCheck.Checked = config.open_zones_fix;
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
            traderChangesCheck.Checked = config.trader_changes;
            allExaminedCheck.Checked = config.all_examined;
            removeRaidRestrictionsCheck.Checked = config.remove_inraid_restrictions;
            airdropChangesCheck.Checked = config.airdrop_changes;

            botTestingCheck.Checked = config.bot_testing;
            enableBotWeapsCheck.Checked = config.bot_test_weps_enabled;
            bossSpawnsCheck.Checked = config.guarantee_boss_spawn;
            disableFleaBlacklistCheck.Checked = config.disable_flea_blacklist;
            noFallDamageCheck.Checked = config.no_fall_damage;
            logEverythingCheck.Checked = config.logEverything;
            unstuckGSCheck.Checked = config.unstuck_GS;
            devModeCheck.Checked = config.dev_mode;

            if (config.bot_test_tier > 1 && config.bot_test_tier <= 4)
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

        private void realPlayerHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_player_health = realPlayerHealthCheck.Checked == true ? true : false;
        }

        private void realismCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_ballistics = realBallisticsCheck.Checked == true ? true : false;

        }
        private void masteryCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.mastery_changes = masteryCheck.Checked == true ? true : false;
        }

        private void legacyRecoilCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.legacy_recoil_changes = legacyRecoilCheck.Checked == true ? true : false;
        }

        private void buffHelmetsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.buff_helmets = buffHelmetsCheck.Checked == true ? true : false;
        }

        private void armorMousePenaltyCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.armor_mouse_penalty = armorMousePenaltyCheck.Checked == true ? true : false;
        }

        private void headgearConflictsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.headgear_conflicts = headgearConflictsCheck.Checked == true ? true : false;
        }

        private void malfChanges_CheckedChanged(object sender, EventArgs e)
        {
            config.malf_changes = malfChangesCheck.Checked == true ? true : false;

        }

        private void medChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.med_changes = medChangesCheck.Checked == true ? true : false;
        }

        private void revertMedsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.revert_med_changes = revertMedsCheck.Checked == true ? true : false;
        }

        private void movementChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.movement_changes = movementChangesCheck.Checked == true ? true : false;
        }

        private void fallDamageChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.fall_damage_changes = fallDamageChangesCheck.Checked == true ? true : false;
        }

        private void botChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_changes = botChangesCheck.Checked == true ? true : false;
        }

        private void increasedBotCapCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.increased_bot_cap = increasedBotCapCheck.Checked == true ? true : false;
        }

        private void openZonesFixCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.open_zones_fix = openZonesFixCheck.Checked == true ? true : false;
        }

        private void realBossHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_boss_health = realBossHealthCheck.Checked == true ? true : false;
        }

        private void realFollowerHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_boss_follower_health = realFollowerHealthCheck.Checked == true ? true : false;
        }

        private void realRRHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_raider_rogue_health = realRRHealthCheck.Checked == true ? true : false;
        }

        private void realCultistHealthCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.realistic_cultist_health = realCultistHealthCheck.Checked == true ? true : false;
        }

        private void pmcTypeCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.pmc_types = pmcTypeCheck.Checked == true ? true : false;
        }

        private void pmcDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.pmc_difficulty = pmcDifficultyCheck.Checked == true ? true : false;
        }

        private void bossDifficultyCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.boss_difficulty = bossDifficultyCheck.Checked == true ? true : false;
        }

        private void pmcNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_names = pmcNamesCheck.Checked == true ? true : false;
        }
        private void cyrillicNamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.cyrillic_bear_names = cyrillicNamesCheck.Checked == true ? true : false;
        }

        private void tieredFleaCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.tiered_flea = tieredFleaCheck.Checked == true ? true : false;
        }

        private void fleaConfigCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.flea_changes = fleaConfigCheck.Checked == true ? true : false;
        }

        private void traderChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.trader_changes = traderChangesCheck.Checked == true ? true : false;
        }

        private void allExaminedCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.all_examined = allExaminedCheck.Checked == true ? true : false;
        }

        private void removeRaidRestrictionsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.remove_inraid_restrictions = removeRaidRestrictionsCheck.Checked == true ? true : false;
        }

        private void airdropChangesCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.airdrop_changes = airdropChangesCheck.Checked == true ? true : false;
        }

        private void botTestingCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_testing = botTestingCheck.Checked == true ? true : false;
        }

        private void botTierNumeric_ValueChanged(object sender, EventArgs e)
        {
            config.bot_test_tier = (int)botTierNumeric.Value;
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
        }
        private void enableBotWeapsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.bot_test_weps_enabled = enableBotWeapsCheck.Checked == true ? true : false;
        }

        private void bossSpawnsCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.guarantee_boss_spawn = bossSpawnsCheck.Checked == true ? true : false;
        }

        private void disableFleaBlacklistCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.disable_flea_blacklist = disableFleaBlacklistCheck.Checked == true ? true : false;
        }

        private void noFallDamageCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.no_fall_damage = noFallDamageCheck.Checked == true ? true : false;
        }

        private void logEverythingCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.logEverything = logEverythingCheck.Checked == true ? true : false;
        }

        private void devModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.dev_mode = devModeCheck.Checked == true ? true : false;
        }

        private void unstuckGSCheck_CheckedChanged(object sender, EventArgs e)
        {
            config.unstuck_GS = unstuckGSCheck.Checked == true ? true : false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(confiFilePath, JsonConvert.SerializeObject(config));
            savedLabel.ForeColor = Color.GreenYellow;
            Timer(savedLabel);
        }
        private void revertButton_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
            SetDisplayValues();
            File.WriteAllText(confiFilePath, JsonConvert.SerializeObject(config));
            revertLabel.ForeColor = Color.DarkOrange;
            Timer(revertLabel);
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
        }


    }
}