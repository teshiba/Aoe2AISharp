using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 遠投投石機を生産します。
    /// </summary>
    public class TrainTrebuchet : Train
    {
        /// <summary>
        /// 遠投投石機を生産します。
        /// </summary>
        public TrainTrebuchet() : base(unit.trebuchet)
        {
        }
    }
}