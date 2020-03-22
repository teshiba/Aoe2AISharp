using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 防御塔の研究を行います。
    /// </summary>
    public class ResearchKeep :Research
    {
        /// <summary>
        /// 塔があれば防御塔の研究を行います。
        /// </summary>
        public ResearchKeep() : base(ri.keep)
        {
            Facts.Add(
                new building_type_count_total(building.watch_tower_line, relop.ge, 1)
                );
        }
    }
}