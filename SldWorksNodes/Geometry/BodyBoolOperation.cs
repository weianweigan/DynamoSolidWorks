using System.Linq;
using SldWorksNodes.SwException;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.sldworks;
using SldWorksNodes.Util;

namespace SldWorksNodes.Geometry
{
    public static class BodyBoolOperation
    {
        public static SwBodyNode Add(SwBodyNode body1,SwBodyNode body2)
        {
            return BoolOperation(body1, body2,swBodyOperationType_e.SWBODYADD);
        }

        public static SwBodyNode Cut(SwBodyNode body1, SwBodyNode body2)
        {
            return BoolOperation(body1, body2, swBodyOperationType_e.SWBODYCUT);
        }

        public static SwBodyNode Intersect(SwBodyNode body1, SwBodyNode body2)
        {
            return BoolOperation(body1, body2, swBodyOperationType_e.SWBODYINTERSECT);
        }

        private static SwBodyNode BoolOperation(SwBodyNode body1, SwBodyNode body2, swBodyOperationType_e operationType)
        {
            if(body1?.SwObject == null || body2.SwObject == null)
                return null;

            body1.ClearBody(true);
            body2.ClearBody(true);

            var bodies = body1.SwObject.Operations2((int)operationType, body2.SwObject, out var errorCode) as object[];

            var error = (swBodyOperationError_e)errorCode;
            if (error != swBodyOperationError_e.swBodyOperationNoError)
                throw new BodyOperationErrorException(error);

            var body = bodies?.FirstOrDefault() as IBody2;

            if(body == null)
                return null;

            return new SwBodyNode(body);
        }

        public static bool CheckInterfences(SwBodyNode body1, SwBodyNode body2)
        {
            if (body1?.SwObject == null || body2.SwObject == null)
                return false;

            object faces = null;object faces2 = null;object bodies = null;
            return SldContextManager.Modeler.CheckInterference3(
                body1.SwObject,
                body2.SwObject,
                (int)swCheckInterferenceOption_e.swBodyInterference_OptionDefault,
                ref faces,
                ref faces2,
                ref bodies);
        }
    }
}
