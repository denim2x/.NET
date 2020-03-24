using System;
using System.Collections;
using System.Collections.Generic;

namespace Library {
  public class Concurrent<T> : ICollection<T> {
    protected readonly ICollection<T> _data;
    protected readonly object _lock = new { };

    public Concurrent(ICollection<T> source) {
      _data = source;
    }

    public int Count {
      get {
        lock (_lock) {
          return _data.Count;
        }
      }
    }

    public bool IsReadOnly => _data.IsReadOnly;

    public void Add(T item) {
      lock (_lock) {
        _data.Add(item);
      }
    }

    public void Clear() {
      lock (_lock) {
        _data.Clear();
      }
    }

    public bool Contains(T item) {
      lock (_lock) {
        return _data.Contains(item);
      }
    }

    public void CopyTo(T[] array, int arrayIndex) {
      lock (_lock) {
        _data.CopyTo(array, arrayIndex);
      }
    }

    public IEnumerator<T> GetEnumerator() {
      lock (_lock) {
        return _data.GetEnumerator();
      }
    }

    public bool Remove(T item) {
      lock (_lock) {
        return _data.Remove(item);
      }
    }

    public void ForEach(Action<T> action) {
      foreach (var item in this) {
        action(item);
      }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public static Concurrent<T> From(ICollection<T> source) => new Concurrent<T>(source);

    public static Concurrent<T> List() => From(new List<T>());
  }
}
