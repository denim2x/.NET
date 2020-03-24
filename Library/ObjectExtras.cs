using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library {
  public static class ObjectExtras {
    public static int size<A, B>(this (A, B) tuple) {
      return 2;
    }
    public static int size<A, B, C>(this (A, B, C) tuple) {
      return 3;
    }

    public static IEnumerable<T> iterate<T>(this (T, T) tuple) {
      yield return tuple.Item1;
      yield return tuple.Item2;
    }

    public static IEnumerable<T> iterate<T>(this (T, T, T) tuple) {
      yield return tuple.Item1;
      yield return tuple.Item2;
      yield return tuple.Item3;
    }
    
    public static bool nonNull<T>(this T instance, out T result) where T : class {
      if (instance != null) {
        result = instance;
        return true;
      }

      result = null;
      return false;
    }

    public static bool complete(this IEnumerable<Task> tasks) {
      var ret = true;
      foreach (var task in tasks) {
        try {
          task.Wait();
        } catch {
          ret = false;
        }
      }
      return ret;
    }

    public static bool complete(this IComplete[] runners) {
      var complete = false;
      foreach (var runner in runners) {
        complete = runner.complete() || complete;
      }
      return complete;
    }
    
    public static bool complete<T>(this (T, T) runners) where T : IComplete {
      var complete = false;
      foreach (var runner in runners.iterate()) {
        complete = runner.complete() || complete;
      }
      return complete;
    }

    public static bool sameAs(this object a, object b) {
      return ReferenceEquals(a, b);
    }
  }
}
