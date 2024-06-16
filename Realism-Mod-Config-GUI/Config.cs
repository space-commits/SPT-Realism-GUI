using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realism_Mod_Config_GUI
{
    public class PackageTemplate
    {
        public string version { get; set; } = "unknown";
        public string akiVersion { get; set; } = "unknown";
    }


    public class ConfigTemplate
    {
        public bool realistic_player_health { get; set; } = true;
        public bool realistic_ballistics { get; set; } = true;
        public bool buff_helmets { get; set; } = false;
        public bool headgear_conflicts { get; set; } = true;
        public bool recoil_attachment_overhaul { get; set; } = true;
        public bool mastery_changes { get; set; } = true;
        public bool malf_changes { get; set; } = true;
        public bool movement_changes { get; set; } = true;
        public bool weight_limits_changes { get; set; } = true;
        public bool fall_damage_changes { get; set; } = true;
        public bool med_changes { get; set; } = true;
        public bool stim_changes { get; set; } = true;
        public bool food_changes { get; set; } = true;
        public bool revert_med_changes { get; set; } = false;
        public bool bot_changes { get; set; } = true;
        public bool bot_loot_changes { get; set; } = true;
        public bool increased_bot_cap { get; set; } = false;
        public bool realistic_boss_health { get; set; } = true;
        public bool realistic_boss_follower_health { get; set; } = true;
        public bool realistic_raider_rogue_health { get; set; } = true;
        public bool realistic_cultist_health { get; set; } = true;
        public bool open_zones_fix { get; set; } = true;
        public bool boss_spawns { get; set; } = true;
        public bool spawn_waves { get; set; } = true;
        public bool pmc_difficulty { get; set; } = false;
        public bool boss_difficulty { get; set; } = false;
        public bool pmc_types { get; set; } = true;
        public bool bot_names { get; set; } = true;
        public bool cyrillic_bear_names { get; set; } = true;
        public bool tiered_flea { get; set; } = true;
        public bool flea_changes { get; set; } = true;
        public bool change_buy_categories { get; set; } = true;
        public bool airdrop_changes { get; set; } = true;
        public bool all_examined { get; set; } = true;
        public bool remove_inraid_restrictions { get; set; } = true;
        public bool remove_fir_req { get; set; } = true;
        public bool remove_quest_fir_req { get; set; } = true;
        public bool bot_testing { get; set; } = false;
        public bool bot_test_weps_enabled { get; set; } = false;
        public bool all_scavs { get; set; } = false;
        public bool all_USEC { get; set; } = false;
        public bool all_bear { get; set; } = false;
        public bool all_PMCs { get; set; } = false;
        public bool guarantee_boss_spawn { get; set; } = false;
        public bool disable_flea_blacklist { get; set; } = false;
        public bool no_fall_damage { get; set; } = false;
        public bool logEverything { get; set; } = false;
        public bool force_boss_items { get; set; } = false;
        public bool revert_hp { get; set; } = false;
        public bool headset_changes { get; set; } = true;
        public bool trader_repair_changes { get; set; } = true;
        public bool change_trader_ll { get; set; } = true;
        public bool add_cust_trader_items { get; set; } = true;
        public bool randomize_traders { get; set; } = true;
        public bool randomize_trader_ll { get; set; } = true;
        public bool randomize_trader_stock { get; set; } = true;
        public bool adjust_trader_prices { get; set; } = true;
        public bool randomize_trader_prices { get; set; } = true;
        public bool nerf_fence { get; set; } = true;
        public bool backup_profiles { get; set; } = true;
        public bool dynamic_loot_pmcs { get; set; } = false;
        public bool dynamic_loot_scavs { get; set; } = false;
        public bool add_keys { get; set; } = true;
        public bool change_buy_price { get; set; } = true;
        public bool change_heal_cost { get; set; } = true;
        public bool manual_chambering { get; set; } = true;
        public bool reload_changes { get; set; } = true;
        public bool gear_weight { get; set; } = true;
        public bool enable_stances { get; set; } = true;
        public int trader_refresh_time { get; set; } = 1800;
        public int bot_test_tier { get; set; } = 1;
        public decimal standard_bot_hp_multi { get; set; } = 1.0m;
        public decimal mid_bot_hp_multi { get; set; } = 1.0m;
        public decimal boss_bot_hp_multi { get; set; } = 1.0m;
        public decimal player_hp_multi { get; set; } = 1.0m;
        public int[] botTierOdds1 { get; set; } = new int[] { 90, 7, 2, 1, 0 };
        public int[] botTierOdds2 { get; set; } = new int[] { 80, 15, 3, 2, 0 };
        public int[] botTierOdds3 { get; set; } = new int[] { 30, 52, 13, 5, 0 };
        public int[] botTierOdds4 { get; set; } = new int[] { 10, 58, 22, 7, 3 };
        public int[] botTierOdds5 { get; set; } = new int[] { 8, 38, 32, 17, 5 };
        public int[] botTierOdds6 { get; set; } = new int[] { 5, 25, 40, 23, 7 };
        public int[] botTierOdds7 { get; set; } = new int[] { 4, 15, 35, 33, 12 };
        public int[] botTierOdds8 { get; set; } = new int[] { 3, 8, 28, 40, 22 };
        public int[] botTierOdds9 { get; set; } = new int[] { 3, 7, 15, 35, 40 };
        public int bot_hostile1 { get; set; } = 95;
        public int bot_hostile2 { get; set; } = 99;
        public int bot_hostile3 { get; set; } = 100;
        public int rand_stock_modifier { get; set; } = 0;
        public int rand_stock_modifier_min { get; set; } = 0;
        public decimal rand_stackable_modifier { get; set; } = 1m;
        public decimal rand_cost_discount { get; set; } = 0.85m;
        public decimal rand_cost_increase { get; set; } = 1.15m;
        public bool enable_hazard_zones { get; set; } = true;   
    }
}
