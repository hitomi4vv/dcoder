using System;
using System.Linq;

public class Program {
  public static void Main() {
    Console.WriteLine(Enumerable.Range(1, int.Parse(Console.ReadLine())).Select(i => (int)i).ToArray().Sum());
  }
}
