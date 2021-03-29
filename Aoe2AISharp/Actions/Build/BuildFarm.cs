using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// Build farm.
    /// </summary>
    public class BuildFarm : Build
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFarm"/> class.
        /// </summary>
        public BuildFarm()
            : base(building.farm)
        {
            // 射手育成所が２つないときは射手育成所を立てる木を残しておく
            var noArchery_range = new Conditions(
                   new building_type_count_total(building.archery_range, relop.lt, 2)
                 & new ResourceAmount(building.archery_range, building.house, building.farm)
            );

            // 射手育成所が２つ以上のときは鉄工所を立てる木を残しておく
            var twoArchery_range = new Conditions(
                new building_type_count_total(building.archery_range, relop.ge, 2)
                & (// 鉄工所があれば木の条件は要らない
                     new building_type_count_total(building.blacksmith, relop.ge, 1)
                   | new ResourceAmount(building.blacksmith, building.house, building.farm)
                  )
            );

            Facts.Add(
                new idle_farm_count(relop.le, 2),
                new ResourceAmount(building.farm, building.house),
                noArchery_range | twoArchery_range);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFarm"/> class.
        /// </summary>
        /// <param name="count">食料が少なくなりそうなときに立てる最大数.</param>
        public BuildFarm(int count)
            : base(building.farm, count)
        {

            Comment += ":未使用の畑2以下";
            Facts.Add(
                new idle_farm_count(relop.le, 2),
                new ResourceAmount(building.farm, building.house),
                new game_time(relop.ge, 20)
            );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFarm"/> class.
        /// </summary>
        /// <param name="countMin">最低限建てる数.</param>
        /// <param name="count">食料が少なくなりそうなときに立てる最大数.</param>
        public BuildFarm(int countMin, int count)
            : this(count)
        {
            Comment += $"：{countMin}～{count}枚畑を張る";

            Facts.Add(
                 (// 通常は最低枚数張る
                      new building_type_count_total(building.farm, relop.lt, countMin)
                  |
                   (// 羊と苺が遠い場合は多めに張る
                      new sheep_and_forage_too_far()
                    & new building_type_count_total(building.farm, relop.lt, count)))
                & new ResourceAmount(building.lumber_camp, building.farm, building.house));
        }
    }

}