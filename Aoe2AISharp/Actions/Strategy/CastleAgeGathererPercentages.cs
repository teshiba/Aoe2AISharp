using LibAoe2AISharp.Framework;
using System.Collections.ObjectModel;

namespace Aoe2AISharp
{
    /// <summary>
    /// 城主の時代の資源収集割合のコレクション
    /// </summary>
    public class CastleAgeGathererPercentages : Collection<SetGathererRate>
    {
        /// <summary>
        /// 資源収集割合の一覧
        /// </summary>
        private readonly SetGathererRate[] assignVillagers = new SetGathererRate[] {
                /////////////////////////総人口,食,木,金,石
                new SetGathererRate(29,13,11, 5, 0),
                new SetGathererRate(30,13,11, 5, 1),
                new SetGathererRate(31,13,11, 6, 1),
                new SetGathererRate(32,13,11, 7, 1),
                new SetGathererRate(33,13,11, 8, 1),
                new SetGathererRate(34,13,11, 9, 1),
                new SetGathererRate(35,14,11, 9, 1),

                new SetGathererRate(36,14,11,10, 1),
                new SetGathererRate(37,15,11,10, 1),
                new SetGathererRate(38,16,11,10, 1),
                new SetGathererRate(39,16,11,10, 2),
                new SetGathererRate(40,16,12,10, 2),
                new SetGathererRate(41,16,12,11, 2),
                new SetGathererRate(42,17,12,11, 2),
                new SetGathererRate(43,17,12,11, 3),
                new SetGathererRate(44,17,13,11, 3),
                new SetGathererRate(45,17,14,11, 3),
                new SetGathererRate(46,17,15,11, 3),
                new SetGathererRate(47,17,15,11, 4),

                new SetGathererRate(48,17,17,11, 4),
                new SetGathererRate(49,17,17,11, 4),
                new SetGathererRate(50,18,17,11, 4),
                new SetGathererRate(51,18,18,11, 4),
                new SetGathererRate(52,19,18,11, 4),
                new SetGathererRate(53,20,18,11, 4),
                new SetGathererRate(54,21,18,11, 4),
                new SetGathererRate(55,22,18,11, 4),
                new SetGathererRate(56,22,19,11, 4),
                new SetGathererRate(57,23,19,11, 4),
                new SetGathererRate(58,24,19,11, 4),
                new SetGathererRate(59,25,19,11, 4),
                new SetGathererRate(60,26,19,11, 4),
                new SetGathererRate(61,27,19,11, 4),
                new SetGathererRate(62,27,19,12, 4),
                new SetGathererRate(63,27,19,13, 4),
                new SetGathererRate(64,28,19,13, 4),
                new SetGathererRate(65,29,19,13, 4),
                new SetGathererRate(66,31,19,12, 4),
                new SetGathererRate(67,31,19,13, 4),
                new SetGathererRate(68,32,19,13, 4),
                new SetGathererRate(69,32,20,13, 4),
                new SetGathererRate(70,32,21,13, 4),

                new SetGathererRate(71,33,21,13, 4),
                new SetGathererRate(72,33,22,13, 4),
                new SetGathererRate(73,33,23,13, 4),
                new SetGathererRate(74,33,23,14, 4),
                new SetGathererRate(75,33,23,16, 4),
                new SetGathererRate(76,30,26,16, 4),
                new SetGathererRate(77,30,27,16, 4),
                new SetGathererRate(78,30,28,16, 4),

                new SetGathererRate(79,30,29,16, 4),
                new SetGathererRate(80,31,29,16, 4),
                new SetGathererRate(81,32,29,16, 4),
                new SetGathererRate(82,33,29,16, 4),
                new SetGathererRate(83,34,29,16, 4),
                new SetGathererRate(84,35,29,16, 4),
                new SetGathererRate(85,36,29,16, 4),
                new SetGathererRate(86,37,29,16, 4),
                new SetGathererRate(87,38,29,16, 4),
                new SetGathererRate(88,39,29,16, 4),
                new SetGathererRate(89,40,29,16, 4),
        };

        /// <summary>
        /// 城主の時代の資源収集割合を増加する人数ごとに定義
        /// </summary>
        public CastleAgeGathererPercentages()
        {
            foreach (var item in assignVillagers) {
                Add(item);
            }
        }
    }
}