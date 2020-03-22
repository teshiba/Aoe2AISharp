using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 輪作を研究します。
    /// </summary>
    public class ResearchCropRotation : Research
    {
        /// <summary>
        /// 輪作を研究します。
        /// 
        /// </summary>
        public ResearchCropRotation() : base(ri.crop_rotation)
        {
        }
    }
}