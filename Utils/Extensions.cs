using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils {
  public static class Extensions {
    public static bool tryGet<T>(this IList<T> source, int index, out T value) {
      value = default;
      if (source == null)
        return false;

      if (source.Count <= index)
        return false;

      value = source[index];
      return true;
    }
    
    public static bool tryGet<T>(this T[] source, int index, out T value) {
      value = default;
      if (source == null)
        return false;

      if (source.Length <= index)
        return false;

      value = source[index];
      return true;
    }

    public static C addAll<C, T>(this C target, IEnumerable<T> source) where C : ICollection<T> {
      foreach (var item in source) {
        target.Add(item);
      }
      return target;
    }

    public static TEnum asEnum<TEnum>(this string value) where TEnum : struct {
      return (TEnum)Enum.Parse(typeof(TEnum), value);
    }

    public static IEnumerable<T> With<T>(this IEnumerable<T> source, params T[] items) {
      return source.Union(items);
    }
  }
}
