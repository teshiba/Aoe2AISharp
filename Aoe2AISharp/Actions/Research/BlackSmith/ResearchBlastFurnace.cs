using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 高温溶鉱炉の研究を行います。
    /// </summary>
    public class ResearchBlastFurnace :Research
    {
        /// <summary>
        /// 高温溶鉱炉の研究を行います。
        /// </summary>
        public ResearchBlastFurnace() : base(ri.blast_furnace)
        {
            Facts.Add(
                new town_under_attack(),
                 new unit_type_count_total(unit.InfantryGroup, relop.ge, 10)
                |new unit_type_count_total(unit.CavalryGroup, relop.ge, 10)
                );
        }
    }
}