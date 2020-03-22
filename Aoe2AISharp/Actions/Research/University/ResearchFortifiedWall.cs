using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 強化壁の研究を行います。
    /// </summary>
    public class ResearchFortifiedWall :Research
    {
        /// <summary>
        /// 強化壁の研究を行います。
        /// </summary>
        public ResearchFortifiedWall() : base(ri.fortified_wall)
        {
            Facts
                .Add(new wall_completed_percentage(Perimeter.Near, relop.ge, 60));
        }
    }
}