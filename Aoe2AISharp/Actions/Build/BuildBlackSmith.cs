using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    internal class BuildBlackSmith : Build
    {
        /// <summary>
        /// 指定の建物が指定の数できたら鉄工所を指定の数になるまで建設します。
        /// </summary>
        /// <param name="count">建設する最大数</param>
        /// <param name="required">必要な建物</param>
        /// <param name="requiredCount">必要な建物の数</param>
        public BuildBlackSmith(short count, building required, short requiredCount)
            : base(building.blacksmith, count)
        {
            Facts.Add(
                new building_type_count_total(required, relop.ge, requiredCount)
                );
        }
    }
}