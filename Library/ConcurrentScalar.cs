using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
  public struct ScalarData<T, E> {
    public T data { get; internal set; }
    public E extra { get; internal set; }

    public ScalarData(T data, E extra) {
      this.data = data;
      this.extra = extra;
    }

    public static implicit operator ScalarData<T, E>((T, E) value) {
      var (data, extra) = value;
      return new ScalarData<T, E>(data, extra);
    }

    public static implicit operator T(ScalarData<T, E> scalar) {
      return scalar.data;
    }

    public void Deconstruct(out T data, out E extra) {
      data = this.data;
      extra = this.extra;
    }
  }

  public class ConcurrentScalar<T, E> {
    protected ScalarData<T, E> _scalar;
    protected readonly object _lock = new { };

    public event Action<ScalarData<T, E>, ScalarData<T, E>> updated;

    public T data {
      get {
        lock (_lock) {
          return _scalar.data;
        }
      }
    }

    public E extra {
      get {
        lock (_lock) {
          return _scalar.extra;
        }
      }

      set {
        lock (_lock) {
          _scalar.extra = value;
        }
      }
    }

    public E this[T data] {
      get => throw new InvalidOperationException("ConcurrentScalar instance shall not be indexed (during value access)");

      set {
        lock (_lock) {
          var prev = _scalar;
          _scalar.extra = value;
          if (!_scalar.data.sameAs(data)) {
            _scalar.data = data;
            updated?.Invoke(prev, _scalar);
          }
        }
      }
    }
  }
}
