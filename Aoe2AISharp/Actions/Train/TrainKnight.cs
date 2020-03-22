using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 騎士を生産します。
    /// </summary>
    public class TrainKnight : Train
    {
        /// <summary>
        /// 騎士を生産します。
        /// </summary>
        public TrainKnight(short count) : base(unit.knight_line, count)
        {
            Facts.Add(
                new ResourceAmount(unit.knight, unit.villager).Food
            );
        }
    }
   

}