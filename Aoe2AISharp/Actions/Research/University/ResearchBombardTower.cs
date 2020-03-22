using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 砲台を研究します。
    /// </summary>
    public class ResearchBombardTower :Research
    {
        /// <summary>
        /// 砲台を研究します。
        /// </summary>
        public ResearchBombardTower() : base(ri.bombard_tower)
        {
        }
    }
}