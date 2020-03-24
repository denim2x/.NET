using System;

namespace Library {
  public static class Extras {
    public static uint normalize(this int value, uint length) {
      if (value >= length)
        return length;

      if (value < 0)
        return (uint)Math.Max(0, value + length);

      return (uint)value;
    }

    public static bool within(this float value, float min, float max) {
      return min <= value && value <= max;
    }

    public static bool within(this Enum value, Enum min, Enum max) {
      var number = Convert.ToInt32(value);
      return Convert.ToInt32(min) <= number && number <= Convert.ToInt32(max);      
    }
  }
}
