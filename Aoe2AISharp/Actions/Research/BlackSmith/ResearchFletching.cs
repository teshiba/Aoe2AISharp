using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 矢羽根の研究を行います。
    /// </summary>
    public class ResearchFletching : Research
    {
        /// <summary>
        /// 弓系が一定以上になったら矢羽根の研究を行います。
        /// </summary>
        /// <param name="archerGroupCount"></param>
        public ResearchFletching(short archerGroupCount)
            : base(ri.fletching, unit.ArcherGroup, archerGroupCount)
        {
            Facts.Add(new ResourceAmount(unit.villager, ri.fletching).Food);
        }
    }
}