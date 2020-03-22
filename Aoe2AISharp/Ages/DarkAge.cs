using LibAoe2AISharp;
using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Framework.EachAgesCommandCollection;

namespace Aoe2AISharp
{
    internal class DarkAge : PerFile
    {
        protected override CommandGroupCollection GetCommandGroups()
        {
            ///////////////////////////////////////////////////////////////////
            var gameStarting = new CommandCollection("暗黒の時代基礎 ～資源の収集と探索～") {
                new BuildHouse(3),          //家の建設の繰り返し
                new InitCivilianActions(),  //町の人の動きの設定
                new InitMilitaryActions(),  //斥候の動きの設定
                new BuildLumberCamp(),      //距離が空いたら伐採所を作成
            };

            ///////////////////////////////////////////////////////////////////
            var rulesIndarkAgeOnly = new EachAgesCommandCollection(GroupType.DarkAge,
                "暗黒の時代のみに適用するルール") {
                new BuildMill(2),                   //粉ひき所を建設
                new BuildLumberCamp(2),             //伐採所を建設
                new ResearchLoom(7),                //機織りの研究
                new TrainVillager(24),              //町の人を指定人数まで生産
                new DarkAgeGathererPercentages(),   //資源収集割合の調整
                new ResignTimeout("00:30:00")       //指定の時間経過したら降参

            };

            ///////////////////////////////////////////////////////////////////
            var endOfDarkAge = new CommandCollection("暗黒の時代中終盤") {
                new BuildFarm(4, 6),                        //畑の建設
                new ResearchFeudalAge(24),                  //領主への進化
                new BuildMiningCamp(resource_type.gold),    //採掘所を作成
            };

            ///////////////////////////////////////////////////////////////////
            var ToFeudalAge = new EachAgesCommandCollection(GroupType.DarkAge, ResearchState.Researching,
                "暗黒から領主に進化中") {
                new SetGathererRate(24, 5, 17, 2, 0),   //24人進化の場合の割合
                new BuildBarracks(1),                   //戦士育成所1軒目の建設
                new BuildFarm(6),                       //畑
                new BuildMill(3),                       //粉ひき所を増設
            };

            ///////////////////////////////////////////////////////////////////
            var PrioritizedResearchCollections = new CommandCollection("優先順位付きの研究") {
                new PrioritizedResearchItems(
                    //領主の時代
                    new ResearchDoubleBitAxe(),     //両刃斧
                    new ResearchHorseCollar(),      //引き具
                    new ResearchWheelBarrow(29),    //手押し車
                    //城主の時代
                    new ResearchBowSaw(),           //のこぎり
                    new ResearchHeavyPlow(),        //馬鍬
                    new ResearchHandCart()          //荷車
                ),
                new PrioritizedResearchItems(
                    //領主の時代
                    new ResearchFletching(5),       //矢羽根
                    new ResearchPaddedArcherArmor() //射手用胸当て
                ),
                new PrioritizedResearchItems(
                    new ResearchForging(),          //鍛造
                    new ResearchIronCasting()       //鋳造
                ),
                new PrioritizedResearchItems(
                    new ResearchBloodlines(),       //血統
                    new ResearchScaleBarding(),     //騎兵用うろこの鎧
                    new ResearchChainBarding(),     //騎兵用鎖かたびら
                    new ResearchHusbandry()         //繁殖の研究
                )
            };

            ///////////////////////////////////////////////////////////////////
            return new CommandGroupCollection() {
                rulesIndarkAgeOnly,
                gameStarting,
                endOfDarkAge,
                ToFeudalAge,
                PrioritizedResearchCollections
            };
        }
    }
}