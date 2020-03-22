using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// エリートユニークユニットの研究を行います。
    /// </summary>
    public class ResearchUniqueUnitUpgrade :Research
    {
        /// <summary>
        /// エリートユニークユニットの研究を行います。
        /// </summary>
        public ResearchUniqueUnitUpgrade()
            : base(ri.my_unique_unit_upgrade)
        {
        }
    }
}