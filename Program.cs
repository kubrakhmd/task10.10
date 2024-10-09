namespace task_10._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 7,  2, 3, 4, 5, };
            //Console.WriteLine("minimum eded:");
            //Console.WriteLine(GetMin(nums));


            Console.WriteLine("Area");
            Area(6, 7);
            Area(6);
            Area(6, 7, 8);
            Area(4,1,2,3);
        }

        #region GetMin
        public static int GetMin(int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];

                }
            }
            return min;
        }
        #endregion
        public static int Area(int r)
        {
            int s = 0;
            int p = 3;
            s = p * r * r;

            Console.WriteLine(s);
            return s;

        }
        public static int Area(int a, int b)
        {
            int s = 0;
            s = a * b;
            Console.WriteLine(s);


            return s;


        }

        public static int Area(int a, int b, int c)
        {
            int s = 0;
            s = 2 * (a * b + a * c + b * c);
            Console.WriteLine(s);
            return s;
        }
        public static int Area(int r, int a, int b, int c)
        {

            int s = 0;
            int p = 0;
            p=(a+b+c)/2;
            s= p * r;
            Console.WriteLine(s);
            return s;



        }
    }
}

