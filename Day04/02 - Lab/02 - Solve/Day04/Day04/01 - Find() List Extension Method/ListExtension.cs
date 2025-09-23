using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04._01___Find___List_Extension_Method
{
    internal static class ListExtension
    {
        public static List<string> MyFind(this List<string> strs, Predicate<string> predicate)
        {
            List<string> newList = new List<string>();
            foreach (var item in strs)
            {
                if (predicate.Invoke(item))
                    newList.Add(item);
            }
            return newList;
        }
    }
}
