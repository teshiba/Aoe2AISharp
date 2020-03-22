using LibAoe2AISharp.Specifications;
using System;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    internal class ResignTimeout : defrule
    {

        /// <summary>
        /// 降参するまでのゲーム内時間を設定します
        /// </summary>
        /// <param name="time">"hh:mm:ss"形式の文字列を設定します。</param>
        public ResignTimeout(string time)
            : this((short)DateTime.Parse(time).TimeOfDay.TotalSeconds)
        {
        }

        /// <summary>
        /// 降参するまでのゲーム内時間を設定します
        /// </summary>
        /// <param name="second">秒単位を数値で設定します。</param>
        public ResignTimeout(short second)
        {
            Comment = "おつ（′・ω・`；" + second / 60 + "分以上経過";
            Facts.Add(
                 new game_time(relop.ge, second),
                !new player_in_game(player_number.any_ally)//同盟がいない時のみ降参する
                );
            Actions.Add(new resign());
        }

        /// <summary>
        /// 降参するまでのゲーム内時間を設定します
        /// </summary>
        /// <param name="time">"hh:mm:ss"形式の文字列を設定します。</param>
        /// <param name="villagerCount">降参しないための町の人の人数</param>
        public ResignTimeout(string time, short villagerCount)
            : this((short)DateTime.Parse(time).TimeOfDay.TotalSeconds, villagerCount)
        {
        }

        /// <summary>
        /// 降参するまでのゲーム内時間を設定します
        /// </summary>
        /// <param name="second">秒単位を数値で設定します。</param>
        /// <param name="villagerCount">降参しないための町の人の人数</param>
        public ResignTimeout(short second, short villagerCount)
        {
            Comment = "おつ（′・ω・`；" + second / 60 + "分以上経過" + villagerCount + "人以下";
            Facts.Add(
                 new game_time(relop.ge, second),
                !new player_in_game(player_number.any_ally), //同盟がいない時のみ降参する
                 new unit_type_count(unit.villager, relop.lt, villagerCount));
            Actions.Add(new resign());
        }
    }
}