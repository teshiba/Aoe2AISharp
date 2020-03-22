using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// ユニークユニットを生産します。
    /// </summary>
    public class TrainUniqueUnit :Train
    {
        /// <summary>
        /// ユニークユニットを指定の数になるまで生産します。
        /// </summary>
        /// <param name="count"></param>
        public TrainUniqueUnit(short count)
            : base(unit.my_unique_unit_line, count)
        {
            Facts.Add(
                new ResourceAmount(unit.villager)
            );
        }
    }
}