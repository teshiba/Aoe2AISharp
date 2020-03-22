using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 引き具の研究を行います。
    /// </summary>
    public class ResearchHorseCollar : Research 
    {
        /// <summary>
        /// 引き具の研究を行います。
        /// </summary>
        public ResearchHorseCollar() : base(ri.horse_collar)
        {
            Facts.Add(new ResourceAmount(unit.villager, ri.horse_collar).Food);
        }
    }
}