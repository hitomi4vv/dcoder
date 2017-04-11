using System;
using System.Linq;

public class Program {
  public static void Main() {
    var c = Console.ReadLine().Split().Select(int.Parse).Select(n => Math.Pow(n, 2)).ToArray();
    Console.WriteLine(Math.Sqrt(c[0] + c[1]) < Math.Sqrt(c[2] + c[3])? "A":"B");
  }
}
