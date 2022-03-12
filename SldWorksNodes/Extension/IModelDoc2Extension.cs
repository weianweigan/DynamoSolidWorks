using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SolidWorks.Interop.sldworks
{
    [IsVisibleInDynamoLibrary(false)]
    public static class IModelDoc2Extension
    {
        public static bool IsPartDocContext(this IModelDoc2 doc, out IModelDoc2 partDoc)
        {
            partDoc = doc;
            if (doc == null)
                return false;
            var type = doc.GetType();
            if (type == (int)swDocumentTypes_e.swDocPART)
                return true;
            if (type == (int)swDocumentTypes_e.swDocASSEMBLY)
            {
                var assDoc = (IAssemblyDoc)doc;
                partDoc = assDoc.GetEditTarget() as IModelDoc2;
                if (partDoc != null && partDoc.GetType() == (int)swDocumentTypes_e.swDocPART)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        #region Features

        /// <summary>
        /// 获取世界坐标系 
        /// <list type="number">前视基准面 XYPlane</list>
        /// <list type="number">上视基准面 XZPlane</list>
        /// <list type="number">右视基准面 YZPlane</list>
        /// </summary>
        /// <returns>三个长度分别代表三个初始基准面</returns>
        public static IFeature[] GetWorldRefPlaneFeat(this IModelDoc2 doc)
        {
            if (doc is null)
            {
                throw new ArgumentNullException(nameof(doc));
            }

            var feats = new IFeature[3];
            int i = 0;
            foreach (var feat in GetTopFeatures(doc))
            {
                if (i == 3)
                {
                    break;
                }
                if (feat.GetTypeName() == "RefPlane")
                {
                    feats[i++] = feat;
                }
            }
            if (i != 3)
            {
                throw new InvalidOperationException($"当前文档:{doc.GetTitle()} 缺少世界基准面");
            }
            return feats;
        }

        /// <summary>
        /// 获取第一层的特征
        /// </summary>
        public static IEnumerable<IFeature> GetTopFeatures(this IModelDoc2 doc)
        {
            if (doc is null)
            {
                throw new ArgumentNullException(nameof(doc));
            }

            var feat = doc.FirstFeature() as IFeature;
            while (feat != null)
            {
                yield return feat;
                feat = feat.GetNextFeature() as IFeature;
            }
        }

        public static IFeature FindFeat(this IModelDoc2 doc, string name)
        {
            return GetAllFeats(doc).FirstOrDefault(p => p.Name == name);
        }

        public static IEnumerable<IFeature> GetAllFeats(this IModelDoc2 doc)
        {
            var topFeats = doc.GetTopFeatures();

            foreach (var topFeat in topFeats)
            {
                yield return topFeat;

                foreach (var subTopFeat in topFeat.GetAllSubFeatures())
                {
                    yield return subTopFeat;
                }
            }

            yield break;
        }

        #endregion

        #region Sketch

        /// <summary>
        /// 在草图编辑模式下执行
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="feature"></param>
        /// <param name="action"></param>
        public static void WithEditSketch(this IModelDoc2 doc, IFeature feature, Action<ISketch> action)
        {
            if (doc is null)
            {
                throw new ArgumentNullException(nameof(doc));
            }

            if (feature is null)
            {
                throw new ArgumentNullException(nameof(feature));
            }

            if (feature.GetTypeName2() != "ProfileFeature")
            {
                throw new ArgumentException($"当前特征不是草图，无法编辑");
            }

            ISketch ske = null;
            try
            {
                feature.Select2(false, 0);
                doc.EditSketch();
                ske = doc.SketchManager.ActiveSketch;
                if (ske != null)
                {
                    action?.Invoke(ske);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (ske != null)
                {
                    doc.SketchManager.InsertSketch(true);
                }
            }
        }

        #endregion

        #region Settings

        /// <summary>执行代码时不刷新图像区域 和 特征树</summary>
        public static void WithNoRefresh(this IModelDoc2 doc, Action action)
        {
            if (doc is null)
            {
                throw new ArgumentNullException(nameof(doc));
            }

            IModelView swView = null;
            try
            {
                swView = doc.ActiveView as IModelView;
                swView.SuppressWaitCursorDuringRedraw = true;
                swView.EnableGraphicsUpdate = false;
                doc.FeatureManager.EnableFeatureTreeWindow = false;
                doc.FeatureManager.EnableFeatureTree = false;


                action?.Invoke();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                doc.FeatureManager.EnableFeatureTreeWindow = true;
                doc.FeatureManager.EnableFeatureTree = true;

                swView.EnableGraphicsUpdate = true;
                swView.SuppressWaitCursorDuringRedraw = false;
            }
        }

        /// <summary>执行代码时不刷新图像区域 和 特征树</summary>
        public static void WithNoRefreshFeatTree(this IModelDoc2 doc, Action action)
        {
            if (doc is null)
            {
                throw new ArgumentNullException(nameof(doc));
            }

            IModelView swView = null;
            try
            {
                swView = doc.ActiveView as IModelView;
                doc.FeatureManager.EnableFeatureTreeWindow = false;
                doc.FeatureManager.EnableFeatureTree = false;

                action?.Invoke();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                doc.FeatureManager.EnableFeatureTreeWindow = true;
                doc.FeatureManager.EnableFeatureTree = true;

            }
        }

        /// <summary>
        /// 设置一个选项后执行动作,执行完后设置回系统默认值
        /// </summary>
        /// <param name="app">ISldwork interface</param>
        /// <param name="toggleSetting">需要设置的枚举值</param>
        /// <param name="value">值</param>
        /// <param name="action">执行的动作</param>
        public static void WithToggleState(this ISldWorks app, swUserPreferenceToggle_e toggleSetting, bool value, Action action)
        {
            bool state = false;
            try
            {
                state = app.GetUserPreferenceToggle((int)toggleSetting);
                app.SetUserPreferenceToggle((int)toggleSetting, value);
                action?.Invoke();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                app.SetUserPreferenceToggle((int)toggleSetting, state);
            }
        }

        /// <summary>
        /// 设置一个选项后执行动作,执行完后设置回系统默认值
        /// </summary>
        /// <param name="app">ISldwork interface</param>
        /// <param name="keyValuePairs">需要设置的枚举和值的对</param>
        /// <param name="value">值</param>
        /// <param name="action">执行的动作</param>
        public static void WithMutiToggleState(this ISldWorks app, Action action, params KeyValuePair<swUserPreferenceToggle_e, bool>[] keyValuePairs)
        {
            bool[] states = new bool[keyValuePairs.Length];
            try
            {
                for (int i = 0; i < keyValuePairs.Length; i++)
                {
                    states[i] = app.GetUserPreferenceToggle((int)keyValuePairs[i].Key);
                    app.SetUserPreferenceToggle((int)keyValuePairs[i].Key, keyValuePairs[i].Value);
                }
                action?.Invoke();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                for (int i = 0; i < keyValuePairs.Length; i++)
                {
                    app.SetUserPreferenceToggle((int)keyValuePairs[i].Key, states[i]);
                }
            }
        }

        /// <summary>
        /// 使用SolidWorks Api做操作
        /// </summary>
        /// <param name="app"><see cref="ISldWorks"/></param>
        /// <param name="action">做的动作</param>
        /// <param name="noRefresh">是否更新图形区</param>
        /// <param name="actionName">撤销名称</param>
        /// <param name="ignoreUndo">此次操作不产生撤销操作</param>
        public static void WithApiDocState(this ISldWorks app, Action<IModelDoc2> action, bool noRefresh = true, string actionName = "", bool ignoreUndo = false)
        {
            var doc = app.ActiveDoc as ModelDoc2;
            if (doc == null)
            {
                throw new ArgumentNullException("No active doc");
            }
            try
            {

#if DEBUG

#else
                actionName = string.Empty;//发布模式不带撤销
#endif

                if (!string.IsNullOrEmpty(actionName))
                    doc.Extension.StartRecordingUndoObject();

                app.WithMutiToggleState(() =>
                {
                    if (noRefresh)
                        doc.WithNoRefresh(() =>
                        {
                            action?.Invoke(doc);
                        });
                    else
                        action?.Invoke(doc);

                }, new KeyValuePair<swUserPreferenceToggle_e, bool>(swUserPreferenceToggle_e.swSketchInference, false),
                new KeyValuePair<swUserPreferenceToggle_e, bool>(swUserPreferenceToggle_e.swInputDimValOnCreate, false
                ));
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (!string.IsNullOrEmpty(actionName))
                    doc.Extension.FinishRecordingUndoObject2(actionName, ignoreUndo);
            }
        }

        public static double CloestDistance<T1, T2>(this IModelDoc2 doc, T1 geoObj1, T2 geoObj2, out double[] p1, out double[] p2)
        {
            var value = doc.ClosestDistance(geoObj1, geoObj2, out var objP1, out var objP2);
            p1 = objP1 as double[];
            p2 = objP2 as double[];
            return value;
        }

        [Obsolete]
        public static IModelDoc2 OpenDocBackground(this ISldWorks app, string filePath)
        {
            var ext = Path.GetExtension(filePath).ToLower();

            try
            {
                DocumentVisible(ext, false);
                return null;// app.OpenDocEx(filePath);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DocumentVisible(ext, true);
            }

            void DocumentVisible(string extension, bool visible)
            {
                switch (extension)
                {
                    case ".sldprt":
                        app.DocumentVisible(visible, (int)swDocumentTypes_e.swDocPART);
                        break;
                    case ".sldasm":
                        app.DocumentVisible(visible, (int)swDocumentTypes_e.swDocASSEMBLY);
                        break;
                    case ".slddrw":
                        app.DocumentVisible(visible, (int)swDocumentTypes_e.swDocDRAWING);
                        break;
                    default:
                        throw new NotSupportedException($"格式错误，无法打开：{ext}");
                }
            }
        }
        #endregion

        #region Geometry
        /// <summary>
        /// 删除实体
        /// </summary>
        public static void DeleteBody(this IModelDoc2 swModel, ref IBody2 body)
        {
            if (body == null)
            {
                return;
            }

            if (body.IsTemporaryBody())
                body.Hide(swModel);
            else
                body.HideBody(true);

            body = null;
        }

        /// <summary>
        /// Delete Bofy
        /// </summary>
        public static void DeleteBody(this IComponent2 comp, ref IBody2 body)
        {
            if (body == null)
            {
                return;
            }

            if (body.IsTemporaryBody())
                body.Hide(comp);
            else
                body.HideBody(true);

            body = null;
        }
        #endregion

        #region Others

        /// <summary>
        /// 获取文档类型
        /// </summary>
        public static swDocumentTypes_e GetTypeEx(this IModelDoc2 doc2)
        {
            return (swDocumentTypes_e)doc2.GetType();
        }

        public static bool HasSaved(this IModelDoc2 doc)
        {
            var pathName = doc.GetPathName();

            //TODO 考虑虚拟零件

            return File.Exists(pathName);
        }

        #endregion

    }

}
