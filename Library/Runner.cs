using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
  public abstract class Runner<TInitial, TFinal> {

    public event Action<DateTime, TInitial> begun;
    public event Action<DateTime> waiting;
    public event Action<DateTime, TFinal> done;

    public abstract string name { get; }

    protected void _begun(DateTime time, TInitial initial) {
      begun?.Invoke(time, initial);
    }

    protected void _waiting(DateTime time) {
      waiting?.Invoke(time);
    }

    protected void _done(DateTime time, TFinal final) {
      done?.Invoke(time, final);
    }
  }
}
