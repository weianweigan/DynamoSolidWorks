using Autodesk.DesignScript.Runtime;
using Dynamo.Controls;
using Dynamo.Graph.Nodes;
using Dynamo.Wpf;
using ProtoCore.AST.AssociativeAST;
using SldWorksNodes.Base;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace SldWorksNodes.Dimension
{
    public class Dimension : SwNodeModel<IDisplayDimension>
    {
        internal Dimension(IDisplayDimension displayDimension)
        {
            SwObject = displayDimension;
        }

        public string Name => SwObject?.GetNameForSelection();

        /// <summary>
        /// 通过PID获取尺寸对象
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        /// <exception cref="SwObjectLostException"></exception>
        public static Dimension ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IDisplayDimension;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Dimension(obj);
            else
                throw new SwObjectLostException(typeof(IDisplayDimension));
        }

        /// <summary>
        /// 通过尺寸名称选中尺寸
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Dimension ByName(string name)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();
            Select(doc,name);
            return CurrentSelection();
        }

        /// <summary>
        /// Set dimension value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void SetValue(double value)
        {
            AssertSwObject();
            var dim = SwObject.GetDimension() as IDimension;

            dim.Value = value;

            SwContextUtil.Rebuild();
        }

        public override string ToString()
        {
            return Name ?? base.ToString();
        }

        /// <summary>
        /// 选中尺寸，只支持在零件环境下
        /// </summary>
        /// <param name="displayDimension">需要被选中的尺寸</param>
        /// <param name="doc">当前尺寸属于的文档</param>
        /// <param name="append">是否添加到选择集合</param>
        /// <param name="mark">标记</param>
        /// <returns></returns>
        private static bool Select(IModelDoc2 doc,string name,bool append = false,int mark = 0)
        {
            return doc.Extension.SelectByID2(name, "DIMENSION", 0, 0, 0, append, mark, null, (int)swSelectOption_e.swSelectOptionDefault);
        }

        private static Dimension CurrentSelection()
        {
            var dim = SwContextUtil.GetCurrentSelectedObject() as IDisplayDimension;

            if (dim == null)
                throw new SelectionNotFoundException();

            return new Dimension(dim);
        }
    }
}
