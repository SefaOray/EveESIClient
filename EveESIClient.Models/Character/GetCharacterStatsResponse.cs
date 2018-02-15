using System;

namespace EveESIClient.Models.Character
{
    public class GetCharacterStatsResponse
    {
        public int Year { get; set; }

        public CharacterStatsCharacter Character { get; set; }
        public CharacterStatsCombat Combat { get; set; }
        public CharacterStatsIndustry Industry { get; set; }
        public CharacterStatsInventory Inventory { get; set; }
        public CharacterStatsIsk Isk { get; set; }
        public CharacterStatsMarket Market { get; set; }
        public CharacterStatsMining Mining { get; set; }
        public CharacterStatsModule Module { get; set; }
        public CharacterStatsOrbital Orbital { get; set; }
        public CharacterStatsPve Pve { get; set; }
        public CharacterStatsSocial Social { get; set; }
        public CharacterStatsTravel Travel { get; set; }

        public class CharacterStatsCharacter
        {
            public Int64? Days_of_activity { get; set; }
            public Int64? Minutes { get; set; }
            public Int64? Sessions_started { get; set; }
        }

        public class CharacterStatsCombat
        {
            public Int64? Cap_drainedby_npc { get; set; }
            public Int64? Cap_drainedby_pc { get; set; }
            public Int64? Cap_draining_pc { get; set; }
            public Int64? Criminal_flag_set { get; set; }
            public Int64? Damage_from_np_cs_amount { get; set; }
            public Int64? Damage_from_np_cs_num_shots { get; set; }
            public Int64? Damage_from_players_bomb_amount { get; set; }
            public Int64? Damage_from_players_bomb_num_shots { get; set; }
            public Int64? Damage_from_players_combat_drone_amount { get; set; }
            public Int64? Damage_from_players_combat_drone_num_shots { get; set; }
            public Int64? Damage_from_players_energy_amount { get; set; }
            public Int64? Damage_from_players_energy_num_shots { get; set; }
            public Int64? Damage_from_players_fighter_bomber_amount { get; set; }
            public Int64? Damage_from_players_fighter_bomber_num_shots { get; set; }
            public Int64? Damage_from_players_fighter_drone_amount { get; set; }
            public Int64? Damage_from_players_fighter_drone_num_shots { get; set; }
            public Int64? Damage_from_players_hybrid_amount { get; set; }
            public Int64? Damage_from_players_hybrid_num_shots { get; set; }
            public Int64? Damage_from_players_missile_amount { get; set; }
            public Int64? Damage_from_players_missile_num_shots { get; set; }
            public Int64? Damage_from_players_projectile_amount { get; set; }
            public Int64? Damage_from_players_projectile_num_shots { get; set; }
            public Int64? Damage_from_players_smart_bomb_amount { get; set; }
            public Int64? Damage_from_players_smart_bomb_num_shots { get; set; }
            public Int64? Damage_from_players_super_amount { get; set; }
            public Int64? Damage_from_players_super_num_shots { get; set; }
            public Int64? Damage_from_structures_total_amount { get; set; }
            public Int64? Damage_from_structures_total_num_shots { get; set; }
            public Int64? Damage_to_players_bomb_amount { get; set; }
            public Int64? Damage_to_players_bomb_num_shots { get; set; }
            public Int64? Damage_to_players_combat_drone_amount { get; set; }
            public Int64? Damage_to_players_combat_drone_num_shots { get; set; }
            public Int64? Damage_to_players_energy_amount { get; set; }
            public Int64? Damage_to_players_energy_num_shots { get; set; }
            public Int64? Damage_to_players_fighter_bomber_amount { get; set; }
            public Int64? Damage_to_players_fighter_bomber_num_shots { get; set; }
            public Int64? Damage_to_players_fighter_drone_amount { get; set; }
            public Int64? Damage_to_players_fighter_drone_num_shots { get; set; }
            public Int64? Damage_to_players_hybrid_amount { get; set; }
            public Int64? Damage_to_players_hybrid_num_shots { get; set; }
            public Int64? Damage_to_players_missile_amount { get; set; }
            public Int64? Damage_to_players_missile_num_shots { get; set; }
            public Int64? Damage_to_players_projectile_amount { get; set; }
            public Int64? Damage_to_players_projectile_num_shots { get; set; }
            public Int64? Damage_to_players_smart_bomb_amount { get; set; }
            public Int64? Damage_to_players_smart_bomb_num_shots { get; set; }
            public Int64? Damage_to_players_super_amount { get; set; }
            public Int64? Damage_to_players_super_num_shots { get; set; }
            public Int64? Damage_to_structures_total_amount { get; set; }
            public Int64? Damage_to_structures_total_num_shots { get; set; }
            public Int64? Deaths_high_sec { get; set; }
            public Int64? Deaths_low_sec { get; set; }
            public Int64? Deaths_null_sec { get; set; }
            public Int64? Deaths_pod_high_sec { get; set; }
            public Int64? Deaths_pod_low_sec { get; set; }
            public Int64? Deaths_pod_null_sec { get; set; }
            public Int64? Deaths_pod_wormhole { get; set; }
            public Int64? Deaths_wormhole { get; set; }
            public Int64? Drone_engage { get; set; }
            public Int64? Dscans { get; set; }
            public Int64? Duel_requested { get; set; }
            public Int64? Engagement_register { get; set; }
            public Int64? Kills_assists { get; set; }
            public Int64? Kills_high_sec { get; set; }
            public Int64? Kills_low_sec { get; set; }
            public Int64? Kills_null_sec { get; set; }
            public Int64? Kills_pod_high_sec { get; set; }
            public Int64? Kills_pod_low_sec { get; set; }
            public Int64? Kills_pod_null_sec { get; set; }
            public Int64? Kills_pod_wormhole { get; set; }
            public Int64? Kills_wormhole { get; set; }
            public Int64? Npc_flag_set { get; set; }
            public Int64? Probe_scans { get; set; }
            public Int64? Pvp_flag_set { get; set; }
            public Int64? Repair_armor_by_remote_amount { get; set; }
            public Int64? Repair_armor_remote_amount { get; set; }
            public Int64? Repair_armor_self_amount { get; set; }
            public Int64? Repair_capacitor_by_remote_amount { get; set; }
            public Int64? Repair_capacitor_remote_amount { get; set; }
            public Int64? Repair_capacitor_self_amount { get; set; }
            public Int64? Repair_hull_by_remote_amount { get; set; }
            public Int64? Repair_hull_remote_amount { get; set; }
            public Int64? Repair_hull_self_amount { get; set; }
            public Int64? Repair_shield_by_remote_amount { get; set; }
            public Int64? Repair_shield_remote_amount { get; set; }
            public Int64? Repair_shield_self_amount { get; set; }
            public Int64? Self_destructs { get; set; }
            public Int64? Warp_scramble_pc { get; set; }
            public Int64? Warp_scrambledby_npc { get; set; }
            public Int64? Warp_scrambledby_pc { get; set; }
            public Int64? Weapon_flag_set { get; set; }
            public Int64? Webifiedby_npc { get; set; }
            public Int64? Webifiedby_pc { get; set; }
            public Int64? Webifying_pc { get; set; }
        }

        public class CharacterStatsIndustry
        {
            public Int64? Hacking_successes { get; set; }
            public Int64? Jobs_cancelled { get; set; }
            public Int64? Jobs_completed_copy_blueprint { get; set; }
            public Int64? Jobs_completed_invention { get; set; }
            public Int64? Jobs_completed_manufacture { get; set; }
            public Int64? Jobs_completed_manufacture_asteroid { get; set; }
            public Int64? Jobs_completed_manufacture_asteroid_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_charge { get; set; }
            public Int64? Jobs_completed_manufacture_charge_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_commodity { get; set; }
            public Int64? Jobs_completed_manufacture_commodity_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_deployable { get; set; }
            public Int64? Jobs_completed_manufacture_deployable_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_drone { get; set; }
            public Int64? Jobs_completed_manufacture_drone_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_implant { get; set; }
            public Int64? Jobs_completed_manufacture_implant_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_module { get; set; }
            public Int64? Jobs_completed_manufacture_module_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_other { get; set; }
            public Int64? Jobs_completed_manufacture_other_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_ship { get; set; }
            public Int64? Jobs_completed_manufacture_ship_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_structure { get; set; }
            public Int64? Jobs_completed_manufacture_structure_quantity { get; set; }
            public Int64? Jobs_completed_manufacture_subsystem { get; set; }
            public Int64? Jobs_completed_manufacture_subsystem_quantity { get; set; }
            public Int64? Jobs_completed_material_productivity { get; set; }
            public Int64? Jobs_completed_time_productivity { get; set; }
            public Int64? Jobs_started_copy_blueprint { get; set; }
            public Int64? Jobs_started_invention { get; set; }
            public Int64? Jobs_started_manufacture { get; set; }
            public Int64? Jobs_started_material_productivity { get; set; }
            public Int64? Jobs_started_time_productivity { get; set; }
            public Int64? Reprocess_item { get; set; }
            public Int64? Reprocess_item_quantity { get; set; }
        }

        public class CharacterStatsInventory
        {
            public Int64? Abandon_loot_quantity { get; set; }
            public Int64? Trash_item_quantity { get; set; }
        }

        public class CharacterStatsIsk
        {
            public Int64? In { get; set; }
            public Int64? Out { get; set; }
        }

        public class CharacterStatsMarket
        {
            public Int64? Accept_contracts_courier { get; set; }
            public Int64? Accept_contracts_item_exchange { get; set; }
            public Int64? Buy_orders_placed { get; set; }
            public Int64? Cancel_market_order { get; set; }
            public Int64? Create_contracts_auction { get; set; }
            public Int64? Create_contracts_courier { get; set; }
            public Int64? Create_contracts_item_exchange { get; set; }
            public Int64? Deliver_courier_contract { get; set; }
            public Int64? Isk_gained { get; set; }
            public Int64? Isk_spent { get; set; }
            public Int64? Modify_market_order { get; set; }
            public Int64? Search_contracts { get; set; }
            public Int64? Sell_orders_placed { get; set; }
        }

        public class CharacterStatsMining
        {
            public Int64? Drone_mine { get; set; }
            public Int64? Ore_arkonor { get; set; }
            public Int64? Ore_bistot { get; set; }
            public Int64? Ore_crokite { get; set; }
            public Int64? Ore_dark_ochre { get; set; }
            public Int64? Ore_gneiss { get; set; }
            public Int64? Ore_harvestable_cloud { get; set; }
            public Int64? Ore_hedbergite { get; set; }
            public Int64? Ore_hemorphite { get; set; }
            public Int64? Ore_ice { get; set; }
            public Int64? Ore_jaspet { get; set; }
            public Int64? Ore_kernite { get; set; }
            public Int64? Ore_mercoxit { get; set; }
            public Int64? Ore_omber { get; set; }
            public Int64? Ore_plagioclase { get; set; }
            public Int64? Ore_pyroxeres { get; set; }
            public Int64? Ore_scordite { get; set; }
            public Int64? Ore_spodumain { get; set; }
            public Int64? Ore_veldspar { get; set; }
        }

        public class CharacterStatsModule
        {
            public Int64? Activations_armor_hardener { get; set; }
            public Int64? Activations_armor_repair_unit { get; set; }
            public Int64? Activations_armor_resistance_shift_hardener { get; set; }
            public Int64? Activations_automated_targeting_system { get; set; }
            public Int64? Activations_bastion { get; set; }
            public Int64? Activations_bomb_launcher { get; set; }
            public Int64? Activations_capacitor_booster { get; set; }
            public Int64? Activations_cargo_scanner { get; set; }
            public Int64? Activations_cloaking_device { get; set; }
            public Int64? Activations_clone_vat_bay { get; set; }
            public Int64? Activations_cynosural_field { get; set; }
            public Int64? Activations_damage_control { get; set; }
            public Int64? Activations_data_miners { get; set; }
            public Int64? Activations_drone_control_unit { get; set; }
            public Int64? Activations_drone_tracking_modules { get; set; }
            public Int64? Activations_eccm { get; set; }
            public Int64? Activations_ecm { get; set; }
            public Int64? Activations_ecm_burst { get; set; }
            public Int64? Activations_energy_destabilizer { get; set; }
            public Int64? Activations_energy_vampire { get; set; }
            public Int64? Activations_energy_weapon { get; set; }
            public Int64? Activations_festival_launcher { get; set; }
            public Int64? Activations_frequency_mining_laser { get; set; }
            public Int64? Activations_fueled_armor_repairer { get; set; }
            public Int64? Activations_fueled_shield_booster { get; set; }
            public Int64? Activations_gang_coordinator { get; set; }
            public Int64? Activations_gas_cloud_harvester { get; set; }
            public Int64? Activations_hull_repair_unit { get; set; }
            public Int64? Activations_hybrid_weapon { get; set; }
            public Int64? Activations_industrial_core { get; set; }
            public Int64? Activations_interdiction_sphere_launcher { get; set; }
            public Int64? Activations_micro_jump_drive { get; set; }
            public Int64? Activations_mining_laser { get; set; }
            public Int64? Activations_missile_launcher { get; set; }
            public Int64? Activations_passive_targeting_system { get; set; }
            public Int64? Activations_probe_launcher { get; set; }
            public Int64? Activations_projected_eccm { get; set; }
            public Int64? Activations_projectile_weapon { get; set; }
            public Int64? Activations_propulsion_module { get; set; }
            public Int64? Activations_remote_armor_repairer { get; set; }
            public Int64? Activations_remote_capacitor_transmitter { get; set; }
            public Int64? Activations_remote_ecm_burst { get; set; }
            public Int64? Activations_remote_hull_repairer { get; set; }
            public Int64? Activations_remote_sensor_booster { get; set; }
            public Int64? Activations_remote_sensor_damper { get; set; }
            public Int64? Activations_remote_shield_booster { get; set; }
            public Int64? Activations_remote_tracking_computer { get; set; }
            public Int64? Activations_salvager { get; set; }
            public Int64? Activations_sensor_booster { get; set; }
            public Int64? Activations_shield_booster { get; set; }
            public Int64? Activations_shield_hardener { get; set; }
            public Int64? Activations_ship_scanner { get; set; }
            public Int64? Activations_siege { get; set; }
            public Int64? Activations_smart_bomb { get; set; }
            public Int64? Activations_stasis_web { get; set; }
            public Int64? Activations_strip_miner { get; set; }
            public Int64? Activations_super_weapon { get; set; }
            public Int64? Activations_survey_scanner { get; set; }
            public Int64? Activations_target_breaker { get; set; }
            public Int64? Activations_target_painter { get; set; }
            public Int64? Activations_tracking_computer { get; set; }
            public Int64? Activations_tracking_disruptor { get; set; }
            public Int64? Activations_tractor_beam { get; set; }
            public Int64? Activations_triage { get; set; }
            public Int64? Activations_warp_disrupt_field_generator { get; set; }
            public Int64? Activations_warp_scrambler { get; set; }
            public Int64? Link_weapons { get; set; }
            public Int64? Overload { get; set; }
            public Int64? Repairs { get; set; }
        }

        public class CharacterStatsOrbital
        {
            public Int64? Strike_characters_killed { get; set; }
            public Int64? Strike_damage_to_players_armor_amount { get; set; }
            public Int64? Strike_damage_to_players_shield_amount { get; set; }
        }

        public class CharacterStatsPve
        {
            public Int64? Dungeons_completed_agent { get; set; }
            public Int64? Dungeons_completed_distribution { get; set; }
            public Int64? Missions_succeeded { get; set; }
            public Int64? Missions_succeeded_epic_arc { get; set; }
        }

        public class CharacterStatsSocial
        {
            public Int64? Add_contact_bad { get; set; }
            public Int64? Add_contact_good { get; set; }
            public Int64? Add_contact_high { get; set; }
            public Int64? Add_contact_horrible { get; set; }
            public Int64? Add_contact_neutral { get; set; }
            public Int64? Add_note { get; set; }
            public Int64? Added_as_contact_bad { get; set; }
            public Int64? Added_as_contact_good { get; set; }
            public Int64? Added_as_contact_high { get; set; }
            public Int64? Added_as_contact_horrible { get; set; }
            public Int64? Added_as_contact_neutral { get; set; }
            public Int64? Calendar_event_created { get; set; }
            public Int64? Chat_messages_alliance { get; set; }
            public Int64? Chat_messages_constellation { get; set; }
            public Int64? Chat_messages_corporation { get; set; }
            public Int64? Chat_messages_fleet { get; set; }
            public Int64? Chat_messages_region { get; set; }
            public Int64? Chat_messages_solarsystem { get; set; }
            public Int64? Chat_messages_warfaction { get; set; }
            public Int64? Chat_total_message_length { get; set; }
            public Int64? Direct_trades { get; set; }
            public Int64? Fleet_broadcasts { get; set; }
            public Int64? Fleet_joins { get; set; }
            public Int64? Mails_received { get; set; }
            public Int64? Mails_sent { get; set; }
        }

        public class CharacterStatsTravel
        {
            public Int64? Aacceleration_gate_activations { get; set; }
            public Int64? Aalign_to { get; set; }
            public Int64? Distance_warped_high_sec { get; set; }
            public Int64? Distance_warped_low_sec { get; set; }
            public Int64? Distance_warped_null_sec { get; set; }
            public Int64? Distance_warped_wormhole { get; set; }
            public Int64? Docks_high_sec { get; set; }
            public Int64? Docks_low_sec { get; set; }
            public Int64? Docks_null_sec { get; set; }
            public Int64? Jumps_stargate_high_sec { get; set; }
            public Int64? Jumps_stargate_low_sec { get; set; }
            public Int64? Jumps_stargate_null_sec { get; set; }
            public Int64? Jumps_wormhole { get; set; }
            public Int64? Warps_high_sec { get; set; }
            public Int64? Warps_low_sec { get; set; }
            public Int64? Warps_null_sec { get; set; }
            public Int64? Warps_to_bookmark { get; set; }
            public Int64? Warps_to_celestial { get; set; }
            public Int64? Warps_to_fleet_member { get; set; }
            public Int64? Warps_to_scan_result { get; set; }
            public Int64? Warps_wormhole { get; set; }
        }
    }
}