using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_3_advc_
{
    internal class part_2
    {
        #region Exists Method
        //Determines whether an element in the list satisfies a specified condition.
        //Returns true if any element matches the condition; otherwise, returns false.
        //public static bool Exists<T>(List<T> list, Predicate<T> match)
        //{
        //    foreach (var item in list)
        //    {
        //        if (match(item))
        //            return true;
        //    }
        //    return false;
        //}

        #endregion
        #region Find 
        //Returns the first element in the list that satisfies a specified condition.
        // Returns default(T) if no element matches the condition.
        //public static T Find<T>(List<T> list, Predicate<T> match)
        //{
        //    foreach (var item in list)
        //    {
        //        if (match(item))
        //            return item;
        //    }
        //    return default(T);
        //}

        #endregion
        #region FindAll Method
        //Returns a new list containing all elements that satisfy a specified condition.
        //public static List<T> FindAll<T>(List<T> list, Predicate<T> match)
        //{
        //    var result = new List<T>();
        //    foreach (var item in list)
        //    {
        //        if (match(item))
        //            result.Add(item);
        //    }
        //    return result;
        //}

        #endregion
        #region FindIndex
        //Returns the index of the first element that satisfies a specified condition.
        //Returns -1 if no element matches the condition.
        //public static int FindIndex<T>(List<T> list, Predicate<T> match)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (match(list[i]))
        //            return i;
        //    }
        //    return -1;
        //}

        #endregion
        #region FindLast 
        //  Returns the last element in the list that satisfies a specified condition.
        //Returns default(T) if no element matches the condition.
        //public static T FindLast<T>(List<T> list, Predicate<T> match)
        //{
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        if (match(list[i]))
        //            return list[i];
        //    }
        //    return default(T);
        //}

        #endregion
        #region FindLastIndex
        //Returns the index of the last element that satisfies a specified condition.
        //Returns -1 if no element matches the condition.
        //public static int FindLastIndex<T>(List<T> list, Predicate<T> match)
        //{
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        if (match(list[i]))
        //            return i;
        //    }
        //    return -1;
        //}

        #endregion
        #region ForEach 
        /*applies an action to each element in the list.*/
        //public static void ForEach<T>(List<T> list, Action<T> action)
        //{
        //    foreach (var item in list)
        //    {
        //        action(item);
        //    }
        //}


        #endregion
        #region TrueForAll 
        // Determines whether all elements in the list satisfy a specified condition.
        //Returns true if all elements match the condition; otherwise, returns false.
        //public static bool TrueForAll<T>(List<T> list, Predicate<T> match)
        //{
        //    foreach (var item in list)
        //    {
        //        if (!match(item))
        //            return false;
        //    }
        //    return true;
        //}

        #endregion
    }
}
