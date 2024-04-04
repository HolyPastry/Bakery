
using System;
using System.Collections.Generic;



namespace Holypastry.Bakery
{
    public static class Extensions
    {

        public static T Random<T>(this IList<T> list)
        {
            if (list.Count == 0) return default;
            int index = UnityEngine.Random.Range(0, list.Count);
            return list[index];
        }


        public static List<T> DistinctRandom<T>(this IList<T> list, int numPick)
        {
            List<T> resultList = new();
            List<T> prunableList = new(list);

            while (resultList.Count < numPick)
            {
                if (prunableList.Count == 0)
                {
                    return resultList;
                }
                T t = prunableList.Random();
                prunableList.Remove(t);
                resultList.Add(t);
            }

            return resultList;
        }

        public static T FindRandom<T>(this List<T> list, Predicate<T> predicate)
        {
            List<T> filteredList = list.FindAll(predicate);

            if (filteredList.Count == 0)
                return default;
            return filteredList.Random();
        }

        public static void AddUnique<T>(this IList<T> list, T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
        }

        public static List<U> SelectSub<T, U>(this IList<T> list, Func<T, U> predicate)
        {
            List<U> listU = new();
            foreach (T item in list)
            {
                U u = predicate(item);
                listU.Add(u);
            }
            return listU;
        }

        public static bool PerfectMatch<T>(this List<T> list, List<T> otherList)
        {
            foreach (T item in list)
            {
                if (!otherList.Contains(item))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
