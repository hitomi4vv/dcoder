using System;
using System.Linq;

public class Program {
  public static void Main() {
    int[] arr = Enumerable.Range(1, int.Parse(Console.ReadLine())).Select(i => (int)i).ToArray();
    Console.WriteLine(arr.Sum());
  }
}
