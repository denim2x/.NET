using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Library.PrimeSieve {
  public abstract class PrimeSieve {
    public abstract IEnumerable<int> findPrimes(int limit);

    public int largestPrime(int limit) {
      return findPrimes(limit).Last();
    }
  }
}
