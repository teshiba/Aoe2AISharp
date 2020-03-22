using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using System.Collections.Generic;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 指定の数以上ユニットが生産されていたら、
    /// アップグレードの研究を行う抽象クラス。
    /// </summary>
    public abstract class ResearchUnitNumberCondition : Research
    {
        private readonly Dictionary<ri, unit> researchUnit = new Dictionary<ri, unit>() {
            {ri.man_at_arms,        unit.militiaman_line    },
            {ri.crossbow,           unit.archer             },
            {ri.elite_skirmisher,   unit.skirmisher         }
        };

        /// <summary>
        /// 指定の数以上のユニットが生産されていたら、
        /// そのユニットのアップグレードの研究を行います。
        /// </summary>
        /// <param name="researchItem">ユニットのアップグレードの研究種類</param>
        /// <param name="baseUnitCount">アップグレードに必要なベースユニットの数</param>
        protected ResearchUnitNumberCondition(ri researchItem, short baseUnitCount) : base(researchItem)
        {
            if (!researchUnit.TryGetValue(researchItem, out unit baseUnit)) {
                throw new System.NotImplementedException("指定のユニットはまだresearchUnitに実装されていないか、アップグレードできるユニットではありません。");
            }

            Facts.Add(new unit_type_count(baseUnit, relop.ge, baseUnitCount));
        }
    }
}