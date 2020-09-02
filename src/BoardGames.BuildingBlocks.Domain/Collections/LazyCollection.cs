using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BoardGames.BuildingBlocks.Domain.Collections
{
    public static class LazyCollection
    {
        public static LazyCollection<T> Create<T>(Func<IList<T>> getCollectionMethod)
        {
            return new LazyCollection<T>(getCollectionMethod);
        }
    }

    public class LazyCollection<T> : ICollection<T>
    {
        private Lazy<ICollection<T>> lazyCollection { get; }

        public LazyCollection(Func<ICollection<T>> getCollectionMethod)
        {
            lazyCollection = new Lazy<ICollection<T>>(getCollectionMethod);
        }

        public ICollection<T> Value => lazyCollection.Value;

        public bool IsValueCreated => lazyCollection.IsValueCreated;

        public int Count => Value.Count();

        public bool IsReadOnly => Value.IsReadOnly;

        public void Add(T item)
        {
            Value.Add(item);
        }

        public void Clear()
        {
            Value.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Contains(T item)
        {
            return Value.Contains(item); ;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Value.CopyTo(array, arrayIndex);
        }

        bool ICollection<T>.Remove(T item)
        {
            return Value.Remove(item);
        }
    }
}
