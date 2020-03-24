using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Library.PrimeSieve;

namespace L1_TAP {
  abstract class AbstractSieveRunner : Runner<int, int>, IComplete {
    private readonly string _name;
    protected Task _task;

    public override string name => _name;

    protected AbstractSieveRunner(string name = null) {
      _name = $"{name ?? StringExtras.random()}";
    }

    public void execute(int initial) {
      _task = Task.Run(() => proc(initial));
    }

    public bool complete() {
      if (_task.Status == TaskStatus.Running) {
        _task.Wait();
        return true;
      }

      if (_task.Status == TaskStatus.WaitingForActivation) {
        _task.Wait();
        return true;
      }

      return false;
    }

    protected abstract void proc(int limit);
  }

  class SieveRunner<TSieve> : AbstractSieveRunner where TSieve : PrimeSieve, new() {
    protected readonly TSieve _sieve;

    public SieveRunner(string name = null) : base(name) {
      _sieve = new TSieve();
    }

    protected override void proc(int limit) {
      _begun(now, limit);
      int result = 0;
      foreach (var p in _sieve.findPrimes(limit)) {
        _waiting(now);
        result = p;
      }
      _done(now, result);
    }

    static DateTime now {
      get => DateTime.Now;
    }
  }
}
