using System;
using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SldWorksNodes.Sketch
{
    [IsVisibleInDynamoLibrary(false)]
    public static class SketchMgrExtension
    {
        /// <summary>
        /// 关闭显示求解 等 直接添加到草图数据库来提高速度
        /// </summary>
        public static void WithDbState(this ISketchManager skeMgr, Action action)
        {
            if (skeMgr is null)
            {
                throw new ArgumentNullException(nameof(skeMgr));
            }

            bool addToDB = skeMgr.AddToDB;
            bool autoSolve = skeMgr.AutoSolve;
            bool displaWhenAdded = skeMgr.DisplayWhenAdded;
            //bool autoInference = skeMgr.AutoInference;
            try
            {
                skeMgr.AddToDB = true;
                skeMgr.AutoSolve = false;
                skeMgr.DisplayWhenAdded = false;
                //skeMgr.AutoInference = false;

                action?.Invoke();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                skeMgr.AddToDB = addToDB;
                skeMgr.AutoSolve = autoSolve;
                skeMgr.DisplayWhenAdded = displaWhenAdded;
                //skeMgr.AutoInference = autoInference;
            }
        }

        /// <summary>
        /// 无参考而且不允许用户输入尺寸，直接添加到Db
        /// </summary>
        /// <param name="skeMgr"></param>
        /// <param name="app"></param>
        /// <param name="action"></param>
        public static void WithDbAndNoInferenceState(this ISketchManager skeMgr, ISldWorks app, Action action)
        {
            app.WithMutiToggleState(() =>
            {
                skeMgr.WithDbState(action);
            }, new KeyValuePair<swUserPreferenceToggle_e, bool>(swUserPreferenceToggle_e.swSketchInference, false),
                new KeyValuePair<swUserPreferenceToggle_e, bool>(swUserPreferenceToggle_e.swInputDimValOnCreate, false));
        }
    }
}
