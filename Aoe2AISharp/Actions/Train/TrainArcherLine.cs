using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using System.Collections.Generic;

namespace Aoe2AISharp
{
    internal class TrainArcherLine : Train
    {
        /// <summary>
        /// 射手を指定の数まで生産します
        /// </summary>
        public TrainArcherLine(short count)
            : base(unit.archer_line, count)
        {
            Facts.Add(
                !new civ_selected(civ.spanish)
                    & new ResourceAmount(unit.knight, unit.archer_line).Gold
                    & new ResourceAmount(building.house).Wood
            );
        }
    }
}