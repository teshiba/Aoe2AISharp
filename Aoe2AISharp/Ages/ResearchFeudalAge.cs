using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 領主の時代に進化します。
    /// </summary>
    public class ResearchFeudalAge : ResearchAge
    {
        /// <summary>
        /// 指定した人口になったら領主の時代に進化します。
        /// </summary>
        /// <param name="population">暗黒の時代で生産する町の人の人数</param>
        public ResearchFeudalAge(int population)
            : base(age.feudal_age, population)
        {
            Actions.Add(new set_strategic_number(sn.enable_boar_hunting, 1));
        }
    }
}