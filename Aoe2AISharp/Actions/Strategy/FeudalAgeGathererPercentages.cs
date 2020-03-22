using LibAoe2AISharp.Framework;
using System.Collections.ObjectModel;

namespace Aoe2AISharp
{
    /// <summary>
    /// 領主の時代の資源収集割合のコレクション
    /// </summary>
    public class FeudalAgeGathererPercentages : Collection<SetGathererRate>
    {
        /// <summary>
        /// 資源収集割合の一覧
        /// </summary>
        private readonly SetGathererRate[] assignVillagers = new SetGathererRate[] {
                /////////////////////////総人口,食,木,金,石
                new SetGathererRate(24,10,12, 2, 0),//槍散兵R24人進化タイミング
                new SetGathererRate(25,11,12, 2, 0),
                new SetGathererRate(26,12,12, 2, 0),
                new SetGathererRate(27,12,13, 2, 0),
                new SetGathererRate(28,12,13, 3, 0),
                new SetGathererRate(29,12,14, 3, 0),
                //即城主の領主進化タイミング領主では以降町の人を生産しない
                new SetGathererRate(30,13,14, 3, 0),
                new SetGathererRate(31,14,14, 3, 0),
                new SetGathererRate(32,14,14, 4, 0),
                new SetGathererRate(33,14,15, 4, 0),
                new SetGathererRate(34,14,16, 4, 0),
                new SetGathererRate(35,15,16, 4, 0),
                                                  // 手押し車
                new SetGathererRate(36,15,16, 5, 0),//
                new SetGathererRate(37,15,16, 6, 0),//
                new SetGathererRate(38,15,16, 7, 0),//
                new SetGathererRate(39,15,16, 8, 0),//castle age

                new SetGathererRate(40,15,16, 9, 0),//
                new SetGathererRate(41,16,16, 9, 0),//
                new SetGathererRate(42,16,17, 9, 0),//
                new SetGathererRate(43,16,18, 9, 0),//
                new SetGathererRate(44,16,19, 9, 0),//
                new SetGathererRate(45,16,20, 9, 0),//
        };

        /// <summary>
        /// 領主の時代の資源収集割合を増加する人数ごとに定義
        /// </summary>
        public FeudalAgeGathererPercentages()
        {
            foreach (var item in assignVillagers) {
                Add(item);
            }
        }
    }
}