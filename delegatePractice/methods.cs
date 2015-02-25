using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatePractice
{
  class methods
  {
    public static void PrintText()
    {
      Console.WriteLine("text printed via action");
    }

    public static void PrintNumbersUp(int start, int target)
    {
      for (int i = start; i <= target; i++)
      {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
    }

    public static void PrintNumbersDown(int start, int target) {
      for (int i = target; i >= start; i--) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
    }

    public static int Addition(int a, int b)
    {
      return (a + b);
    }

    public static string DisplayAddition(int a, int b)
    {
      return string.Format("addition of {0} and {1} = {2}", a, b, Addition(a,b));
    }

  }

}
