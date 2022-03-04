using System.Linq;
using SldWorksNodes.SwException;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Geometry
{
    public static class BodyBoolOperation
    {
        public static Body Add(Body body1,Body body2)
        {
            return BoolOperation(body1, body2,swBodyOperationType_e.SWBODYADD);
        }

        public static Body Cut(Body body1, Body body2)
        {
            return BoolOperation(body1, body2, swBodyOperationType_e.SWBODYCUT);
        }

        public static Body Intersect(Body body1, Body body2)
        {
            return BoolOperation(body1, body2, swBodyOperationType_e.SWBODYINTERSECT);
        }

        private static Body BoolOperation(Body body1, Body body2, swBodyOperationType_e operationType)
        {
            var bodies = body1.SwObject.Operations2((int)operationType, body2.SwObject, out var errorCode) as object[];

            var error = (swBodyOperationError_e)errorCode;
            if (error != swBodyOperationError_e.swBodyOperationNoError)
                throw new BodyOperationErrorException(error);

            var body = bodies?.FirstOrDefault() as IBody2;

            return new Body(body);
        }

    }
}
