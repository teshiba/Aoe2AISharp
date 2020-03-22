using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using System.Collections.ObjectModel;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 暗黒の時代の資源収集割合のコレクション
    /// </summary>
    public class DarkAgeGathererPercentages
        : Collection<SetGathererRate>
    {
        /// <summary>
        /// 資源収集割合の一覧
        /// </summary>
        private readonly SetGathererRate[] assignVillagers = new SetGathererRate[] {
                /////////////////////////総人口,食,木,金,石
                new SetGathererRate( 3, 3, 0, 0, 0),
                new SetGathererRate( 4, 4, 0, 0, 0),
                new SetGathererRate( 5, 5, 0, 0, 0),
                new SetGathererRate( 6, 6, 0, 0, 0),

                new SetGathererRate( 7, 6, 1, 0, 0),//6人で羊を狩る
                new SetGathererRate( 8, 6, 2, 0, 0),
                new SetGathererRate( 9, 6, 3, 0, 0),
                new SetGathererRate(10, 6, 4, 0, 0),//木こりは人口20人まで4人

                new SetGathererRate(11, 7, 4, 0, 0),
                new SetGathererRate(12, 8, 4, 0, 0),
                new SetGathererRate(13, 9, 4, 0, 0),
                new SetGathererRate(14,10, 4, 0, 0),
                new SetGathererRate(15,11, 4, 0, 0),
                new SetGathererRate(16,12, 4, 0, 0),
                new SetGathererRate(17,13, 4, 0, 0),
                new SetGathererRate(18,14, 4, 0, 0),
                new SetGathererRate(19,15, 4, 0, 0),

                new SetGathererRate(20,16, 4, 0, 0),
                new SetGathererRate(20,10,10, 0, 0, new food_amount(relop.ge, 300), "多飯"),
                new SetGathererRate(20, 7,13, 0, 0, new food_amount(relop.ge, 450), "多飯"),

                new SetGathererRate(21,16, 5, 0, 0),
                new SetGathererRate(21,17, 4, 0, 0, new food_amount(relop.lt, 350), "少飯"),
                new SetGathererRate(21,10,11, 0, 0, new food_amount(relop.ge, 450), "多飯"),
                new SetGathererRate(21, 7,14, 0, 0, new food_amount(relop.ge, 500), "多飯"),

                new SetGathererRate(22,16, 6, 0, 0),
                new SetGathererRate(22, 7,15, 0, 0, new food_amount(relop.ge, 500), "多飯"),
                new SetGathererRate(23,16, 7, 0, 0),
                new SetGathererRate(23, 7,16, 0, 0, new food_amount(relop.ge, 500), "おなかいっぱい500"),

                new SetGathererRate(24,16, 8, 0, 0),//槍散兵R24人進化タイミング
                new SetGathererRate(24, 7,17, 0, 0, new food_amount(relop.ge, 600), "食べすぎ！"),

                new SetGathererRate(25,16, 9, 0, 0),
                new SetGathererRate(26,16, 9, 1, 0),
                new SetGathererRate(27,16, 9, 2, 0),
                new SetGathererRate(28,16, 9, 3, 0),
                new SetGathererRate(29,16, 9, 4, 0),//即城主
        };

        /// <summary>
        /// 暗黒の時代の資源収集割合を増加する人数ごとに定義
        /// </summary>
        public DarkAgeGathererPercentages()
        {
            foreach (var item in assignVillagers) {
                Add(item);
            }
        }
    }
}