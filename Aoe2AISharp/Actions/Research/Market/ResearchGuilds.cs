using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 組合を研究します。
    /// </summary>
    public class ResearchGuilds :Research
    {
        /// <summary>
        /// 組合を研究します。
        /// </summary>
        public ResearchGuilds() : base(ri.guilds)
        {
        }
    }
}