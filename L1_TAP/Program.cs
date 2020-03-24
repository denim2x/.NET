using Library;
using System;

namespace L1_TAP {
  using EratosthenesSieve = Library.PrimeSieve.EratosthenesImpl;
  using EulerSieve = Library.PrimeSieve.EulerImpl;

  class Program {
    static int Main(string[] args) {
      if (args.Length == 0) {
        Console.WriteLine("[FATAL] Missing required command-line argument: 'limit'");
        return 1;
      }

      if (!int.TryParse(args[0], out int limit)) {
        Console.WriteLine("[FATAL] Cannot parse '{0}' as integer", args[0]);
        return 2;
      }

      if (limit < 0) {
        Console.WriteLine("[FATAL] Expected positive value for argument '{0}', got: {1}", nameof(limit), limit);
        return 3;
      }

      var log = Concurrent<string>.List();

      var runners = (
        new SieveRunner<EulerSieve>("Euler"),
        new SieveRunner<EratosthenesSieve>("Eratosthenes")
      );

      var current = new ConcurrentScalar<string, DateTime>();
      current.updated += (prev, current) => {
        if (prev.data != default) {
          log.Add($"Iesire temporara fir: {prev.data}@{asTimestamp(current.extra)}");
        }
      };

      foreach (var runner in runners.iterate<AbstractSieveRunner>()) {
        runner.begun += (DateTime time, int limit) => {
          log.Add($"Startfir: {runner.name}@{asTimestamp(time)} Numar natural dat = {limit}");
        };
        runner.waiting += (DateTime time) => {
          current[runner.name] = time;
        };
        runner.done += (DateTime time, int result) => {
          log.Add($"End fir: {runner.name}@{asTimestamp(time)} Numar prim = {result}");
        };

        runner.execute(limit);
      }

      runners.complete<AbstractSieveRunner>();

      log.ForEach(Console.WriteLine);

      return 0;
    }

    static string asTimestamp(DateTime time) => time.ToString("hh:mm:ss.ffffff");
  }
}
