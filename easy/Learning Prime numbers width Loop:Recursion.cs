using System;
using System.Linq;
public class Program {
  public static void Main() {
    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int m = Math.Max(arr[0],2), n = Math.Max(arr[1],0)+1;
    Console.Write(String.Join("\n",Enumerable.Range(m,n-m).Where(x=>Enumerable.Range(2,x-2).All(y=>x%y!=0))));
  }
}
