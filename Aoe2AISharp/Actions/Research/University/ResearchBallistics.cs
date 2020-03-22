using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 弾道学の研究を行います。
    /// </summary>
    public class ResearchBallistics :Research
    {
        /// <summary>
        /// 弾道学の研究を行います。
        /// </summary>
        public ResearchBallistics() : base(ri.ballistics)
        {
            Facts.Add(new unit_type_count_total(unit.ArcherGroup, relop.ge, 10));
        }
    }
}