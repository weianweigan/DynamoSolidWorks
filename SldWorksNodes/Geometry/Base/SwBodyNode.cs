using Autodesk.DesignScript.Runtime;
using Microsoft.VisualBasic;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    public class SwBodyNode : SwNodeModel<IBody2>, IDisposable,ITempBody
    {
        protected Color _color = Colors.Yellow;
        #region Action

        public void SetMaterialProperty(MaterialProperty materialProperty)
        {
            if (materialProperty == null)
                return;

            SwObject.MaterialPropertyValues = materialProperty.ToArray();
        }

        /// <summary>
        /// Save body file to feature
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        public Feature.Feature SaveToFeature(string featureName)
        {
            if (SwObject == null)
                throw new ArgumentException("No body to save");

            var doc = SwContextUtil.GetCurrentPartDocContext();

            var oldFeat = doc.FindFeat(featureName);
            if (oldFeat != null)
            {
                oldFeat.Select2(false, 0);
                doc.DeleteSelection(false);
            }

            var feat = ((IPartDoc)doc).CreateFeatureFromBody3(SwObject, false, (int)swCreateFeatureBodyOpts_e.swCreateFeatureBodySimplify) as IFeature;

            if (feat == null)
                throw new NullReferenceException("Save Fail");

            feat.Name = featureName;
            return new Feature.Feature(feat);
        }

        #endregion

        #region Methods
        private void UpdateColor()
        {
            if (SwObject == null)
                return;

        }

        /// <summary>
        /// Clear Body
        /// </summary>
        public void Dispose()
        {
            ClearBody();
        }

        [IsVisibleInDynamoLibrary(false)]
        public void DisplayBody()
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            if (SwObject == null || doc == null)
                return;

            if (!SwObject.IsTemporaryBody())
                return;

            doc.WithNoRefresh(() =>
            {
                SwObject.Display3(
                    doc,
                    Information.RGB(_color.R, _color.G, _color.B),
                    (int)swTempBodySelectOptions_e.swTempBodySelectable);
                SetTransparency(0.9);
            });
        }

        [IsVisibleInDynamoLibrary(false)]
        public void ClearBody()
        {
            try
            {
                if (SwObject == null)
                    return;

                var doc = SldContextManager.Sw.IActiveDoc2;

                if (doc == null)
                    return;

                doc.DeleteBody(SwObject);
                SwObject = null;
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 设置透明度
        /// </summary>
        /// <param name="body">实体</param>
        /// <param name="value">透明度的值 在 0-1 之间</param>
        [IsVisibleInDynamoLibrary(false)]        
        public void SetTransparency(double value)
        {
            if (SwObject is null)
            {
                throw new ArgumentNullException(nameof(SwObject));
            }

            if (value < 0 || value > 1)
            {
                throw new ArgumentOutOfRangeException($"{value} 不满足要求，值应该在0到1之间");
            }
            var matValue = SwObject.MaterialPropertyValues2 as double[];
            if (matValue == null)
            {
                matValue = new double[9];
            }
            if (matValue != null)
            {
                matValue[7] = value;
            }
            SwObject.MaterialPropertyValues2 = matValue;
        }

        #endregion
    }
}
