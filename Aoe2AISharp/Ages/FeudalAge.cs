using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Framework.EachAgesCommandCollection;

namespace Aoe2AISharp
{
    internal class FeudalAge : PerFile
    {
        protected override CommandGroupCollection GetCommandGroups()
        {
            ///////////////////////////////////////////////////////////////////
            var feudalAgeIncludeResearching = new EachAgesCommandCollection(GroupType.FeudalAge,
                "領主の時代（城主進化中も含む）に適用するルール") {
                new InitFeudalAge(),                    //領主の時代の初期設定
                new BuildArcheryRange(3),               //射手育成所を2軒まで建設
                new BuildMill(2),                       //粉ひき所を建設
                new ResignTimeout("00:50:00"),          //指定の時間経過したら降参
                new FeudalAgeGathererPercentages(),     //領主の時代の資源収集割合
                new BuildMill(),                        //粉引き所
                new BuildBarracks(2),                   //戦士育成所2軒目の建設
            };

            ///////////////////////////////////////////////////////////////////
            var feudalAgeOnly = new EachAgesCommandCollection(
                                        GroupType.FeudalAge, ResearchState.Finished,
                "領主の時代にのみ適用するルール") {
                new TrainVillager(100, age.feudal_age),         //進化条件を満たすまで町の人の生産
                new TrainPerUnitPct(unit.spearman_line ,15,
                                      unit.skirmisher_line, 20),   //槍兵の生産
                new TrainArcherLine(15),        //射手生産
                new TrainSpearmanLine(10),      //守備用に槍兵を生産
                new TrainSkirmisher(5),         //散兵の生産
            };

            ///////////////////////////////////////////////////////////////////
            var internalAffairsInFeudalAge = new CommandCollection("領主の時代の内政") {
                new BuildBlackSmith(1, building.archery_range, 2),  //射手育成所建設後に鉄工所を建設する
                new BuildMarket(1), //市場の建設
            };

            ///////////////////////////////////////////////////////////////////
            var militaryInFeudalAge = new CommandCollection("領主の時代の軍事") {
            };

            ///////////////////////////////////////////////////////////////////
            var endOfFeudalAge = new CommandCollection("領主の時代中終盤") {
                new ResearchCastleAge(),                    //城主の時代に進化
                new BuildMiningCamp(resource_type.stone),   //石の採掘所を作成
            };

            ///////////////////////////////////////////////////////////////////
            var ResearchingCastleAge = new EachAgesCommandCollection(
                                        GroupType.FeudalAgeOrLater, "領主の時代以降") {
                new BuildFarm(),        //畑の建設
                new BuildMiningCamp(),  //距離が空いたら採掘所を作成

            };

            ///////////////////////////////////////////////////////////////////
            var toCastleAge = new EachAgesCommandCollection(GroupType.FeudalAge,
                                                ResearchState.Researching,
                "城主の時代進化中にのみ適用するルール") {
                new BuildStable(2),         //騎兵育成所の建設
                new ResearchGoldMining(),   //金の採掘の研究
                new BuildMiningCamp(3),     //採掘所を3軒建設

            };

            return new CommandGroupCollection() {
                feudalAgeIncludeResearching,
                feudalAgeOnly,
                internalAffairsInFeudalAge,
                militaryInFeudalAge,
                endOfFeudalAge,
                ResearchingCastleAge,
                toCastleAge
            };
        }
    }
}