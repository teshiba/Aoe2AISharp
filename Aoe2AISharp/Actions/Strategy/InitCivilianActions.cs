using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// ゲーム開始時の町の人の作業分担設定.
    /// </summary>
    public class InitCivilianActions : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitCivilianActions"/> class.
        /// </summary>
        public InitCivilianActions()
        {
            Comment = "ゲーム開始時の町の人の作業分担設定";

            Actions.Add(
                new SetGathererRateCollection(100, 0, 0, 0),
                new set_strategic_number(sn.cap_civilian_builders, 200),
                new set_strategic_number(sn.cap_civilian_explorers, 0),
                new set_strategic_number(sn.cap_civilian_gatherers, 200),
                new set_strategic_number(sn.percent_civilian_builders, 10),
                new set_strategic_number(sn.percent_civilian_explorers, 0),
                new set_strategic_number(sn.percent_civilian_gatherers, 90),
                new set_strategic_number(sn.food_dropsite_distance, 3),
                new set_strategic_number(sn.camp_max_distance, 15),
                new set_strategic_number(sn.maximum_town_size, 30),
                new set_strategic_number(sn.mill_max_distance, 30),
                new set_strategic_number(sn.maximum_hunt_drop_distance, 30),
                new set_strategic_number(sn.maximum_food_drop_distance, 30),
                new set_strategic_number(sn.retask_gather_amount, 5),
                new set_strategic_number(sn.max_retask_gather_amount, 5),
                new set_strategic_number(sn.required_forest_tiles, 35),
                new disable_self());
        }
    }
}