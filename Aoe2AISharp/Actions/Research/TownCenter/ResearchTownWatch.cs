using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 見張りの研究を行います。
    /// </summary>
    public class ResearchTownWatch :Research
    {
        /// <summary>
        /// 見張りの研究を行います。
        /// </summary>
        public ResearchTownWatch() : base(ri.town_watch)
        {
            Facts.Add(
                new building_type_count_total(building.town_center, relop.ge, 2)
                );
        }
    }
}