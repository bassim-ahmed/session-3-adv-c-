namespace session_3_adv_c_
{
    internal class Program
    {
        public delegate int StringDelegate(string s);
        //public delegate bool ConditionalFun(int x);
        //public delegate bool ConditionalFunV2(string S);
        public delegate bool ConditionalFun<T>(T x);
      


        //public static List<int> FindNumbers(List<int> list, ConditionalFun Reference)
        // {
        //     List<int> result = new List<int>();
        //     if (list != null)
        //     {
        //         for (int i = 0; i < list.Count; i++) {

        //             if (Reference.Invoke(list[i]))
        //             {
        //                 result.Add(list[i]);
        //             }
        //         }
        //     }
        //     return result;
        // }


        public static List<T> FindEle<T>(List<T> list, ConditionalFun<T> Reference)
        {
            List<T> result = new List<T>();
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {

                    if (Reference.Invoke(list[i]))
                    {
                        result.Add(list[i]);
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            #region Delegate ex1
            //StringDelegate x = StringFunction.GetCountOfUpperCaseChar;
            //x+= StringFunction.GetCountOfLowerCaseChar;


            ////int Result = x.Invoke("Hello wORLD");
            //int Result = x("Hello woRLD");
            //Console.WriteLine(Result);
            #endregion
            #region ex2
            //int[] numbers = { 6, 3, 6, 9, 2, 5 };
            ////Sorting.BubbleSort(numbers);

            //ConditionFunDelegate X= SortingFunction.Comparel;

            //Sorting.BubbleSort(numbers, X);
            //foreach (int i in numbers) {
            //    Console.WriteLine(i);
            //}
            #endregion
            #region ex 2 [genersis]
            //string[] Names= { "bassim","ahmed","kamal"};

            //Sorting.BubbleSort(Names, SortingFunction.SortDscending);
            //foreach (string s in Names)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion
            #region ex 3
            //List<int> list=Enumerable.Range(0, 100).ToList();
            //List<int> Divisible = FindNumbers(list, ConditionalFunction.CheckEven);
            //foreach (int x in Divisible)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region ex 3 with genercs
            //List<string> list = new List<string> { "bassim","ahmed","kamal","ali"};
            //List<string> Result = FindEle(list, ConditionalFunction.CheckLenghthLess3);
            //foreach (string s in Result)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion



        }
    }
    class StringFunction
    {

        public static int GetCountOfUpperCaseChar(String Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsUpper(Word[i]))
                        count++;
                }

            }
            return count;


        }
        public static int GetCountOfLowerCaseChar(String Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsLower(Word[i]))
                        count++;
                }

            }
            return count;


        }
    }

    class ConditionalFunction
    {
        public static bool CheckOdd(int x) { return x % 2 == 0; }
        public static bool CheckEven(int x) { return x % 2 == 1; }
        public static bool  CheckLenghthGtr3(string s) {  return s.Length >3; }
        public static bool CheckLenghthLess3 (string s) { return s.Length < 3; }


    }
}
