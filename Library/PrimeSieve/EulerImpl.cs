using System;
using System.Collections.Generic;
using System.Text;

namespace Library.PrimeSieve {
  public class EulerImpl : PrimeSieve {
    public override IEnumerable<int> findPrimes(int limit) {
      if (limit < 2)
        yield break;

      // Make an array indicating whether numbers are prime.
      var primes = new HashSet<int> { 2 };
      for (int p = 3; p <= limit; p += 2) {
        primes.Add(p);
      }

      // Cross out multiples of odd primes.
      for (int p = 3; p <= limit; p += 2) {
        // See if i is prime.
        if (primes.Contains(p)) {
          // Knock out multiples of p.
          int max_q = limit / p;
          if (max_q % 2 == 0) {
            max_q--;    // Make it odd.
          }

          for (int q = max_q; q >= p; q -= 2) {
            // Only use q if it is prime.
            if (primes.Contains(q)) {
              primes.Remove(p * q);
            }
          }
        }
      }

      foreach (var p in primes) {
        yield return p;
      }
    }
  }
}
