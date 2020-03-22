using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 手押し車の研究を行います。
    /// </summary>
    public class ResearchWheelBarrow : Research
    {
        /// <summary>
        /// 町の人が指定人数以上になったら手押し車の研究を行います。
        /// </summary>
        public ResearchWheelBarrow(short villagerCount) : base(ri.wheel_barrow)
        {
            Facts.Add(
                new unit_type_count_total(unit.villager, relop.ge, villagerCount)
                );
        }
    }
}