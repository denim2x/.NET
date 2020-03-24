using System;

namespace Library {
  public static class StringExtras {
    public static string substr(this string source, int start, long length) {

      return source?.Substring(start, (int)length);
    }

    public static string substr(this string source, int start) {
      return source?.Substring(start);
    }

    public static string slice(this string source, int start, int end) {
      if (start < 0) {
        start = Math.Max(0, start + source.Length);
      }
      if (end < 0) {
        end = Math.Max(0, end + source.Length);
      }
      return source.substr(start, start + end);
    }

    public static string slice(this string source, int start) {
      if (start < 0) {
        start = Math.Max(0, start + source.Length);
      }
      return source.substr(start);
    }

    public static string random(int length = 8) => Guid.NewGuid().ToString().Replace("-", "").Substring(0, length);
  }
}
