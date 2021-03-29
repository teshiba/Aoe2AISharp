using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 
    /// </summary>
    public class InitImperialAge : EnterAge
    {
        /// <summary>
        /// 帝王時代の初期設定を行います。
        /// </summary>
        public InitImperialAge()
        {
            Actions.Add(
                new set_strategic_number(sn.camp_max_distance, 255),
                new set_strategic_number(sn.mill_max_distance, 255),
                new set_strategic_number(sn.maximum_town_size, 255),

                new set_strategic_number(sn.maximum_hunt_drop_distance, 255),
                new set_strategic_number(sn.maximum_food_drop_distance, 255),
                new set_strategic_number(sn.minimum_town_size, 90),
                new set_strategic_number(sn.percent_civilian_builders, 30),
                new set_strategic_number(sn.percent_civilian_gatherers, 70),
                new disable_self()
                );

        }
    }
}