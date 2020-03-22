using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 鋳造の研究を行います。
    /// </summary>
    public class ResearchIronCasting :Research
    {
        /// <summary>
        /// 鋳造の研究を行います。
        /// </summary>
        public ResearchIronCasting() : base(ri.iron_casting)
        {
            Facts.Add(
                new town_under_attack(),
                 new unit_type_count_total(unit.InfantryGroup, relop.ge, 10)
                |new unit_type_count_total(unit.CavalryGroup, relop.ge, 10)
                );
        }
    }
}