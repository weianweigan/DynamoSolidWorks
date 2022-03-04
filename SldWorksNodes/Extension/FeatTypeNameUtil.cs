using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.swconst;

namespace SolidWorks.Interop.sldworks
{
    [IsVisibleInDynamoLibrary(false)]
    public static class FeatTypeNameUtil
    {
        /// <summary>
        /// 基准面
        /// </summary>
        public const string RefPlane = nameof(RefPlane);

        /// <summary>
        /// 库特征
        /// </summary>
        public const string LibraryFeature = nameof(LibraryFeature);

        /// <summary>
        /// 原点
        /// </summary>
        public const string OriginProfileFeature = nameof(OriginProfileFeature);

        /// <summary>
        /// 基准轴
        /// </summary>
        public const string RefAxis = nameof(RefAxis);

        /// <summary>
        /// 宏特征
        /// </summary>
        public const string MacroFeature = nameof(MacroFeature);

        /// <summary>
        /// 草图特征
        /// </summary>
        public const string ProfileFeature = nameof(ProfileFeature);

        /// <summary>
        /// 凸台拉伸特征
        /// </summary>
        public const string Extrusion = nameof(Extrusion);

        /// <summary>
        /// 旋转切除特征
        /// </summary>
        public const string RevCut = nameof(RevCut);

        /// <summary>
        /// 数据包
        /// </summary>
        public const string Attribute = nameof(Attribute);

        /// <summary>
        /// 拉伸切除
        /// </summary>
        public const string ICE = nameof(ICE);

        /// <summary>
        /// 倒角
        /// </summary>
        public const string Chamfer = nameof(Chamfer);

        /// <summary>
        /// 装饰螺纹线特征
        /// </summary>
        public const string CosmeticThread = nameof(CosmeticThread);

        public static bool IsCavity(string typeName)
        {
            return typeName == RevCut;
        }

        /// <summary>
        /// 出零件工程图时是否要压缩此特征
        /// </summary>
        /// <returns></returns>
        public static bool NeedToSuppressedWhenDrawing(string typeName)
        {
            return typeName == ICE || typeName == Chamfer;
        }

        public static bool IsTopCavityFeatureTypeName(string typeName)
        {
            return typeName == MacroFeature || typeName == LibraryFeature;
        }

        public static bool IsEntity(int type)
        {
            return type == (int)swSelectType_e.swSelFACES ||
                type == (int)swSelectType_e.swSelEDGES;
        }
    }
}
