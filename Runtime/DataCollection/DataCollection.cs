using System;
using System.Collections.Generic;
using UnityEngine;

namespace Holypastry.Bakery
{
    public class DataCollection<T> where T : ScriptableObject
    {
        public List<T> Data = new();

        public DataCollection(string path) =>
            Data = new(Resources.LoadAll<T>(path));

        public int Count => Data.Count;

        public bool Exists(Predicate<T> predicate)
        => Data.Exists(predicate);


        public T Find(Predicate<T> predicate)
        => Data.Find(predicate);


        public List<T> FindAll(Predicate<T> predicate)
        => Data.FindAll(predicate);


        public void ForEach(Action<T> predicate)
        => Data.ForEach(predicate);

        public void Remove(Predicate<T> predicate)
        {
            var item = Data.Find(predicate);
            if (item != null)
                Data.Remove(item);
        }

        public void RemoveAll(Predicate<T> predicate)
        {
            Data.RemoveAll(predicate);
        }
        public T GetFromName(string name)
        => Data.Find(t => t.name == name);
    }

}
