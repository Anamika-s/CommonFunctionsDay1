namespace CommonFunctions
{
    public static class NumericFunctions
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static bool IsEven(int x)
        {
            //if (x % 2 == 2) return true;
            //else 
            //    return false;
            //?:
            return x%2==0?true : false;
        }

    }
}