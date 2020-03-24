using Library;
using Library.PrimeSieve;
using System;
using System.Collections.Generic;
using System.Threading;

namespace L1_Threads {
  abstract class AbstractSieveRunner : Runner<int, int>, IComplete {
    protected readonly Thread _thread;

    public override string name => _thread.Name;

    protected AbstractSieveRunner(string name = null) {
      _thread = new Thread(proc) {
        Name = $"{name ?? StringExtras.random()}"
      };
    }

    public void execute(int initial) {
      _thread.Start(initial);
    }

    public bool complete() {
      if (_thread.ThreadState == ThreadState.Stopped)
        return false;

      if (_thread.ThreadState == ThreadState.Unstarted)
        return false;

      _thread.Join();
      return true;
    }

    protected abstract void proc(object arg);
  }

  class SieveRunner<TSieve> : AbstractSieveRunner where TSieve : PrimeSieve, new() {
    protected readonly TSieve _sieve;

    public SieveRunner(string name = null): base(name) {
      _sieve = new TSieve();
    }

    protected override void proc(object arg) {
      if (arg is int limit) {
        _begun(now, limit);
        int result = 0;
        foreach (var p in _sieve.findPrimes(limit)) {
          _waiting(now);
          result = p;
        }
        _done(now, result);
      }
    }

    static DateTime now {
      get => DateTime.Now;
    }
  }
}
