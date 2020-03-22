﻿using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 鍛造の研究を行います。
    /// </summary>
    public class ResearchForging :Research
    {
        /// <summary>
        /// 鍛造の研究を行います。
        /// </summary>
        public ResearchForging() : base(ri.forging)
        {
            Facts.Add(
                 new town_under_attack(),
                  new unit_type_count_total(unit.CavalryGroup, relop.ge, 5)
                | new unit_type_count_total(unit.InfantryGroup, relop.ge, 5)
                );
        }
    }
}