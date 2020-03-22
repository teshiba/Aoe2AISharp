using LibAoe2AISharp.Framework;
using System.Collections.ObjectModel;

namespace Aoe2AISharp
{
    /// <summary>
    /// 帝王の時代の資源収集割合のコレクション
    /// </summary>
    public class ImperialAgeGathererPercentages : Collection<SetGathererRate>
    {
        /// <summary>
        /// 資源収集割合の一覧
        /// </summary>
        private readonly SetGathererRate[] assignVillagers = new SetGathererRate[] {
                //食,木,金,石
                new SetGathererRate(35, 35, 20, 10),
        };

        /// <summary>
        /// 城主の時代の資源収集割合を増加する人数ごとに定義
        /// </summary>
        public ImperialAgeGathererPercentages()
        {
            foreach (var item in assignVillagers) {
                Add(item);
            }
        }
    }
}