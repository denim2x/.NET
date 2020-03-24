using System.Collections.Generic;

namespace Library {
  public class Queue<T> {
    protected readonly LinkedList<T> _data = new LinkedList<T>();

    protected readonly uint _max;

    public Queue(int max) {
      _max = (uint)max;
    }

    public Queue() {
      _max = uint.MaxValue;
    }

    public virtual uint max => _max;

    public virtual int size => _size;

    public bool empty => size == 0;

    public virtual bool push(T item) {
      var full = _trim();
      _data.AddLast(item);
      return full;
    }

    public T pop() {
      pop(out var item);
      return item;
    }

    public virtual bool pop(out T item) {
      if (empty) {
        item = default;
        return false;
      }

      item = _pop();
      return true;
    }

    public T peek() {
      peek(out var item);
      return item;
    }

    public virtual bool peek(out T item) {
      if (empty) {
        item = default;
        return false;
      }

      item = _data.First.Value;
      return true;
    }

    public virtual bool clear() {
      if (empty)
        return false;

      _data.Clear();
      return true;
    }

    public virtual bool trim() => _trim();

    protected bool _trim() {
      var full = _size >= _max;
      while (_size >= _max) {
        _pop();
      }

      return full;
    }

    protected int _size => _data.Count;

    protected T _pop() {
      var item = _data.First.Value;
      _data.RemoveFirst();
      return item;
    }
  }
}
