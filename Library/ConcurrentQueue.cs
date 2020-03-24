namespace Library {
  public class ConcurrentQueue<T> : Queue<T> {
    protected readonly object _lock = new { };

    public ConcurrentQueue(int max) : base(max) { }

    public override uint max {
      get {
        lock (_lock) {
          return _max;
        }
      }
    }

    public override int size {
      get {
        lock (_lock) {
          return _size;
        }
      }
    }

    public override bool push(T item) {
      lock (_lock) {
        return base.push(item);
      }
    }

    public override bool pop(out T item) {
      lock (_lock) {
        return base.pop(out item);
      }
    }

    public override bool peek(out T item) {
      lock (_lock) {
        return base.peek(out item);
      }
    }

    public override bool clear() {
      lock (_lock) {
        return base.clear();
      }
    }

    public override bool trim() {
      lock (_lock) {
        return _trim();
      }
    }
  }
}
