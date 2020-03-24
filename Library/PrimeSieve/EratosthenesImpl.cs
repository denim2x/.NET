using System;
using System.Collections.Generic;
using System.Text;

namespace Library.PrimeSieve {
  public class EratosthenesImpl : PrimeSieve {
    public override IEnumerable<int> findPrimes(int limit) {
      if (limit < 2)
        yield break;

      var marked = new HashSet<int>();

      for (int p = 2; p * p <= limit; p++) {
        if (!marked.Contains(p)) {
          for (int i = p * p; i <= limit; i += p) {
            marked.Add(i);
          }
        }
      }

      yield return 2;
      for (int i = 3; i <= limit; i+=2) {
        if (!marked.Contains(i)) {
          yield return i;
        }
      }
    }
  }
}
