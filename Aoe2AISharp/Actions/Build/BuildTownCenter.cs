using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 町の中心を建設します。
    /// </summary>
    public class BuildTownCenter : Build
    {
        /// <summary>
        /// 町の中心を指定の数まで建設します。
        /// </summary>
        public BuildTownCenter(short count) 
                    : base(building.town_center, count)
        {
        }
    }
}