using System;
using System.Linq;

public class Program {
  public static void Main() {
    int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if(ab[0] == 11) ab[0] = 1;
    if(ab[1] == 11) ab[1] = 1;
    Console.WriteLine(ab.Sum() > 20? 0:ab.Sum());
  }
}
