using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 城主時代の初期設定を行います。
    /// </summary>
    public class InitCastleAge : EnterAge
    {
        /// <summary>
        /// 城主時代の初期設定を行います。
        /// 進化時に設定した時代の状態ゴールを進化完了状態にして
        /// 資源収集割合を変えます。
        /// </summary>
        public InitCastleAge()
        {
            Actions.Add(
                new set_strategic_number(sn.camp_max_distance, 40),
                new set_strategic_number(sn.mill_max_distance, 50),

                new set_strategic_number(sn.percent_civilian_builders, 20),
                new set_strategic_number(sn.percent_civilian_gatherers, 80),

                new set_strategic_number(sn.maximum_hunt_drop_distance, 50),
                new set_strategic_number(sn.maximum_food_drop_distance, 50),
                new set_strategic_number(sn.required_forest_tiles, 5),

                //町の中心を立てる位置を考慮
                new set_strategic_number(sn.maximum_town_size, 20)
               );
        }
    }
}