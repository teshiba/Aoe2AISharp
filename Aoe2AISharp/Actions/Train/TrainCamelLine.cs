using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// らくだ系列を生産します。
    /// </summary>
    public class TrainCamelLine : Train
    {
        /// <summary>
        /// らくだ系列を生産します。
        /// </summary>
        public TrainCamelLine(short count) : base(unit.camel_line, count)
        {
            Facts.Add(
                new ResourceAmount(unit.camel_line, unit.villager).Food
                & 
                (
                 !new unit_available(unit.knight_line)
                | new unit_type_count_total(unit.knight_line, relop.ge, 5)
                )
            );
        }
    }
   

}