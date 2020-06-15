namespace Du.SolidWorks.Extension
{

    public static class EnumObjExtension
    {
        public static int SWToInt(this object obj)
        {
            return (int)obj;
        }

        public static T CastObj<T>(this object obj)
        {
            return (T)obj;
        }
    }
}
