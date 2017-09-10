using System;
using System.Linq;
public class Program {
  public static void Main() {
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Array.Sort(arr);
    Console.WriteLine(string.Join(" ", arr));
  }
}