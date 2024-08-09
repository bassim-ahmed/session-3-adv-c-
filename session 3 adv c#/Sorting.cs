using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_adv_c_
{
    public delegate bool ConditionFunDelegate<T>(T A,T B);
    internal class Sorting
    {
        #region Non geners
        //public static void BubbleSort(int[] Arr, ConditionFunDelegate Refrence)
        //{
        //    if (Arr is not null) {

        //        for (int i = 0; i < Arr.Length; i++) {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {

        //                if (Refrence.Invoke(Arr[j], Arr[j + 1]))
        //                {

        //                    Sawp(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }




               
        //    } }
        #endregion
        #region genersis
        public static void BubbleSort<T>(T[] Arr, ConditionFunDelegate<T> Refrence)
        {
            if (Arr is not null)
            {

                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {

                        if (Refrence.Invoke(Arr[j], Arr[j + 1]))
                        {

                            Sawp(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }





            }
        }
        #endregion


        public static void Sawp<T>(ref T x, ref T y)
        {
            T temp = x; x = y; y = temp;

        }



    }

    public class SortingFunction
    {
        public static bool SortAscending(string L, string R) { return L.Length > R.Length; }

        public static bool SortDscending(string L, string R) { return L.Length< R.Length; }
        public static bool CompareG(int L, int R) { return L > R; }

        public static bool Comparel(int L, int R) { return L < R; }
    }
}
    

